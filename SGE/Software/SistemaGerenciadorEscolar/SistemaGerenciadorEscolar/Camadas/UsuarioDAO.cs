using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class UsuarioDAO
    {
        public int IncluirUsuario(DTO.UsuarioDTO usuariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //CRIANDO CONEXÃO
                con.ConnectionString = Properties.Settings.Default.csTCC;
                //CRIANDO COMANDO SQL
                SqlCommand cm = new SqlCommand();
                //MOSTRANDO QUAL TIP DO COMANDO VAI SER USADO, NO CAS STORED PROCEDURE
                cm.CommandText = CommandType.StoredProcedure.ToString();
                //ABRINDO CONEXÃO
                con.Open();
                //EXECUTANDO PROCEDURE
                cm.CommandText = "exec sp_usuario_generico 1,null,@id_tipo_usu,@usuario,@senha";

                cm.Parameters.Add("@id_tipo_usu", SqlDbType.Int).Value = usuariodto.Tipo_usu;
                cm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuariodto.Login;
                cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuariodto.Senha;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;

            }
        }
        public IList<DTO.UsuarioDTO> ConsultaUsuario()
        {
            //USING = FECHAR CONEXÃO AUTOMATICO
            using (SqlConnection con = new SqlConnection())
            {
                //CRIANDO CONEXÃO
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                //MOSTRANDO QUAL TIPO DO COMANDO VAI SER USADO, NO CASO É TEXT (INSERT,UPDATE,DELETE,SELECT)
                cm.CommandType = CommandType.Text;
                //SINTAXE DO COMANDO
                cm.CommandText = "select * from tb_usuario";
                cm.Connection = con;
                //CRIANDO UM LEITOR PARA LER O BANCO
                SqlDataReader leitor;
                //LISTA DE USUARIO QUE VAI SER LIDO
                IList<DTO.UsuarioDTO> listausuarioDTO = new List<DTO.UsuarioDTO>();
                //ABRIR CONEXÃO
                con.Open();
                //MANDA EXECUTAR O LEITOR
                leitor = cm.ExecuteReader();
                //VERIFICAR QUANTIDADE DE LINHAS QUE SERÃO RETORNADAS
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.UsuarioDTO usuario = new DTO.UsuarioDTO();

                        usuario.Id_usu = Convert.ToInt32(leitor["id_usu"]);
                        usuario.Tipo_usu = Convert.ToInt32(leitor["id_tipo_usu"]);
                        usuario.Login = Convert.ToString(leitor["usuario"]);
                        usuario.Senha = Convert.ToString(leitor["senha"]);

                        listausuarioDTO.Add(usuario);
                    }
                }
                return listausuarioDTO;
            }
        }

        public int AlterarUsuario(DTO.UsuarioDTO usuariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_usuario_generico 2,@id_usu,@id_tipo_usu,@usuario,@senha";

                cm.Parameters.Add("id_usu", SqlDbType.Int).Value = usuariodto.Id_usu;
                cm.Parameters.Add("id_tipo_usu", SqlDbType.Int).Value = usuariodto.Tipo_usu;
                cm.Parameters.Add("usuario", SqlDbType.VarChar).Value = usuariodto.Login;
                cm.Parameters.Add("senha", SqlDbType.VarChar).Value = usuariodto.Senha;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }

        internal int ExcluirUsuario(DTO.UsuarioDTO usuariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_usuario_generico 3,@id_usu,null,null,null";
                cm.Parameters.Add("id_usu", SqlDbType.Int).Value = usuariodto.Id_usu;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }

        public DTO.UsuarioDTO AutenticarUsuario(DTO.UsuarioDTO usuariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_usuario where usuario=@loginUsu and senha=@senhaUsu ";
                cm.Connection = con;

                cm.Parameters.Add("usuario", SqlDbType.VarChar).Value = usuariodto.Login;
                cm.Parameters.Add("senha", SqlDbType.VarChar).Value = usuariodto.Senha;

                SqlDataReader leitor;

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.UsuarioDTO usuario = new DTO.UsuarioDTO();

                        usuariodto.Login = Convert.ToString(leitor["usuario"]);
                        usuariodto.Senha = Convert.ToString(leitor["senha"]);
                    }
                }
                else
                {
                    usuariodto.Login = null;
                    usuariodto.Senha = null;
                }

                return usuariodto;
            }
        }

        public IList<DTO.UsuarioDTO> BuscarUsuario(DTO.UsuarioDTO usuariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_usuario where usuario like @Login + '%'";
                cm.Connection = con;

                cm.Parameters.Add("usuario", SqlDbType.VarChar).Value = usuariodto.Login;
                SqlDataReader leitor;

                IList<DTO.UsuarioDTO> listausuarioDTO = new List<DTO.UsuarioDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.UsuarioDTO usuario = new DTO.UsuarioDTO();

                        usuario.Id_usu = Convert.ToInt32(leitor["id_usu"]);
                        usuario.Tipo_usu = Convert.ToInt32(leitor["id_tipo_usu"]);
                        usuario.Login = Convert.ToString(leitor["usuario"]);
                        usuario.Senha = Convert.ToString(leitor["senha"]);

                        listausuarioDTO.Add(usuario);
                    }
                }
                return listausuarioDTO;
            }
        }
    }
}

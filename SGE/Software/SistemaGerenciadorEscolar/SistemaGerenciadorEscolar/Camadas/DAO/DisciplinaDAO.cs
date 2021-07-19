using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class DisciplinaDAO
    {
        public int IncluirDisciplina(DTO.DisciplinaDTO disciplinadto)
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
                cm.CommandText = "exec sp_disciplina_generico 1,@id_disc,@disciplina,@carga_horaria";

                cm.Parameters.Add("@id_disc", SqlDbType.Int).Value = disciplinadto.Id_disc;
                cm.Parameters.Add("@disciplina", SqlDbType.VarChar).Value = disciplinadto.Disciplina;
                cm.Parameters.Add("@carga_horaria", SqlDbType.VarChar).Value = disciplinadto.Carga_horario;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.DisciplinaDTO> ConsultaDisciplina()
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
                cm.CommandText = "select * from tb_disciplina";
                cm.Connection = con;
                //CRIANDO UM LEITOR PARA LER O BANCO
                SqlDataReader leitor;
                //LISTA DE USUARIO QUE VAI SER LIDO
                IList<DTO.DisciplinaDTO> listadisciplinaDTO = new List<DTO.DisciplinaDTO>();
                //ABRIR CONEXÃO
                con.Open();
                //MANDA EXECUTAR O LEITOR
                leitor = cm.ExecuteReader();
                //VERIFICAR QUANTIDADE DE LINHAS QUE SERÃO RETORNADAS
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.DisciplinaDTO disciplina = new DTO.DisciplinaDTO();

                        disciplina.Id_disc = Convert.ToInt32(leitor["id_disc"]);
                        disciplina.Disciplina = Convert.ToString(leitor["disciplina"]);
                        disciplina.Carga_horario = Convert.ToString(leitor["carga_horaria"]);


                        listadisciplinaDTO.Add(disciplina);
                    }
                }
                return listadisciplinaDTO;
            }
        }
        public int AlterarDisciplina(DTO.DisciplinaDTO disciplinadto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_disciplina_generico 2,@id_disc,@disciplina,@carga_horaria";

                cm.Parameters.Add("id_disc", SqlDbType.Int).Value = disciplinadto.Id_disc;
                cm.Parameters.Add("disciplina", SqlDbType.VarChar).Value = disciplinadto.Disciplina;
                cm.Parameters.Add("carga_horaria", SqlDbType.VarChar).Value = disciplinadto.Carga_horario;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }

        internal int ExcluirDisciplina(DTO.DisciplinaDTO disciplinadto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_disciplina_generico 3,@id_disc,null,null";
                cm.Parameters.Add("id_disc", SqlDbType.Int).Value = disciplinadto.Id_disc;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }

        public IList<DTO.DisciplinaDTO> BuscarDisciplina(DTO.DisciplinaDTO disciplinadto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_disciplina where disciplina like @Disciplina + '%'";
                cm.Connection = con;

                cm.Parameters.Add("disciplina", SqlDbType.VarChar).Value = disciplinadto.Disciplina;
                SqlDataReader leitor;

                IList<DTO.DisciplinaDTO> listadisciplinaDTO = new List<DTO.DisciplinaDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.DisciplinaDTO disciplina = new DTO.DisciplinaDTO();

                        disciplina.Id_disc = Convert.ToInt32(leitor["id_disc"]);
                        disciplina.Disciplina = Convert.ToString(leitor["disciplina"]);
                        disciplina.Carga_horario = Convert.ToString(leitor["carga_horaria"]);

                        listadisciplinaDTO.Add(disciplina);
                    }
                }
                return listadisciplinaDTO;
            }
        }
    }
}

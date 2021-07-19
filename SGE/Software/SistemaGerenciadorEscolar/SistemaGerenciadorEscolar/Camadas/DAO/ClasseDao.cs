using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class ClasseDao
    {
        public int IncluirClasse(DTO.ClasseDTO classedto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_classe_generico 1,null,@id_curso,@classe";

                cm.Parameters.Add("id_curso", SqlDbType.Int).Value = classedto.Id_curso;
                cm.Parameters.Add("classe", SqlDbType.VarChar).Value = classedto.Classe;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.ClasseDTO> ConsultaClasse()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select tb_classe.id_classe,tb_classe.classe,tb_classe.id_curso,tb_curso.curso "+
                                    "from tb_classe "+
                                    "join tb_curso on tb_classe.id_curso = tb_curso.id_curso";

                cm.Connection = con;
                SqlDataReader leitor;

                List<DTO.ClasseDTO> listaclasseDTO = new List<DTO.ClasseDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.ClasseDTO classe = new DTO.ClasseDTO();

                        classe.Id_classe = Convert.ToInt32(leitor["id_classe"]);
                        classe.Id_curso = Convert.ToInt32(leitor["id_curso"]);
                        classe.Classe = Convert.ToString(leitor["classe"]);
                        classe.Curso = Convert.ToString(leitor["curso"]);

                        listaclasseDTO.Add(classe);
                    }
                }
                return listaclasseDTO;
            }
        }
        public int AlterarClasse(DTO.ClasseDTO classedto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_classe_generico 2,@id_classe,@id_curso,@classe";

                cm.Parameters.Add("id_classe", SqlDbType.Int).Value = classedto.Id_classe;
                cm.Parameters.Add("id_curso", SqlDbType.Int).Value = classedto.Id_curso;
                cm.Parameters.Add("classe", SqlDbType.VarChar).Value = classedto.Classe;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int ExcluirClasse(DTO.ClasseDTO classedto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_classe_generico 3,@id_classe,null,null";

                cm.Parameters.Add("id_classe", SqlDbType.Int).Value = classedto.Id_classe;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.ClasseDTO> BuscarClasse(DTO.ClasseDTO classedto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_classe where classe like @Classe + '%'";
                cm.Connection = con;

                cm.Parameters.Add("classe", SqlDbType.VarChar).Value = classedto.Classe;

                SqlDataReader leitor;

                List<DTO.ClasseDTO> listaclasseDTO = new List<DTO.ClasseDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.ClasseDTO classe = new DTO.ClasseDTO();

                        classe.Id_classe = Convert.ToInt32(leitor["id_classe"]);
                        classe.Id_curso = Convert.ToInt32(leitor["id_curso"]);
                        classe.Classe = Convert.ToString(leitor["classe"]);

                        listaclasseDTO.Add(classe);
                    }
                }
                return listaclasseDTO;
            }
        }
    }
}

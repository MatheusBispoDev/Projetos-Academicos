using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class Classe_AlunoDAO
    {
        public int IncluirClasse_Aluno(DTO.Classe_AlunoDTO classe_Aluno)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;

                SqlCommand cm = new SqlCommand();

                con.Open();

                cm.CommandText = CommandType.Text.ToString();

                cm.CommandText = "insert into tb_classe_aluno values (@id_classe,@id_aluno)";

                cm.Parameters.Add("@id_classe", SqlDbType.Int).Value = classe_Aluno.Id_classe;
                cm.Parameters.Add("@id_aluno", SqlDbType.Int).Value = classe_Aluno.Id_aluno;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.Classe_AlunoDTO> ConsultarClasse_Aluno()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select tb_classe_aluno.id_classe_aluno,tb_classe.id_classe,tb_classe.classe,tb_aluno.id_aluno,tb_aluno.nome_aluno "+
                                    "from tb_classe_aluno "+
                                    "inner join tb_classe on tb_classe_aluno.id_classe = tb_classe.id_classe "+
                                    "inner join tb_aluno on tb_classe_aluno.id_aluno = tb_aluno.id_aluno";

                cm.Connection = con;

                SqlDataReader leitor;

                IList<DTO.Classe_AlunoDTO> listaclasse_alunodto = new List<DTO.Classe_AlunoDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.Classe_AlunoDTO classe_aluno = new DTO.Classe_AlunoDTO();

                        classe_aluno.Id_classe_aluno = Convert.ToInt32(leitor["id_classe_aluno"]);
                        classe_aluno.Id_classe = Convert.ToInt32(leitor["id_classe"]);
                        classe_aluno.Id_aluno = Convert.ToInt32(leitor["id_aluno"]);
                        classe_aluno.Classe = Convert.ToString(leitor["classe"]);
                        classe_aluno.Aluno = Convert.ToString(leitor["nome_aluno"]);

                        listaclasse_alunodto.Add(classe_aluno);
                    }
                }
                return listaclasse_alunodto;
            }
        }
        public int AlterarClasse_Aluno(DTO.Classe_AlunoDTO classe_alunodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.Text.ToString();

                con.Open();

                cm.CommandText = "update tb_classe_aluno set id_classe = @id_classe, id_aluno = @id_aluno where id_classe_aluno = @id_classe_aluno";

                cm.Parameters.Add("id_classe_aluno", SqlDbType.Int).Value = classe_alunodto.Id_classe_aluno;
                cm.Parameters.Add("id_classe", SqlDbType.Int).Value = classe_alunodto.Id_classe;
                cm.Parameters.Add("id_aluno", SqlDbType.Int).Value = classe_alunodto.Id_aluno;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int ExcluirClasse_Aluno(DTO.Classe_AlunoDTO classe_alunodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.Text.ToString();
                con.Open();

                cm.CommandText = "delete from tb_classe_aluno where id_classe_aluno = @id_classe_aluno";

                cm.Parameters.Add("id_classe_aluno", SqlDbType.Int).Value = classe_alunodto.Id_classe_aluno;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
    }
}

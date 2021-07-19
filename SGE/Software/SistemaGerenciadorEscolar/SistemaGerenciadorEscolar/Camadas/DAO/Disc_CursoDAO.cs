using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class Disc_CursoDAO
    {
        public int IncluirDisc_Curso(DTO.Disc_CursoDTO disc_cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;

                SqlCommand cm = new SqlCommand();

                con.Open();

                cm.CommandText = CommandType.Text.ToString();

                cm.CommandText = "insert into tb_disciplina_curso values (@id_disc,@id_curso)";

                cm.Parameters.Add("@id_disc", SqlDbType.Int).Value = disc_cursodto.Id_disc;
                cm.Parameters.Add("@id_curso", SqlDbType.Int).Value = disc_cursodto.Id_curso;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.Disc_CursoDTO> ConsultaDisc_Curso()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select tb_disciplina_curso.id_disc_curso,tb_disciplina.id_disc,tb_disciplina.disciplina,tb_curso.id_curso,tb_curso.curso "+
                                    "from tb_disciplina_curso "+
                                    "inner join tb_disciplina on tb_disciplina_curso.id_disc = tb_disciplina.id_disc "+
                                    "inner join tb_curso on tb_disciplina_curso.id_curso = tb_curso.id_curso";
                cm.Connection = con;

                SqlDataReader leitor;

                IList<DTO.Disc_CursoDTO> listadisc_cursodto = new List<DTO.Disc_CursoDTO>();
                con.Open();
                leitor = cm.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.Disc_CursoDTO disc_curso = new DTO.Disc_CursoDTO();

                        disc_curso.Id_disc_curso = Convert.ToInt32(leitor["id_disc_curso"]);
                        disc_curso.Id_disc = Convert.ToInt32(leitor["id_disc"]);
                        disc_curso.Id_curso = Convert.ToInt32(leitor["id_curso"]);
                        disc_curso.Disciplina = Convert.ToString(leitor["disciplina"]);
                        disc_curso.Curso = Convert.ToString(leitor["curso"]);

                        listadisc_cursodto.Add(disc_curso);
                    }
                }
                return listadisc_cursodto;
            }
        }
        public int AlterarDisc_Curso(DTO.Disc_CursoDTO disc_cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.Text.ToString();
                con.Open();

                cm.CommandText = "update tb_disciplina_curso set id_disc=@id_disc ,id_curso=@id_curso where id_disc_curso = @id_disc_curso";

                cm.Parameters.Add("id_disc_curso", SqlDbType.Int).Value = disc_cursodto.Id_disc_curso;
                cm.Parameters.Add("id_disc", SqlDbType.Int).Value = disc_cursodto.Id_disc;
                cm.Parameters.Add("id_curso", SqlDbType.Int).Value = disc_cursodto.Id_curso;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int ExcluirDisc_Curso(DTO.Disc_CursoDTO disc_cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.Text.ToString();
                con.Open();

                cm.CommandText = "delete from tb_disciplina_curso where id_disc_curso = @id_disc_curso";

                cm.Parameters.Add("id_disc_curso", SqlDbType.Int).Value = disc_cursodto.Id_disc_curso;
                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
    }
}

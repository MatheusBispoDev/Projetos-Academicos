using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class Prof_Disc_CursoDAO
    {
        public int IncluirProf_Disc_Curso(DTO.Prof_Disc_CursoDTO prof_disc_cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                con.Open();
                cm.CommandText = CommandType.Text.ToString();

                cm.CommandText = "insert into tb_professor_curso values (@id_prof,@id_disc_prof)";

                cm.Parameters.Add("@id_prof", SqlDbType.Int).Value = prof_disc_cursodto.Id_prof;
                cm.Parameters.Add("@id_disc_prof", SqlDbType.Int).Value = prof_disc_cursodto.Id_disc_curso;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.Prof_Disc_CursoDTO> ConsultarProf_Disc_Curso()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select tb_professor_curso.id_prof_curso,tb_professor.id_prof,tb_disciplina_curso.id_disc_curso,tb_professor.nome_prof,tb_curso.curso,tb_disciplina.disciplina " +
                                    "from tb_professor_curso "+
                                    "inner join tb_professor on tb_professor_curso.id_prof = tb_professor.id_prof "+
                                    "inner join tb_disciplina_curso on tb_professor_curso.id_disc_curso = tb_disciplina_curso.id_disc_curso "+
                                    "inner join tb_disciplina on tb_disciplina_curso.id_disc = tb_disciplina.id_disc "+
                                    "inner join tb_curso on tb_disciplina_curso.id_curso = tb_curso.id_curso";
                cm.Connection = con;

                SqlDataReader leitor;

                IList<DTO.Prof_Disc_CursoDTO> listaprof_disc_curso = new List<DTO.Prof_Disc_CursoDTO>();
                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.Prof_Disc_CursoDTO prof_disc_curso = new DTO.Prof_Disc_CursoDTO();

                        prof_disc_curso.Id_prof_curso = Convert.ToInt32(leitor["id_prof_curso"]);
                        prof_disc_curso.Id_prof = Convert.ToInt32(leitor["id_prof"]);
                        prof_disc_curso.Id_disc_curso = Convert.ToInt32(leitor["id_disc_curso"]);
                        prof_disc_curso.Professor = Convert.ToString(leitor["nome_prof"]);
                        prof_disc_curso.Curso = Convert.ToString(leitor["curso"]);
                        prof_disc_curso.Disciplina = Convert.ToString(leitor["disciplina"]);

                        listaprof_disc_curso.Add(prof_disc_curso);
                    }
                }
                return listaprof_disc_curso;
            }
        }
        public int AlterarProf_Disc_Curso(DTO.Prof_Disc_CursoDTO prof_disc_cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.Text.ToString();
                con.Open();

                cm.CommandText = "update tb_professor_curso set id_prof = @id_prof, id_disc_curso where id_prof_curso = @id_prof_curso";

                cm.Parameters.Add("id_prof_curso", SqlDbType.Int).Value = prof_disc_cursodto.Id_prof_curso;
                cm.Parameters.Add("id_prof", SqlDbType.Int).Value = prof_disc_cursodto.Id_prof;
                cm.Parameters.Add("id_disc_curso", SqlDbType.Int).Value = prof_disc_cursodto.Id_disc_curso;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int ExcluirProf_Disc_Curso(DTO.Prof_Disc_CursoDTO prof_disc_cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.Text.ToString();
                con.Open();

                cm.CommandText = "delete from tb_professor_curso where id_prof_curso = @id_prof_curso";

                cm.Parameters.Add("id_prof_curso", SqlDbType.Int).Value = prof_disc_cursodto.Id_prof_curso;
                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
    }
}

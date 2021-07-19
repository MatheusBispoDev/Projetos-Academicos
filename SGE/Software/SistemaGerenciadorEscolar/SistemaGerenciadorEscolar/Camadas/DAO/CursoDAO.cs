using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class CursoDAO
    {
        public int IncluirCurso(DTO.CursoDTO cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();

                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_curso_generico 1,null,@curso,@modulo_serie,@periodo_curso";

                cm.Parameters.Add("@curso", SqlDbType.VarChar).Value = cursodto.Curso;
                cm.Parameters.Add("@modulo_serie", SqlDbType.VarChar).Value = cursodto.Modulo_Curso;
                cm.Parameters.Add("@periodo_curso", SqlDbType.VarChar).Value = cursodto.Periodo_curso;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }

        public IList<DTO.CursoDTO> ConsultarCurso()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_curso";
                cm.Connection = con;

                SqlDataReader leitor;

                IList<DTO.CursoDTO> listacursoDTO = new List<DTO.CursoDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.CursoDTO curso = new DTO.CursoDTO();

                        curso.Id_curso = Convert.ToInt32(leitor["id_curso"]);
                        curso.Curso = Convert.ToString(leitor["curso"]);
                        curso.Modulo_Curso = Convert.ToString(leitor["modulo_serie"]);
                        curso.Periodo_curso = Convert.ToString(leitor["periodo_curso"]);

                        listacursoDTO.Add(curso);
                    }
                }
                return listacursoDTO;
            }
        }

        public int AlterarCurso(DTO.CursoDTO cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_curso_generico 2,@id_curso,@curso,@modulo_serie,@periodo_curso";

                cm.Parameters.Add("id_curso", SqlDbType.Int).Value = cursodto.Id_curso;
                cm.Parameters.Add("curso", SqlDbType.VarChar).Value = cursodto.Curso;
                cm.Parameters.Add("modulo_serie", SqlDbType.VarChar).Value = cursodto.Modulo_Curso;
                cm.Parameters.Add("periodo_curso", SqlDbType.VarChar).Value = cursodto.Periodo_curso;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }

        internal int ExcluirCurso(DTO.CursoDTO cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_curso_generico 3,@id_curso,null,null,null";
                cm.Parameters.Add("id_curso", SqlDbType.Int).Value = cursodto.Id_curso;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.CursoDTO> BuscarCurso(DTO.CursoDTO cursodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_curso where curso like @Curso + '%'";
                cm.Connection = con;

                cm.Parameters.Add("curso", SqlDbType.VarChar).Value = cursodto.Curso;

                SqlDataReader leitor;

                IList<DTO.CursoDTO> listacursoDTO = new List<DTO.CursoDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                         DTO.CursoDTO curso = new DTO.CursoDTO();

                        curso.Id_curso = Convert.ToInt32(leitor["id_curso"]);
                        curso.Curso = Convert.ToString(leitor["curso"]);
                        curso.Modulo_Curso = Convert.ToString(leitor["modulo_serie"]);
                        curso.Periodo_curso = Convert.ToString(leitor["periodo_curso"]);

                        listacursoDTO.Add(curso);
                    }       
                }
                     return listacursoDTO;
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class ProfessorDAO
    {
        public int IncluirProfessor(DTO.ProfessorDTO professordto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();

                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_professor_generico 1,null,@nome_prof,@sexo_prof,@data_nascimento_prof," +
                                "@logra_prof,@bairro_prof,@cidade_prof,@uf_prof,@comp_logra_prof,@numero_casa_prof," +
                                "@rg_prof,@cpf_prof,@tel_prof,@cel_prof,@email_prof,@foto_prof,@curriculum_prof,@data_admissao_prof";

                cm.Parameters.Add("@nome_prof", SqlDbType.VarChar).Value = professordto.Nome_prof;
                cm.Parameters.Add("@sexo_prof", SqlDbType.VarChar).Value = professordto.Sexo_prof;
                cm.Parameters.Add("@data_nascimento_prof", SqlDbType.VarChar).Value = professordto.Data_nascimento_prof;
                cm.Parameters.Add("@logra_prof", SqlDbType.VarChar).Value = professordto.Logra_prof;
                cm.Parameters.Add("@bairro_prof", SqlDbType.VarChar).Value = professordto.Bairro_prof;
                cm.Parameters.Add("@cidade_prof", SqlDbType.VarChar).Value = professordto.Cidade_prof;
                cm.Parameters.Add("@uf_prof", SqlDbType.VarChar).Value = professordto.Uf_prof;
                cm.Parameters.Add("@comp_logra_prof", SqlDbType.VarChar).Value = professordto.Comp_logra_prof;
                cm.Parameters.Add("@numero_casa_prof", SqlDbType.VarChar).Value = professordto.Numero_casa_prof;
                cm.Parameters.Add("@rg_prof", SqlDbType.VarChar).Value = professordto.Rg_prof;
                cm.Parameters.Add("@cpf_prof", SqlDbType.VarChar).Value = professordto.Cpf_prof;
                cm.Parameters.Add("@tel_prof", SqlDbType.VarChar).Value = professordto.Tel_prof;
                cm.Parameters.Add("@cel_prof", SqlDbType.VarChar).Value = professordto.Cel_prof;
                cm.Parameters.Add("@email_prof", SqlDbType.VarChar).Value = professordto.Email_prof;
                cm.Parameters.Add("@foto_prof", SqlDbType.VarChar).Value = professordto.Foto_prof;
                cm.Parameters.Add("@curriculum_prof", SqlDbType.VarChar).Value = professordto.Curriculum_prof;
                cm.Parameters.Add("@data_admissao_prof", SqlDbType.VarChar).Value = professordto.Data_admissao_prof;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.ProfessorDTO> ConsultaProfessor()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_professor";
                cm.Connection = con;

                SqlDataReader leitor;

                IList<DTO.ProfessorDTO> listaprofessorDTO = new List<DTO.ProfessorDTO>();
                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.ProfessorDTO professor = new DTO.ProfessorDTO();

                        professor.Id_prof = Convert.ToInt32(leitor["id_prof"]);
                        professor.Nome_prof = Convert.ToString(leitor["nome_prof"]);
                        professor.Sexo_prof = Convert.ToString(leitor["sexo_prof"]);
                        professor.Data_nascimento_prof = Convert.ToString(leitor["data_nascimento_prof"]);
                        professor.Logra_prof = Convert.ToString(leitor["logra_prof"]);
                        professor.Bairro_prof = Convert.ToString(leitor["bairro_prof"]);
                        professor.Cidade_prof = Convert.ToString(leitor["cidade_prof"]);
                        professor.Uf_prof = Convert.ToString(leitor["uf_prof"]);
                        professor.Comp_logra_prof = Convert.ToString(leitor["comp_logra_prof"]);
                        professor.Numero_casa_prof = Convert.ToString(leitor["numero_casa_prof"]);
                        professor.Rg_prof = Convert.ToString(leitor["rg_prof"]);
                        professor.Cpf_prof = Convert.ToString(leitor["cpf_prof"]);
                        professor.Tel_prof = Convert.ToString(leitor["tel_prof"]);
                        professor.Cel_prof = Convert.ToString(leitor["cel_prof"]);
                        professor.Email_prof = Convert.ToString(leitor["email_prof"]);
                        professor.Foto_prof = Convert.ToString(leitor["foto_prof"]);
                        professor.Curriculum_prof = Convert.ToString(leitor["curriculum_prof"]);
                        professor.Data_admissao_prof = Convert.ToString(leitor["data_admissao_prof"]);

                        listaprofessorDTO.Add(professor);
                    }
                }
                return listaprofessorDTO;
            }
        }

        public int AlterarProfessor(DTO.ProfessorDTO professordto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_professor_generico 2,@id_prof,@nome_prof,@sexo_prof,@data_nascimento_prof," +
                                "@logra_prof,@bairro_prof,@cidade_prof,@uf_prof,@comp_logra_prof,@numero_casa_prof," +
                                "@rg_prof,@cpf_prof,@tel_prof,@cel_prof,@email_prof,@foto_prof,@curriculum_prof,@data_admissao_prof";

                cm.Parameters.Add("id_prof", SqlDbType.Int).Value = professordto.Id_prof;
                cm.Parameters.Add("nome_prof", SqlDbType.VarChar).Value = professordto.Nome_prof;
                cm.Parameters.Add("sexo_prof", SqlDbType.VarChar).Value = professordto.Sexo_prof;
                cm.Parameters.Add("data_nascimento_prof", SqlDbType.VarChar).Value = professordto.Data_nascimento_prof;
                cm.Parameters.Add("logra_prof", SqlDbType.VarChar).Value = professordto.Logra_prof;
                cm.Parameters.Add("bairro_prof", SqlDbType.VarChar).Value = professordto.Bairro_prof;
                cm.Parameters.Add("cidade_prof", SqlDbType.VarChar).Value = professordto.Cidade_prof;
                cm.Parameters.Add("uf_prof", SqlDbType.VarChar).Value = professordto.Uf_prof;
                cm.Parameters.Add("comp_logra_prof", SqlDbType.VarChar).Value = professordto.Comp_logra_prof;
                cm.Parameters.Add("numero_casa_prof", SqlDbType.VarChar).Value = professordto.Numero_casa_prof;
                cm.Parameters.Add("rg_prof", SqlDbType.VarChar).Value = professordto.Rg_prof;
                cm.Parameters.Add("cpf_prof", SqlDbType.VarChar).Value = professordto.Cpf_prof;
                cm.Parameters.Add("tel_prof", SqlDbType.VarChar).Value = professordto.Tel_prof;
                cm.Parameters.Add("cel_prof", SqlDbType.VarChar).Value = professordto.Cel_prof;
                cm.Parameters.Add("email_prof", SqlDbType.VarChar).Value = professordto.Email_prof;
                cm.Parameters.Add("foto_prof", SqlDbType.VarChar).Value = professordto.Foto_prof;
                cm.Parameters.Add("curriculum_prof", SqlDbType.VarChar).Value = professordto.Curriculum_prof;
                cm.Parameters.Add("data_admissao_prof", SqlDbType.VarChar).Value = professordto.Data_admissao_prof;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int ExcluirProfessor(DTO.ProfessorDTO professordto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_professor_generico 3,@id_prof,null,null,null,null,null,null,null,null" +
                                "null,null,null,null,null,null,null,null,null,null";

                cm.Parameters.Add("id_prof", SqlDbType.Int).Value = professordto.Id_prof;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.ProfessorDTO> BuscarProfNome(DTO.ProfessorDTO professordto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_professor where nome_prof like @Nome_prof + '%'";
                cm.Connection = con;

                cm.Parameters.Add("nome_prof", SqlDbType.VarChar).Value = professordto.Nome_prof;

                SqlDataReader leitor;

                IList<DTO.ProfessorDTO> listaprofessorDTO = new List<DTO.ProfessorDTO>();
                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.ProfessorDTO professor = new DTO.ProfessorDTO();

                        professor.Id_prof = Convert.ToInt32(leitor["id_prof"]);
                        professor.Nome_prof = Convert.ToString(leitor["nome_prof"]);
                        professor.Sexo_prof = Convert.ToString(leitor["sexo_prof"]);
                        professor.Data_nascimento_prof = Convert.ToString(leitor["data_nascimento_prof"]);
                        professor.Logra_prof = Convert.ToString(leitor["logra_prof"]);
                        professor.Bairro_prof = Convert.ToString(leitor["bairro_prof"]);
                        professor.Cidade_prof = Convert.ToString(leitor["cidade_prof"]);
                        professor.Uf_prof = Convert.ToString(leitor["uf_prof"]);
                        professor.Comp_logra_prof = Convert.ToString(leitor["comp_logra_prof"]);
                        professor.Numero_casa_prof = Convert.ToString(leitor["numero_casa_prof"]);
                        professor.Rg_prof = Convert.ToString(leitor["rg_prof"]);
                        professor.Cpf_prof = Convert.ToString(leitor["cpf_prof"]);
                        professor.Tel_prof = Convert.ToString(leitor["tel_prof"]);
                        professor.Cel_prof = Convert.ToString(leitor["cel_prof"]);
                        professor.Email_prof = Convert.ToString(leitor["email_prof"]);
                        professor.Foto_prof = Convert.ToString(leitor["foto_prof"]);
                        professor.Curriculum_prof = Convert.ToString(leitor["curriculum_prof"]);
                        professor.Data_admissao_prof = Convert.ToString(leitor["data_admissao_prof"]);

                        listaprofessorDTO.Add(professor);
                    }
                }
                return listaprofessorDTO;
            }
        }
        public IList<DTO.ProfessorDTO> BuscarProfRG(DTO.ProfessorDTO professordto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_professor where rg_prof like @RG_prof + '%'";
                cm.Connection = con;

                cm.Parameters.Add("rg_prof", SqlDbType.VarChar).Value = professordto.Rg_prof;

                SqlDataReader leitor;

                IList<DTO.ProfessorDTO> listaprofessorDTO = new List<DTO.ProfessorDTO>();
                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.ProfessorDTO professor = new DTO.ProfessorDTO();

                        professor.Id_prof = Convert.ToInt32(leitor["id_prof"]);
                        professor.Nome_prof = Convert.ToString(leitor["nome_prof"]);
                        professor.Sexo_prof = Convert.ToString(leitor["sexo_prof"]);
                        professor.Data_nascimento_prof = Convert.ToString(leitor["data_nascimento_prof"]);
                        professor.Logra_prof = Convert.ToString(leitor["logra_prof"]);
                        professor.Bairro_prof = Convert.ToString(leitor["bairro_prof"]);
                        professor.Cidade_prof = Convert.ToString(leitor["cidade_prof"]);
                        professor.Uf_prof = Convert.ToString(leitor["uf_prof"]);
                        professor.Comp_logra_prof = Convert.ToString(leitor["comp_logra_prof"]);
                        professor.Numero_casa_prof = Convert.ToString(leitor["numero_casa_prof"]);
                        professor.Rg_prof = Convert.ToString(leitor["rg_prof"]);
                        professor.Cpf_prof = Convert.ToString(leitor["cpf_prof"]);
                        professor.Tel_prof = Convert.ToString(leitor["tel_prof"]);
                        professor.Cel_prof = Convert.ToString(leitor["cel_prof"]);
                        professor.Email_prof = Convert.ToString(leitor["email_prof"]);
                        professor.Foto_prof = Convert.ToString(leitor["foto_prof"]);
                        professor.Curriculum_prof = Convert.ToString(leitor["curriculum_prof"]);
                        professor.Data_admissao_prof = Convert.ToString(leitor["data_admissao_prof"]);

                        listaprofessorDTO.Add(professor);
                    }
                }
                return listaprofessorDTO;
            }
        }
    }
    
}

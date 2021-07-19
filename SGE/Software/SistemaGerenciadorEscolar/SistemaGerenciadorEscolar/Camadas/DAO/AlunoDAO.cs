using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class AlunoDAO
    {
        public int IncluirAluno(DTO.AlunoDTO alunodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();

                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_aluno_generico 1,null,@nome_aluno,@sexo,@data_nascimento_aluno,@logra_aluno,@bairro_aluno,"+
                                 "@cidade_aluno,@comp_logra_aluno,@numero_casa_aluno,@uf_aluno,@rg_aluno,@cpf_aluno,@tel_aluno,"+
                                 "@cel_aluno,@email_aluno,@foto_aluno,@nome_resp_um,@tel_resp_um,@cel_resp_um,@email_resp_um,@rg_resp_um," +
                                 "@cpf_resp_um,@hist_aluno";

                cm.Parameters.Add("@nome_aluno", SqlDbType.VarChar).Value = alunodto.Nome_aluno;
                cm.Parameters.Add("@sexo", SqlDbType.VarChar).Value = alunodto.Sexo_aluno;
                cm.Parameters.Add("@data_nascimento_aluno", SqlDbType.VarChar).Value = alunodto.Data_nascimento_aluno;
                cm.Parameters.Add("@logra_aluno", SqlDbType.VarChar).Value = alunodto.Logra_aluno;
                cm.Parameters.Add("@bairro_aluno", SqlDbType.VarChar).Value = alunodto.Bairro_aluno;
                cm.Parameters.Add("@cidade_aluno", SqlDbType.VarChar).Value = alunodto.Cidade_aluno;
                cm.Parameters.Add("@comp_logra_aluno", SqlDbType.VarChar).Value = alunodto.Comp_logra_aluno;
                cm.Parameters.Add("@numero_casa_aluno", SqlDbType.VarChar).Value = alunodto.Numero_casa_aluno;
                cm.Parameters.Add("@uf_aluno", SqlDbType.VarChar).Value = alunodto.Uf_aluno;
                cm.Parameters.Add("@rg_aluno", SqlDbType.VarChar).Value = alunodto.Rg_aluno;
                cm.Parameters.Add("@cpf_aluno", SqlDbType.VarChar).Value = alunodto.Cpf_aluno;
                cm.Parameters.Add("@tel_aluno", SqlDbType.VarChar).Value = alunodto.Tel_aluno;
                cm.Parameters.Add("@cel_aluno", SqlDbType.VarChar).Value = alunodto.Cel_aluno;
                cm.Parameters.Add("@email_aluno", SqlDbType.VarChar).Value = alunodto.Email_aluno;
                cm.Parameters.Add("@foto_aluno", SqlDbType.VarChar).Value = alunodto.Foto_aluno;
                cm.Parameters.Add("@nome_resp_um", SqlDbType.VarChar).Value = alunodto.Nome_resp_um;
                cm.Parameters.Add("@tel_resp_um", SqlDbType.VarChar).Value = alunodto.Tel_resp_um;
                cm.Parameters.Add("@cel_resp_um", SqlDbType.VarChar).Value = alunodto.Cel_resp_um;
                cm.Parameters.Add("@email_resp_um", SqlDbType.VarChar).Value = alunodto.Email_resp_um;
                cm.Parameters.Add("@rg_resp_um", SqlDbType.VarChar).Value = alunodto.Rg_resp_um;
                cm.Parameters.Add("@cpf_resp_um", SqlDbType.VarChar).Value = alunodto.Cpf_resp_um;
                cm.Parameters.Add("@hist_aluno", SqlDbType.VarChar).Value = alunodto.Hist_aluno;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }

         public IList<DTO.AlunoDTO> ConsultarAluno()
          {
              using (SqlConnection con = new SqlConnection())
              {
                  con.ConnectionString = Properties.Settings.Default.csTCC;
                  SqlCommand cm = new SqlCommand();
                  cm.CommandType = CommandType.Text;

                  cm.CommandText = "select * from tb_aluno";
                  cm.Connection = con;

                  SqlDataReader leitor;

                  IList<DTO.AlunoDTO> listaalunoDTO = new List<DTO.AlunoDTO>();

                  con.Open();

                  leitor = cm.ExecuteReader();

                  if (leitor.HasRows)
                  {
                      while (leitor.Read())
                      {
                          DTO.AlunoDTO aluno = new DTO.AlunoDTO();

                          aluno.Id_aluno = Convert.ToInt32(leitor["id_aluno"]);
                          aluno.Nome_aluno = Convert.ToString(leitor["nome_aluno"]);
                          aluno.Sexo_aluno = Convert.ToString(leitor["sexo_aluno"]);
                          aluno.Data_nascimento_aluno = Convert.ToString(leitor["data_nascimento_aluno"]);
                          aluno.Logra_aluno = Convert.ToString(leitor["logra_aluno"]);
                          aluno.Bairro_aluno = Convert.ToString(leitor["bairro_aluno"]);
                          aluno.Cidade_aluno = Convert.ToString(leitor["cidade_aluno"]);
                          aluno.Comp_logra_aluno = Convert.ToString(leitor["comp_logra_aluno"]);
                          aluno.Numero_casa_aluno = Convert.ToString(leitor["numero_casa_aluno"]);
                          aluno.Uf_aluno = Convert.ToString(leitor["uf_aluno"]);
                          aluno.Rg_aluno = Convert.ToString(leitor["rg_aluno"]);
                          aluno.Cpf_aluno = Convert.ToString(leitor["cpf_aluno"]);
                          aluno.Tel_aluno = Convert.ToString(leitor["tel_aluno"]);
                          aluno.Cel_aluno = Convert.ToString(leitor["cel_aluno"]);
                          aluno.Email_aluno = Convert.ToString(leitor["email_aluno"]);
                          aluno.Foto_aluno = Convert.ToString(leitor["foto_aluno"]);
                          aluno.Nome_resp_um = Convert.ToString(leitor["nome_resp_um"]);
                          aluno.Tel_resp_um = Convert.ToString(leitor["tel_resp_um"]);
                          aluno.Cel_resp_um = Convert.ToString(leitor["cel_resp_um"]);
                          aluno.Email_resp_um = Convert.ToString(leitor["email_resp_um"]);
                          aluno.Rg_resp_um = Convert.ToString(leitor["rg_resp_um"]);
                          aluno.Cpf_resp_um = Convert.ToString(leitor["cpf_resp_um"]);
                          aluno.Hist_aluno = Convert.ToString(leitor["hist_aluno"]);

                          listaalunoDTO.Add(aluno);
                      }
                  }
                  return listaalunoDTO;
              }
          }
        public IList<DTO.AlunoDTO> ConsultarAluno1()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_aluno";
                cm.Connection = con;
                SqlDataReader leitor;

                IList<DTO.AlunoDTO> listaaluno = new List<DTO.AlunoDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.AlunoDTO aluno = new DTO.AlunoDTO();

                        aluno.Id_aluno = Convert.ToInt32(leitor["id_aluno"]);
                        aluno.Nome_aluno = Convert.ToString(leitor["nome_aluno"]);
                        aluno.Sexo_aluno = Convert.ToString(leitor["sexo_aluno"]);
                        aluno.Data_nascimento_aluno = Convert.ToString(leitor["data_nascimento_aluno"]);
                        aluno.Logra_aluno = Convert.ToString(leitor["logra_aluno"]);
                        aluno.Bairro_aluno = Convert.ToString(leitor["bairro_aluno"]);
                        aluno.Cidade_aluno = Convert.ToString(leitor["cidade_aluno"]);
                        aluno.Comp_logra_aluno = Convert.ToString(leitor["comp_logra_aluno"]);
                        aluno.Numero_casa_aluno = Convert.ToString(leitor["numero_casa_aluno"]);
                        aluno.Uf_aluno = Convert.ToString(leitor["uf_aluno"]);
                        aluno.Rg_aluno = Convert.ToString(leitor["rg_aluno"]);
                        aluno.Cpf_aluno = Convert.ToString(leitor["cpf_aluno"]);
                        aluno.Tel_aluno = Convert.ToString(leitor["tel_aluno"]);
                        aluno.Cel_aluno = Convert.ToString(leitor["cel_aluno"]);
                        aluno.Email_aluno = Convert.ToString(leitor["email_aluno"]);
                        aluno.Foto_aluno = Convert.ToString(leitor["foto_aluno"]);
                        aluno.Nome_resp_um = Convert.ToString(leitor["nome_resp_um"]);
                        aluno.Tel_resp_um = Convert.ToString(leitor["tel_resp_um"]);
                        aluno.Cel_resp_um = Convert.ToString(leitor["cel_resp_um"]);
                        aluno.Email_resp_um = Convert.ToString(leitor["email_resp_um"]);
                        aluno.Rg_resp_um = Convert.ToString(leitor["rg_resp_um"]);
                        aluno.Cpf_resp_um = Convert.ToString(leitor["cpf_resp_um"]);
                        aluno.Hist_aluno = Convert.ToString(leitor["hist_aluno"]);

                        listaaluno.Add(aluno);
                    }
                }
                return listaaluno;
            }
        }
        public int AlterarCurso(DTO.AlunoDTO alunodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_aluno_generico 2,@id_aluno,@nome_aluno,@sexo,@data_nascimento_aluno,@logra_aluno," +
                    "@bairro_aluno,@cidade_aluno,@comp_logra_aluno,@numero_casa_aluno,@uf_aluno,@rg_aluno,@cpf_aluno,@tel_aluno,@cel_aluno," +
                     "@email_aluno,@foto_aluno,@nome_resp_um,@tel_resp_um,@cel_resp_um,@email_resp_um,@rg_resp_um,@cpf_resp_um,@hist_aluno";

                cm.Parameters.Add("id_aluno", SqlDbType.Int).Value = alunodto.Id_aluno;
                cm.Parameters.Add("nome_aluno", SqlDbType.VarChar).Value = alunodto.Nome_aluno;
                cm.Parameters.Add("sexo", SqlDbType.VarChar).Value = alunodto.Sexo_aluno;
                cm.Parameters.Add("data_nascimento_aluno", SqlDbType.VarChar).Value = alunodto.Data_nascimento_aluno;
                cm.Parameters.Add("logra_aluno", SqlDbType.VarChar).Value = alunodto.Logra_aluno;
                cm.Parameters.Add("bairro_aluno", SqlDbType.VarChar).Value = alunodto.Bairro_aluno;
                cm.Parameters.Add("cidade_aluno", SqlDbType.VarChar).Value = alunodto.Cidade_aluno;
                cm.Parameters.Add("comp_logra_aluno", SqlDbType.VarChar).Value = alunodto.Comp_logra_aluno;
                cm.Parameters.Add("numero_casa_aluno", SqlDbType.VarChar).Value = alunodto.Numero_casa_aluno;
                cm.Parameters.Add("uf_aluno", SqlDbType.VarChar).Value = alunodto.Uf_aluno;
                cm.Parameters.Add("rg_aluno", SqlDbType.VarChar).Value = alunodto.Rg_aluno;
                cm.Parameters.Add("cpf_aluno", SqlDbType.VarChar).Value = alunodto.Cpf_aluno;
                cm.Parameters.Add("tel_aluno", SqlDbType.VarChar).Value = alunodto.Tel_aluno;
                cm.Parameters.Add("cel_aluno", SqlDbType.VarChar).Value = alunodto.Cel_aluno;
                cm.Parameters.Add("email_aluno", SqlDbType.VarChar).Value = alunodto.Email_aluno;
                cm.Parameters.Add("foto_aluno", SqlDbType.VarChar).Value = alunodto.Foto_aluno;
                cm.Parameters.Add("nome_resp_um", SqlDbType.VarChar).Value = alunodto.Nome_resp_um;
                cm.Parameters.Add("tel_resp_um", SqlDbType.VarChar).Value = alunodto.Tel_resp_um;
                cm.Parameters.Add("cel_resp_um", SqlDbType.VarChar).Value = alunodto.Cel_resp_um;
                cm.Parameters.Add("email_resp_um", SqlDbType.VarChar).Value = alunodto.Email_resp_um;
                cm.Parameters.Add("rg_resp_um", SqlDbType.VarChar).Value = alunodto.Rg_resp_um;
                cm.Parameters.Add("cpf_resp_um", SqlDbType.VarChar).Value = alunodto.Cpf_resp_um;
                cm.Parameters.Add("hist_aluno", SqlDbType.VarChar).Value = alunodto.Hist_aluno;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int ExcluirAluno(DTO.AlunoDTO alunodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_aluno_generico 3,@id_aluno,null,null,null,null,null,null,null" +
                        "null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null ";
                cm.Connection = con;

                cm.Parameters.Add("@id_aluno", SqlDbType.Int).Value = alunodto.Id_aluno;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.AlunoDTO> BuscarAlunoNome(DTO.AlunoDTO alunodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_aluno where nome_aluno like @Nome_Aluno + '%'";

                cm.Connection = con;

                cm.Parameters.Add("nome_aluno", SqlDbType.VarChar).Value = alunodto.Nome_aluno;

                SqlDataReader leitor;

                IList<DTO.AlunoDTO> listaaluno = new List<DTO.AlunoDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.AlunoDTO aluno = new DTO.AlunoDTO();

                        aluno.Id_aluno = Convert.ToInt32(leitor["id_aluno"]);
                        aluno.Nome_aluno = Convert.ToString(leitor["nome_aluno"]);
                        aluno.Sexo_aluno = Convert.ToString(leitor["sexo_aluno"]);
                        aluno.Data_nascimento_aluno = Convert.ToString(leitor["data_nascimento_aluno"]);
                        aluno.Logra_aluno = Convert.ToString(leitor["logra_aluno"]);
                        aluno.Bairro_aluno = Convert.ToString(leitor["bairro_aluno"]);
                        aluno.Cidade_aluno = Convert.ToString(leitor["cidade_aluno"]);
                        aluno.Comp_logra_aluno = Convert.ToString(leitor["comp_logra_aluno"]);
                        aluno.Numero_casa_aluno = Convert.ToString(leitor["numero_casa_aluno"]);
                        aluno.Uf_aluno = Convert.ToString(leitor["uf_aluno"]);
                        aluno.Rg_aluno = Convert.ToString(leitor["rg_aluno"]);
                        aluno.Cpf_aluno = Convert.ToString(leitor["cpf_aluno"]);
                        aluno.Tel_aluno = Convert.ToString(leitor["tel_aluno"]);
                        aluno.Cel_aluno = Convert.ToString(leitor["cel_aluno"]);
                        aluno.Email_aluno = Convert.ToString(leitor["email_aluno"]);
                        aluno.Foto_aluno = Convert.ToString(leitor["foto_aluno"]);
                        aluno.Nome_resp_um = Convert.ToString(leitor["nome_resp_um"]);
                        aluno.Tel_resp_um = Convert.ToString(leitor["tel_resp_um"]);
                        aluno.Cel_resp_um = Convert.ToString(leitor["cel_resp_um"]);
                        aluno.Email_resp_um = Convert.ToString(leitor["email_resp_um"]);
                        aluno.Rg_resp_um = Convert.ToString(leitor["rg_resp_um"]);
                        aluno.Cpf_resp_um = Convert.ToString(leitor["cpf_resp_um"]);
                        aluno.Hist_aluno = Convert.ToString(leitor["hist_aluno"]);

                        listaaluno.Add(aluno);
                    }
                }
                return listaaluno;
            }
         }
        public IList<DTO.AlunoDTO> BuscarAlunoRG(DTO.AlunoDTO alunodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_aluno where rg_aluno like @Rg_aluno + '%'";

                cm.Connection = con;

                cm.Parameters.Add("rg_aluno", SqlDbType.VarChar).Value = alunodto.Rg_aluno;

                SqlDataReader leitor;

                IList<DTO.AlunoDTO> listaaluno = new List<DTO.AlunoDTO>();

                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.AlunoDTO aluno = new DTO.AlunoDTO();

                        aluno.Id_aluno = Convert.ToInt32(leitor["id_aluno"]);
                        aluno.Nome_aluno = Convert.ToString(leitor["nome_aluno"]);
                        aluno.Sexo_aluno = Convert.ToString(leitor["sexo_aluno"]);
                        aluno.Data_nascimento_aluno = Convert.ToString(leitor["data_nascimento_aluno"]);
                        aluno.Logra_aluno = Convert.ToString(leitor["logra_aluno"]);
                        aluno.Bairro_aluno = Convert.ToString(leitor["bairro_aluno"]);
                        aluno.Cidade_aluno = Convert.ToString(leitor["cidade_aluno"]);
                        aluno.Comp_logra_aluno = Convert.ToString(leitor["comp_logra_aluno"]);
                        aluno.Numero_casa_aluno = Convert.ToString(leitor["numero_casa_aluno"]);
                        aluno.Uf_aluno = Convert.ToString(leitor["uf_aluno"]);
                        aluno.Rg_aluno = Convert.ToString(leitor["rg_aluno"]);
                        aluno.Cpf_aluno = Convert.ToString(leitor["cpf_aluno"]);
                        aluno.Tel_aluno = Convert.ToString(leitor["tel_aluno"]);
                        aluno.Cel_aluno = Convert.ToString(leitor["cel_aluno"]);
                        aluno.Email_aluno = Convert.ToString(leitor["email_aluno"]);
                        aluno.Foto_aluno = Convert.ToString(leitor["foto_aluno"]);
                        aluno.Nome_resp_um = Convert.ToString(leitor["nome_resp_um"]);
                        aluno.Tel_resp_um = Convert.ToString(leitor["tel_resp_um"]);
                        aluno.Cel_resp_um = Convert.ToString(leitor["cel_resp_um"]);
                        aluno.Email_resp_um = Convert.ToString(leitor["email_resp_um"]);
                        aluno.Rg_resp_um = Convert.ToString(leitor["rg_resp_um"]);
                        aluno.Cpf_resp_um = Convert.ToString(leitor["cpf_resp_um"]);
                        aluno.Hist_aluno = Convert.ToString(leitor["hist_aluno"]);

                        listaaluno.Add(aluno);
                    }
                }
                return listaaluno;
            }
        }
     }
}


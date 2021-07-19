using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGerenciadorEscolar.Camadas.DAO
{
    class FuncionarioDAO
    {
        public int IncluirFuncionario(DTO.FuncionarioDTO funcionariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();

                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_funcionario_generico 1,null,@nome_func,@sexo_func,@data_nascimento_func,@logra_func,@bairro_func,@cidade_func," +
                                "@uf_func,@comp_logra_func,@numero_casa_func,@rg_func,@cpf_func,@tel_func,@cel_func,@email_func,@foto_func,@curriculum_func,@admissao_func";

                cm.Parameters.Add("@nome_func", SqlDbType.VarChar).Value = funcionariodto.Nome_func;
                cm.Parameters.Add("@sexo_func", SqlDbType.VarChar).Value = funcionariodto.Sexo_func;
                cm.Parameters.Add("@data_nascimento_func", SqlDbType.VarChar).Value = funcionariodto.Data_nascimento_func;
                cm.Parameters.Add("@logra_func", SqlDbType.VarChar).Value = funcionariodto.Logra_func;
                cm.Parameters.Add("@bairro_func", SqlDbType.VarChar).Value = funcionariodto.Bairro_func;
                cm.Parameters.Add("@cidade_func", SqlDbType.VarChar).Value = funcionariodto.Cidade_func;
                cm.Parameters.Add("@uf_func", SqlDbType.VarChar).Value = funcionariodto.Uf_func;
                cm.Parameters.Add("@comp_logra_func", SqlDbType.VarChar).Value = funcionariodto.Comp_logra_func;
                cm.Parameters.Add("@numero_casa_func", SqlDbType.VarChar).Value = funcionariodto.Numero_casa_func;
                cm.Parameters.Add("@rg_func", SqlDbType.VarChar).Value = funcionariodto.Rg_func;
                cm.Parameters.Add("@cpf_func", SqlDbType.VarChar).Value = funcionariodto.Cpf_func;
                cm.Parameters.Add("@tel_func", SqlDbType.VarChar).Value = funcionariodto.Tel_func;
                cm.Parameters.Add("@cel_func", SqlDbType.VarChar).Value = funcionariodto.Cel_func;
                cm.Parameters.Add("@email_func", SqlDbType.VarChar).Value = funcionariodto.Email_func;
                cm.Parameters.Add("@foto_func", SqlDbType.VarChar).Value = funcionariodto.Foto_func;
                cm.Parameters.Add("@curriculum_func", SqlDbType.VarChar).Value = funcionariodto.Curriculum_func;
                cm.Parameters.Add("@admissao_func", SqlDbType.VarChar).Value = funcionariodto.Data_admissao_func;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.FuncionarioDTO> ConsultarFuncionario()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_funcionario";
                cm.Connection = con;

                SqlDataReader leitor;

                IList<DTO.FuncionarioDTO> listafuncionarioDTO = new List<DTO.FuncionarioDTO>();
                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.FuncionarioDTO func = new DTO.FuncionarioDTO();

                        func.Id_func = Convert.ToInt32(leitor["id_func"]);
                        func.Nome_func = Convert.ToString(leitor["nome_func"]);
                        func.Sexo_func = Convert.ToString(leitor["sexo_func"]);
                        func.Data_nascimento_func = Convert.ToString(leitor["data_nascimento_func"]);
                        func.Logra_func = Convert.ToString(leitor["logra_func"]);
                        func.Bairro_func = Convert.ToString(leitor["bairro_func"]);
                        func.Cidade_func = Convert.ToString(leitor["cidade_func"]);                        
                        func.Uf_func = Convert.ToString(leitor["uf_func"]);
                        func.Comp_logra_func = Convert.ToString(leitor["comp_logra_func"]);
                        func.Numero_casa_func = Convert.ToString(leitor["numero_casa_func"]);
                        func.Rg_func = Convert.ToString(leitor["rg_func"]);
                        func.Cpf_func = Convert.ToString(leitor["cpf_func"]);
                        func.Tel_func = Convert.ToString(leitor["tel_func"]);
                        func.Cel_func = Convert.ToString(leitor["cel_func"]);
                        func.Email_func = Convert.ToString(leitor["email_func"]);
                        func.Foto_func = Convert.ToString(leitor["foto_func"]);
                        func.Curriculum_func = Convert.ToString(leitor["curriculum_func"]);
                        func.Data_admissao_func = Convert.ToString(leitor["data_admissao_func"]);

                        listafuncionarioDTO.Add(func);
                    }
                }
                return listafuncionarioDTO;
            }
        }
        public int AlterarFuncionario(DTO.FuncionarioDTO funcdto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();

                con.Open();

                cm.CommandText = "exec sp_funcionario_generico 2,@id_func,@nome_func,@sexo_func,@data_nascimento_func,@logra_func,@bairro_func,@cidade_func," +
                                 "@uf_func,@comp_logra_func,@numero_casa_func,@rg_func,@cpf_func,@tel_func,@cel_func,@email_func,@foto_func,@curriculum_func,@admissao_func";

                cm.Parameters.Add("id_func", SqlDbType.Int).Value = funcdto.Id_func;
                cm.Parameters.Add("nome_func", SqlDbType.VarChar).Value = funcdto.Nome_func;
                cm.Parameters.Add("sexo_func", SqlDbType.VarChar).Value = funcdto.Sexo_func;
                cm.Parameters.Add("data_nascimento_func", SqlDbType.VarChar).Value = funcdto.Data_nascimento_func;
                cm.Parameters.Add("logra_func", SqlDbType.VarChar).Value = funcdto.Logra_func;
                cm.Parameters.Add("bairro_func", SqlDbType.VarChar).Value = funcdto.Bairro_func;
                cm.Parameters.Add("cidade_func", SqlDbType.VarChar).Value = funcdto.Cidade_func;
                cm.Parameters.Add("uf_func", SqlDbType.VarChar).Value = funcdto.Uf_func;
                cm.Parameters.Add("comp_logra_func", SqlDbType.VarChar).Value = funcdto.Comp_logra_func;
                cm.Parameters.Add("numero_casa_func", SqlDbType.VarChar).Value = funcdto.Numero_casa_func;
                cm.Parameters.Add("rg_func", SqlDbType.VarChar).Value = funcdto.Rg_func;
                cm.Parameters.Add("cpf_func", SqlDbType.VarChar).Value = funcdto.Cpf_func;
                cm.Parameters.Add("tel_func", SqlDbType.VarChar).Value = funcdto.Tel_func;
                cm.Parameters.Add("cel_func", SqlDbType.VarChar).Value = funcdto.Cel_func;
                cm.Parameters.Add("email_func", SqlDbType.VarChar).Value = funcdto.Email_func;
                cm.Parameters.Add("foto_func", SqlDbType.VarChar).Value = funcdto.Foto_func;
                cm.Parameters.Add("curriculum_func", SqlDbType.VarChar).Value = funcdto.Curriculum_func;
                cm.Parameters.Add("admissao_func", SqlDbType.VarChar).Value = funcdto.Data_admissao_func;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int ExcluirFuncionario(DTO.FuncionarioDTO funcdto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandText = CommandType.StoredProcedure.ToString();
                con.Open();

                cm.CommandText = "exec sp_funcionario_generico 3,@id_func,null,null,null,null,null,null,null,null,null,null,null,null,null" +
                                 "null,null,null,null,null";

                cm.Parameters.Add("id_func", SqlDbType.Int).Value = funcdto.Id_func;

                cm.Connection = con;

                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DTO.FuncionarioDTO> BuscarFuncionarioNome(DTO.FuncionarioDTO funcionariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_funcionario where nome_func like @Nome_func + '%'";
                cm.Connection = con;
                cm.Parameters.Add("nome_func", SqlDbType.VarChar).Value = funcionariodto.Nome_func;

                SqlDataReader leitor;

                IList<DTO.FuncionarioDTO> listafuncionarioDTO = new List<DTO.FuncionarioDTO>();
                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.FuncionarioDTO func = new DTO.FuncionarioDTO();

                        func.Id_func = Convert.ToInt32(leitor["id_func"]);
                        func.Nome_func = Convert.ToString(leitor["nome_func"]);
                        func.Sexo_func = Convert.ToString(leitor["sexo_func"]);
                        func.Data_nascimento_func = Convert.ToString(leitor["data_nascimento_func"]);
                        func.Logra_func = Convert.ToString(leitor["logra_func"]);
                        func.Bairro_func = Convert.ToString(leitor["bairro_func"]);
                        func.Cidade_func = Convert.ToString(leitor["cidade_func"]);
                        func.Uf_func = Convert.ToString(leitor["uf_func"]);
                        func.Comp_logra_func = Convert.ToString(leitor["comp_logra_func"]);
                        func.Numero_casa_func = Convert.ToString(leitor["numero_casa_func"]);
                        func.Rg_func = Convert.ToString(leitor["rg_func"]);
                        func.Cpf_func = Convert.ToString(leitor["cpf_func"]);
                        func.Tel_func = Convert.ToString(leitor["tel_func"]);
                        func.Cel_func = Convert.ToString(leitor["cel_func"]);
                        func.Email_func = Convert.ToString(leitor["email_func"]);
                        func.Foto_func = Convert.ToString(leitor["foto_func"]);
                        func.Curriculum_func = Convert.ToString(leitor["curriculum_func"]);
                        func.Data_admissao_func = Convert.ToString(leitor["data_admissao_func"]);

                        listafuncionarioDTO.Add(func);
                    }
                }
                return listafuncionarioDTO;
            }
        }
        public IList<DTO.FuncionarioDTO> BuscarFuncionarioRG(DTO.FuncionarioDTO funcionariodto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.csTCC;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_funcionario where rg_func like @Rg_func + '%'";
                cm.Connection = con;
                cm.Parameters.Add("rg_func", SqlDbType.VarChar).Value = funcionariodto.Rg_func;

                SqlDataReader leitor;

                IList<DTO.FuncionarioDTO> listafuncionarioDTO = new List<DTO.FuncionarioDTO>();
                con.Open();

                leitor = cm.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        DTO.FuncionarioDTO func = new DTO.FuncionarioDTO();

                        func.Id_func = Convert.ToInt32(leitor["id_func"]);
                        func.Nome_func = Convert.ToString(leitor["nome_func"]);
                        func.Sexo_func = Convert.ToString(leitor["sexo_func"]);
                        func.Data_nascimento_func = Convert.ToString(leitor["data_nascimento_func"]);
                        func.Logra_func = Convert.ToString(leitor["logra_func"]);
                        func.Bairro_func = Convert.ToString(leitor["bairro_func"]);
                        func.Cidade_func = Convert.ToString(leitor["cidade_func"]);
                        func.Uf_func = Convert.ToString(leitor["uf_func"]);
                        func.Comp_logra_func = Convert.ToString(leitor["comp_logra_func"]);
                        func.Numero_casa_func = Convert.ToString(leitor["numero_casa_func"]);
                        func.Rg_func = Convert.ToString(leitor["rg_func"]);
                        func.Cpf_func = Convert.ToString(leitor["cpf_func"]);
                        func.Tel_func = Convert.ToString(leitor["tel_func"]);
                        func.Cel_func = Convert.ToString(leitor["cel_func"]);
                        func.Email_func = Convert.ToString(leitor["email_func"]);
                        func.Foto_func = Convert.ToString(leitor["foto_func"]);
                        func.Curriculum_func = Convert.ToString(leitor["curriculum_func"]);
                        func.Data_admissao_func = Convert.ToString(leitor["data_admissao_func"]);

                        listafuncionarioDTO.Add(func);
                    }
                }
                return listafuncionarioDTO;
            }
        }
    }
}

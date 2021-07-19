using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class FuncionarioDTO
    {
        private int id_func;
        private string nome_func;
        private string sexo_func;
        private string data_nascimento_func;
        private string logra_func;
        private string bairro_func;
        private string uf_func;
        private string cidade_func;
        private string comp_logra_func;
        private string numero_casa_func;
        private string rg_func;
        private string cpf_func;
        private string tel_func;
        private string cel_func;
        private string email_func;
        private string foto_func;
        private string curriculum_func;
        private string data_admissao_func;

        public int Id_func
        {
            get { return id_func; }
            set { id_func = value; }
        }       

        public string Nome_func
        {
            get { return nome_func; }
            set { nome_func = value; }
        }        

        public string Sexo_func
        {
            get { return sexo_func; }
            set { sexo_func = value; }
        }
        
        public string Data_nascimento_func
        {
            get { return data_nascimento_func; }
            set { data_nascimento_func = value; }
        }        

        public string Logra_func
        {
            get { return logra_func; }
            set { logra_func = value; }
        }
        
        public string Bairro_func
        {
            get { return bairro_func; }
            set { bairro_func = value; }
        }        

        public string Cidade_func
        {
            get { return cidade_func; }
            set { cidade_func = value; }
        }        

        public string Uf_func
        {
            get { return uf_func; }
            set { uf_func = value; }
        }        

        public string Comp_logra_func
        {
            get { return comp_logra_func; }
            set { comp_logra_func = value; }
        }
        
        public string Numero_casa_func
        {
            get { return numero_casa_func; }
            set { numero_casa_func = value; }
        }        

        public string Rg_func
        {
            get { return rg_func; }
            set { rg_func = value; }
        }
        
        public string Cpf_func
        {
            get { return cpf_func; }
            set { cpf_func = value; }
        }        

        public string Tel_func
        {
            get { return tel_func; }
            set { tel_func = value; }
        }        

        public string Cel_func
        {
            get { return cel_func; }
            set { cel_func = value; }
        }        

        public string Email_func
        {
            get { return email_func; }
            set { email_func = value; }
        }
        
        public string Foto_func
        {
            get { return foto_func; }
            set { foto_func = value; }
        }        

        public string Curriculum_func
        {
            get { return curriculum_func; }
            set { curriculum_func = value; }
        }        

        public string Data_admissao_func
        {
            get { return data_admissao_func; }
            set { data_admissao_func = value; }
        }
    }
}

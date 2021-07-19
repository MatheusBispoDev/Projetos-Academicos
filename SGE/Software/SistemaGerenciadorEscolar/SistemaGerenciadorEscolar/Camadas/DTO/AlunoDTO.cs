using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class AlunoDTO
    {
        private int id_aluno;
        private string nome_aluno;
        private string sexo_aluno;
        private string data_nascimento_aluno;
        private string logra_aluno;
        private string bairro_aluno;
        private string cidade_aluno;
        private string comp_logra_aluno;
        private string numero_casa_aluno;
        private string uf_aluno;
        private string rg_aluno;
        private string cpf_aluno;
        private string tel_aluno;
        private string cel_aluno;
        private string email_aluno;
        private string foto_aluno;        
        private string nome_resp_um;
        private string tel_resp_um;
        private string cel_resp_um;
        private string email_resp_um;
        private string rg_resp_um;
        private string cpf_resp_um;
        private string hist_aluno;

        public int Id_aluno
        {
            get { return id_aluno; }
            set { id_aluno = value; }
        }

        public string Nome_aluno
        {
            get { return nome_aluno; }
            set { nome_aluno = value; }
        }

        public string Sexo_aluno
        {
            get { return sexo_aluno; }
            set { sexo_aluno = value; }
        }

        public string Data_nascimento_aluno
        {
            get { return data_nascimento_aluno; }
            set { data_nascimento_aluno = value; }
        }

        public string Logra_aluno
        {
            get { return logra_aluno; }
            set { logra_aluno = value; }
        }

        public string Bairro_aluno
        {
            get { return bairro_aluno; }
            set { bairro_aluno = value; }
        }

        public string Cidade_aluno
        {
            get { return cidade_aluno; }
            set { cidade_aluno = value; }
        }

        public string Comp_logra_aluno
        {
            get { return comp_logra_aluno; }
            set { comp_logra_aluno = value; }
        }

        public string Numero_casa_aluno
        {
            get { return numero_casa_aluno; }
            set { numero_casa_aluno = value; }
        }

        public string Uf_aluno
        {
            get { return uf_aluno; }
            set { uf_aluno = value; }
        }

        public string Rg_aluno
        {
            get { return rg_aluno; }
            set { rg_aluno = value; }
        }

        public string Cpf_aluno
        {
            get { return cpf_aluno; }
            set { cpf_aluno = value; }
        }

        public string Tel_aluno
        {
            get { return tel_aluno; }
            set { tel_aluno = value; }
        }

        public string Cel_aluno
        {
            get { return cel_aluno; }
            set { cel_aluno = value; }
        }

        public string Email_aluno
        {
            get { return email_aluno; }
            set { email_aluno = value; }
        }
        public string Foto_aluno
        {
            get { return foto_aluno; }
            set { foto_aluno = value; }
        }

        public string Nome_resp_um
        {
            get { return nome_resp_um; }
            set { nome_resp_um = value; }
        }

        public string Tel_resp_um
        {
            get { return tel_resp_um; }
            set { tel_resp_um = value; }
        }

        public string Cel_resp_um
        {
            get { return cel_resp_um; }
            set { cel_resp_um = value; }
        }

        public string Email_resp_um
        {
            get { return email_resp_um; }
            set { email_resp_um = value; }
        }

        public string Rg_resp_um
        {
            get { return rg_resp_um; }
            set { rg_resp_um = value; }
        }

        public string Cpf_resp_um
        {
            get { return cpf_resp_um; }
            set { cpf_resp_um = value; }
        }

        public string Hist_aluno
        {
            get { return hist_aluno; }
            set { hist_aluno = value; }
        }
    }
}

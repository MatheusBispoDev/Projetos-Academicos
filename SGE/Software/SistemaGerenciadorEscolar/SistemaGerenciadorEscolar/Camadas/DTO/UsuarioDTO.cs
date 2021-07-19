using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class UsuarioDTO
    {
        private int id_usu;
        private string login;
        private string senha;
        private int tipo_usu;
        private string tipo_usuario;     

        public int Id_usu
        {
            get { return id_usu; }
            set { id_usu = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public int Tipo_usu
        {
            get { return tipo_usu; }
            set { tipo_usu = value; }
        }
        public string Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }    
    }
}

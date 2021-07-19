using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class UsuarioModel
    {
        DAO.UsuarioDAO usuarioDao = new DAO.UsuarioDAO();

        public int IncluirUsuario(DTO.UsuarioDTO usuariodto)
        {
            return usuarioDao.IncluirUsuario(usuariodto);
        }

        public IList<DTO.UsuarioDTO> ConsultaUsuario()
        {
            return new DAO.UsuarioDAO().ConsultaUsuario();
        }
        public int AlterarUsuario(DTO.UsuarioDTO usuariodto)
        {
            return usuarioDao.AlterarUsuario(usuariodto);
        }
        internal int ExcluirUsuario(DTO.UsuarioDTO usuariodto)
        {
            return usuarioDao.ExcluirUsuario(usuariodto);
        }
        public DTO.UsuarioDTO AutenticarUsuario(DTO.UsuarioDTO usuariodto)
        {
            return usuarioDao.AutenticarUsuario(usuariodto);
        }      
        
    }
}

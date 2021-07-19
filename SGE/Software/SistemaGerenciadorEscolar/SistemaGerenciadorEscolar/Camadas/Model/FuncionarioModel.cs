using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class FuncionarioModel
    {
        DAO.FuncionarioDAO funcionarioDao = new DAO.FuncionarioDAO();

        public int IncluirFuncionario(DTO.FuncionarioDTO funcdto)
        {
            return funcionarioDao.IncluirFuncionario(funcdto);
        }
        public IList<DTO.FuncionarioDTO> ConsultaFuncionario()
        {
            return new DAO.FuncionarioDAO().ConsultarFuncionario();
        }
        public int AlterarFuncionario(DTO.FuncionarioDTO funcdto)
        {
            return funcionarioDao.AlterarFuncionario(funcdto);
        }
        public int ExcluirFuncionario(DTO.FuncionarioDTO funcdto)
        {
            return funcionarioDao.ExcluirFuncionario(funcdto);
        }
        public IList<DTO.FuncionarioDTO> BuscarFuncionarioNome(DTO.FuncionarioDTO funcdto)
        {
            return funcionarioDao.BuscarFuncionarioNome(funcdto);
        }
        public IList<DTO.FuncionarioDTO> BuscarFuncionarioRG(DTO.FuncionarioDTO funcdto)
        {
            return funcionarioDao.BuscarFuncionarioRG(funcdto);
        }
    }
}

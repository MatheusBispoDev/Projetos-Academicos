using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class ProfessorModel
    {
        DAO.ProfessorDAO profDao = new DAO.ProfessorDAO();

        public int IncluirProfessor(DTO.ProfessorDTO profdto)
        {
            return profDao.IncluirProfessor(profdto);
        }
        public IList<DTO.ProfessorDTO> ConsultarProfessor()
        {
            return new DAO.ProfessorDAO().ConsultaProfessor();
        }
        public int AlterarProfessor(DTO.ProfessorDTO profdto)
        {
            return profDao.AlterarProfessor(profdto);
        }
        public int ExcluirProfessor(DTO.ProfessorDTO profdto)
        {
            return profDao.ExcluirProfessor(profdto);
        }
        public IList<DTO.ProfessorDTO> BuscarProfNome(DTO.ProfessorDTO profdto)
        {
            return profDao.BuscarProfNome(profdto);
        }
        public IList<DTO.ProfessorDTO> BuscarProfRG(DTO.ProfessorDTO profdto)
        {
            return profDao.BuscarProfRG(profdto);
        }
    }
}

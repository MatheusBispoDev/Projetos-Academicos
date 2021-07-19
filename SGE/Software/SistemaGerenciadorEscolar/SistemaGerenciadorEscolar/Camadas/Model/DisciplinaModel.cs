using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class DisciplinaModel
    {
        DAO.DisciplinaDAO disciplinaDao = new DAO.DisciplinaDAO();

        public int IncluirDisciplina(DTO.DisciplinaDTO disciplinadto)
        {
            return disciplinaDao.IncluirDisciplina(disciplinadto);
        }

        public IList<DTO.DisciplinaDTO> ConsultaDisciplina()
        {
            return new DAO.DisciplinaDAO().ConsultaDisciplina();
        }
        public int AlterarDisciplina(DTO.DisciplinaDTO disciplinadto)
        {
            return disciplinaDao.AlterarDisciplina(disciplinadto);
        }
        internal int ExcluirDisciplina(DTO.DisciplinaDTO disciplinadto)
        {
            return disciplinaDao.ExcluirDisciplina(disciplinadto);
        }

        public IList<DTO.DisciplinaDTO> BuscarDisciplina(DTO.DisciplinaDTO disciplinadto)
        {
            return disciplinaDao.BuscarDisciplina(disciplinadto);
        }
    }
}

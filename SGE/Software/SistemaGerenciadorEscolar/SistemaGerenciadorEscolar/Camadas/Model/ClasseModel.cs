using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class ClasseModel
    {
        DAO.ClasseDao classeDao = new DAO.ClasseDao();

        public int IncluirClasse(DTO.ClasseDTO classedto)
        {
            return classeDao.IncluirClasse(classedto);
        }
        public IList<DTO.ClasseDTO> ConsultarClasse()
        {
            return new DAO.ClasseDao().ConsultaClasse();
        }
        public int AlterarClasse(DTO.ClasseDTO classedto)
        {
            return classeDao.AlterarClasse(classedto);
        }
        public int ExcluirClasse(DTO.ClasseDTO classedto)
        {
            return classeDao.ExcluirClasse(classedto);
        }
        public IList<DTO.ClasseDTO> BuscarClasse(DTO.ClasseDTO classedto)
        {
            return classeDao.BuscarClasse(classedto);
        }
    }
}

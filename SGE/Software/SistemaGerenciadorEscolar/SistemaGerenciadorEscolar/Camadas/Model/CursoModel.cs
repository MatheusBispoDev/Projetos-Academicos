using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class CursoModel
    {
        DAO.CursoDAO cursoDao = new DAO.CursoDAO();

        public int IncluirCurso(DTO.CursoDTO cursodto)
        {
            return cursoDao.IncluirCurso(cursodto);
        }
        public IList<DTO.CursoDTO> ConsultarCurso()
        {
            return new DAO.CursoDAO().ConsultarCurso();
        }
        public int AlterarCurso(DTO.CursoDTO cursodto)
        {
            return cursoDao.AlterarCurso(cursodto);
        }
        public int ExcluirCurso(DTO.CursoDTO cursodto)
        {
            return cursoDao.ExcluirCurso(cursodto);
        }
        public IList<DTO.CursoDTO> BuscarCurso(DTO.CursoDTO cursodto)
        {
            return cursoDao.BuscarCurso(cursodto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class Disc_CursoModel
    {
        DAO.Disc_CursoDAO disc_cursoDao = new DAO.Disc_CursoDAO();

        public int IncluirDisc_Curso(DTO.Disc_CursoDTO disc_cursodto)
        {
            return disc_cursoDao.IncluirDisc_Curso(disc_cursodto);
        }
        public IList<DTO.Disc_CursoDTO> ConsultarDisc_Curso()
        {
            return new DAO.Disc_CursoDAO().ConsultaDisc_Curso();
        }
        public int AlterarDisc_Curso(DTO.Disc_CursoDTO disc_cursodto)
        {
            return disc_cursoDao.AlterarDisc_Curso(disc_cursodto);
        }
        public int ExcluirDisc_Curso(DTO.Disc_CursoDTO disc_cursodto)
        {
            return disc_cursoDao.ExcluirDisc_Curso(disc_cursodto);
        }
    }
}

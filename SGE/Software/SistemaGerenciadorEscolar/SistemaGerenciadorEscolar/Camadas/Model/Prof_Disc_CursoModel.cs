using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class Prof_Disc_CursoModel
    {
        DAO.Prof_Disc_CursoDAO prof_disc_cursoDao = new DAO.Prof_Disc_CursoDAO();

        public int IncluirProf_Disc_Curso(DTO.Prof_Disc_CursoDTO prof_disc_cursodto)
        {
            return prof_disc_cursoDao.IncluirProf_Disc_Curso(prof_disc_cursodto);
        }
        public IList<DTO.Prof_Disc_CursoDTO> ConsultarProf_Disc_Curso()
        {
            return new DAO.Prof_Disc_CursoDAO().ConsultarProf_Disc_Curso();
        }
        public int AlterarProf_Disc_Curso(DTO.Prof_Disc_CursoDTO prof_disc_cursodto)
        {
            return prof_disc_cursoDao.AlterarProf_Disc_Curso(prof_disc_cursodto);
        }
        public int ExcluirProf_Disc_Curso(DTO.Prof_Disc_CursoDTO prof_disc_cursodto)
        {
            return prof_disc_cursoDao.ExcluirProf_Disc_Curso(prof_disc_cursodto);
        }
    }
}

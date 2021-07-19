using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class AlunoModel
    {
        DAO.AlunoDAO alunoDao = new DAO.AlunoDAO();

        public int IncluirAluno(DTO.AlunoDTO alunodto)
        {
            return alunoDao.IncluirAluno(alunodto);
        }
        public IList<DTO.AlunoDTO> ConsultarAluno()
        {
            return new DAO.AlunoDAO().ConsultarAluno();
        }
        public int AlterarAluno(DTO.AlunoDTO alunodto)
        {
            return alunoDao.AlterarCurso(alunodto);
        }
        public int ExcluirAluno(DTO.AlunoDTO alunodto)
        {
            return alunoDao.ExcluirAluno(alunodto);
        }
        public IList<DTO.AlunoDTO> BuscarAlunoNome(DTO.AlunoDTO alunodto)
        {
            return alunoDao.BuscarAlunoNome(alunodto);
        }
        public IList<DTO.AlunoDTO> BuscarAlunoRG(DTO.AlunoDTO alunodto)
        {
            return alunoDao.BuscarAlunoRG(alunodto);
        }
    }
}

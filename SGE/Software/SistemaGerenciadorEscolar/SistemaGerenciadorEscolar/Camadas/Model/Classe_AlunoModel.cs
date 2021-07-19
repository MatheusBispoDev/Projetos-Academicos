using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.Model
{
    class Classe_AlunoModel
    {
        DAO.Classe_AlunoDAO classe_alunoDao = new DAO.Classe_AlunoDAO();

        public int IncluirClasse_Aluno(DTO.Classe_AlunoDTO classe_alunodto)
        {
            return classe_alunoDao.IncluirClasse_Aluno(classe_alunodto);
        }
        public IList<DTO.Classe_AlunoDTO> ConsultarClasse_Aluno()
        {
            return new DAO.Classe_AlunoDAO().ConsultarClasse_Aluno();
        }
        public int AlterarClasse_Aluno(DTO.Classe_AlunoDTO classe_alunodto)
        {
            return classe_alunoDao.AlterarClasse_Aluno(classe_alunodto);
        }
        public int ExcluirClasse_Aluno(DTO.Classe_AlunoDTO classe_alunodto)
        {
            return classe_alunoDao.ExcluirClasse_Aluno(classe_alunodto);
        }
    }
}

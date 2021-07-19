using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class Classe_AlunoDTO
    {
        private int id_classe_aluno;
        private int id_classe;
        private int id_aluno;
        private string classe;
        private string aluno;

        public int Id_classe_aluno
        {
            get { return id_classe_aluno; }
            set { id_classe_aluno = value; }
        }
        public int Id_classe
        {
            get { return id_classe; }
            set { id_classe = value; }
        }
        public int Id_aluno
        {
            get { return id_aluno; }
            set { id_aluno = value; }
        }
        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        public string Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }
                
    }
}

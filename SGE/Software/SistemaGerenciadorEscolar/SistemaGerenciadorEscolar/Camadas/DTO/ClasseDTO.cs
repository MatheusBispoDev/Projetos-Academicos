using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class ClasseDTO
    {
        private int id_classe;
        private int id_curso;
        private string classe;
        private string curso;       

        public int Id_classe
        {
            get { return id_classe; }
            set { id_classe = value; }
        }       

        public int Id_curso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }        

        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
}

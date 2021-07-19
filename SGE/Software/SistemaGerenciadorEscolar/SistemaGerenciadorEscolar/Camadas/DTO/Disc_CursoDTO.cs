using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class Disc_CursoDTO
    {
        private int id_disc_curso;
        private int id_disc;
        private int id_curso;
        private string disciplina;
        private string curso;

        public int Id_disc_curso
        {
            get { return id_disc_curso; }
            set { id_disc_curso = value; }
        }
        
        public int Id_disc
        {
            get { return id_disc; }
            set { id_disc = value; }
        }

        public int Id_curso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }
        public string Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
}

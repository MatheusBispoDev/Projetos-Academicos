using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class Prof_Disc_CursoDTO
    {
        private int id_prof_curso;
        private int id_prof;
        private int id_disc_curso;
        private string professor;
        private string disciplina;
        private string curso;
        
        public int Id_prof_curso
        {
            get { return id_prof_curso; }
            set { id_prof_curso = value; }
        }
        
        public int Id_prof
        {
            get { return id_prof; }
            set { id_prof = value; }
        }
        public int Id_disc_curso
        {
            get { return id_disc_curso; }
            set { id_disc_curso = value; }
        }
        public string Professor
        {
            get { return professor; }
            set { professor = value; }
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

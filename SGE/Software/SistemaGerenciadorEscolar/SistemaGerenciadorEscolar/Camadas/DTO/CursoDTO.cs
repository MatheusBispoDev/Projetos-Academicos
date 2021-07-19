using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class CursoDTO
    {
        private int id_curso;
        private string curso;
        private string modulo_curso;
        private string periodo_curso;

        public int Id_curso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public string Modulo_Curso
        {
            get { return modulo_curso; }
            set { modulo_curso = value; }
        }

        public string Periodo_curso
        {
            get { return periodo_curso; }
            set { periodo_curso = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorEscolar.Camadas.DTO
{
    class DisciplinaDTO
    {
        private int id_disc;
        private string disciplina;
        private string carga_horario;

        public int Id_disc
        {
            get { return id_disc; }
            set { id_disc = value; }
        }

        public string Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        public string Carga_horario
        {
            get { return carga_horario; }
            set { carga_horario = value; }
        }
    }
}

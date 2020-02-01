using System;
using System.Collections.Generic;

namespace Suple_Repaso.Models
{
    public partial class Materia
    {
        public Materia()
        {
            Estudiante = new HashSet<Estudiante>();
            Nota = new HashSet<Nota>();
        }

        public int IdMateria { get; set; }
        public string NombreMateria { get; set; }

        public virtual ICollection<Estudiante> Estudiante { get; set; }
        public virtual ICollection<Nota> Nota { get; set; }
    }
}

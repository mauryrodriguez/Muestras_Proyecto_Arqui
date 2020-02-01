using System;
using System.Collections.Generic;

namespace Suple_Repaso.Models
{
    public partial class Nota
    {
        public int IdNota { get; set; }
        public int? IdEstudiante { get; set; }
        public int? IdMateria { get; set; }
        public double Nota1 { get; set; }

        public virtual Estudiante IdEstudianteNavigation { get; set; }
        public virtual Materia IdMateriaNavigation { get; set; }
    }
}

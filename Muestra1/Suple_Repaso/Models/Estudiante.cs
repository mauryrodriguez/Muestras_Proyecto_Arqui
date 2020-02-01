using System;
using System.Collections.Generic;

namespace Suple_Repaso.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Nota = new HashSet<Nota>();
        }

        public int IdEstudiante { get; set; }
        public int? IdMateria { get; set; }
        public int? IdProfesor { get; set; }
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }
        public string MailEstudiante { get; set; }
        public DateTime FechaNacEstudiante { get; set; }
        public decimal CiEstudiante { get; set; }

        public virtual Materia IdMateriaNavigation { get; set; }
        public virtual Profesor IdProfesorNavigation { get; set; }
        public virtual ICollection<Nota> Nota { get; set; }
    }
}

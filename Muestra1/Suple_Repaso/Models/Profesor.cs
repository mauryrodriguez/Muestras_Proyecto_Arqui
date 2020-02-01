using System;
using System.Collections.Generic;

namespace Suple_Repaso.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            Estudiante = new HashSet<Estudiante>();
        }

        public int IdProfesor { get; set; }
        public string NombreProfesor { get; set; }
        public string ApellidoProfesor { get; set; }
        public decimal CiProfesor { get; set; }
        public string MailProfesor { get; set; }
        public string TipoProfesor { get; set; }

        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}

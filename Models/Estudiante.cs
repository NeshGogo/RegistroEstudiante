using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroEstudiante.Models
{
    public partial class Estudiante
    {
        
        public int EstudianteId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public bool Estatus { get; set; }
        [Required]
        public string Carrera { get; set; }
    }
}

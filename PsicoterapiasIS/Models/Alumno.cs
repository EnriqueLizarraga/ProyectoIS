using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsicoterapiasIS.Models
{
    public class Alumno: Usuario
    {
        public int id { get; set; }
        [Required]
        public int Matricula { get; set; }
        [Required]
        public int Semestre { get; set; }
        [Required]
        public int Horas { get; set; }
    }
}
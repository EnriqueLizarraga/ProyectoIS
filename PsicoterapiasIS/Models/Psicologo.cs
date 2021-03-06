﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsicoterapiasIS.Models
{
    public class Psicologo: Usuario
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string Cedula { get; set; }
        [Required]
        [StringLength(30)]
        public string Horario { get; set; }
        [Required]
        public int Calificacion { get; set; }
        [Required]
        public float Precio { get; set; }

    }
}
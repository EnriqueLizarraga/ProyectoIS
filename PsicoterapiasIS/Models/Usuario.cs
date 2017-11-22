using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PsicoterapiasIS.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNac { get; set; }


    }
}
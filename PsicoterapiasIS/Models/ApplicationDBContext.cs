using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PsicoterapiasIS.Models
{
    public class ApplicationDBContext: DbContext 
    {
        public DbSet<Usuario> Usuario { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solucion1.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }
        public System.Data.Entity.Dbset<Solucion1.Models.Proyect> Proyects { get; set; }
    }
}
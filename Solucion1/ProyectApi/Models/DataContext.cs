using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectApi.Models
{
     using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }
        public System.Data.Entity.Dbset<ProyectApi.Models.Proyect> Proyects { get; set; }
    }
}
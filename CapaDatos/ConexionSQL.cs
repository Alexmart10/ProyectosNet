using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionSQL : DbContext
    {

        public ConexionSQL(DbContextOptions<ConexionSQL> options)  : base(options)
        {
        }

    }
}

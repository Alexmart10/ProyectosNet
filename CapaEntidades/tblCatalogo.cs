using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class tblCatalogo
    {

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public int Edad { get; set; }
        public string? Color { get; set; }
        public string? Raza { get; set; }
        public string? Fierro { get; set; }
        public int Arete { get; set; }
        public int IdMadre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Peso { get; set; }
        public string? Clasificacion { get; set; }
        public string? LugarNacimiento { get; set; }
        public string? FierroCompra { get; set; }
        public SqlBinary Foto { get; set; }

        public bool Activo { get; set; }

    }
}

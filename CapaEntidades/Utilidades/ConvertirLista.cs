using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Utilidades
{
    public class ConvertirLista
    {


        public List<tblCatalogo> ListaRetorno(DataSet ds)

        {

           
            List<tblCatalogo> res = new List<tblCatalogo>();

            try
            {
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        tblCatalogo Lista = new tblCatalogo();
                    
                        Lista.Id = Convert.ToInt32(dr["Id"]);
                        Lista.Nombre = (dr["Nombre"].ToString());
                        Lista.Edad = Int32.Parse(dr["Edad"].ToString());
                        Lista.Color = (dr["Color"].ToString());
                        Lista.Fierro = (dr["Fierro"].ToString());
                        Lista.Arete = Int32.Parse(dr["Arete"].ToString());
                        Lista.IdMadre = Int32.Parse(dr["IdMadre"].ToString());
                        Lista.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"].ToString());
                        Lista.FechaCompra = Convert.ToDateTime(dr["FechaCompra"].ToString());
                        Lista.Peso = Int32.Parse(dr["Peso"].ToString());
                        Lista.Clasificacion = (dr["Sexo"].ToString());
                        Lista.LugarNacimiento = (dr["LugarNacimiento"].ToString());
                        Lista.FierroCompra = (dr["FierroCompra"].ToString());

                        res.Add(Lista);

                    }
                }
               
            }

            catch(Exception ex)
            {
                
            }

            return res;
        }
    }
}

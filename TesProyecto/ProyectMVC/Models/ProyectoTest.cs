using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ProyectMVC.Models;

namespace ProyectMVC.Models
{
    public class ProyectoTest
    {
        private SqlConnection con;
      
        public List<VentasProducto> RecuperarTodos()
        {
            DataTable Table = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(constr);
            List<VentasProducto> articulos = new List<VentasProducto>();
            SqlCommand cmdActualizaEstatus = new SqlCommand();
            try
            {
                cmdActualizaEstatus.CommandType = CommandType.StoredProcedure;
                cmdActualizaEstatus.CommandText = "Ventas_SP";
                cmdActualizaEstatus.Connection = con;

                con.Open();
                Table.Load(cmdActualizaEstatus.ExecuteReader());
                articulos = (from DataRow dr in Table.Rows
                               select new VentasProducto()
                               {
                                   Codigo = (dr["Codigo_producto"].ToString()),
                                   Descripcion = dr["Descripcion"].ToString(),
                                   CantidadVenta = Convert.ToInt32(dr["cantidad_vta"]),
                                   Total = Convert.ToDecimal(dr["Total"])
                               }).ToList();

                con.Close(); 
            }
            catch
            {

            }
            return articulos;
        }
    }
}
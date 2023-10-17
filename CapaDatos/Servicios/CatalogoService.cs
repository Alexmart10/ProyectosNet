using CapaDatos.Utilidades;
using CapaEntidades;
using CapaLogica.ManejadorResult;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppAdmMvc.Servicios.Contrato;


namespace CapaDatos.Servicios
{
    public class CatalogoService : ICatalogo
    {

        private readonly ConexionSQL _dbContext;
        private readonly string _connectionString;

        public CatalogoService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CadenaSQL");
        }

        public async Task<List<tblCatalogo>> GetCatalogoLista()
        {
            var result = new List<tblCatalogo>();
            //tblCatalogo _ListaResult;
            ConvertirLista Ls = new ConvertirLista();
            DataSet ds = new DataSet();
            List<tblCatalogo> res = new List<tblCatalogo>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new Microsoft.Data.SqlClient.SqlCommand("spConsultaCatalogo", connection))
                {
                    SqlCommand sqlComm = new SqlCommand("spConsultaCatalogo", connection);
                    //sqlComm.Parameters.AddWithValue("@Start", StartTime);
                    //sqlComm.Parameters.AddWithValue("@Finish", FinishTime);
                    //sqlComm.Parameters.AddWithValue("@TimeRange", TimeRange);

                    sqlComm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    await Task.Run(() => da.Fill(ds));
                    //da.Fill(ds);
                    //return await sqlCommand.ExecuteNonQueryAsync();
                    result =   Ls.ListaRetorno(ds);
                }
            }

            return result;
        }




        //public DataSet GetCatalogoTodo()
        //{
        //    ManejadorResult _ManejadorDatos = new ManejadorResult();

        //    DataSet ds = new DataSet();

        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        using (var command = new Microsoft.Data.SqlClient.SqlCommand("spConsultaCatalogo", connection))
        //        {
        //            SqlCommand sqlComm = new SqlCommand("spConsultaCatalogo", connection);
        //            //sqlComm.Parameters.AddWithValue("@Start", StartTime);
        //            //sqlComm.Parameters.AddWithValue("@Finish", FinishTime);
        //            //sqlComm.Parameters.AddWithValue("@TimeRange", TimeRange);

        //            sqlComm.CommandType = CommandType.StoredProcedure;

        //            SqlDataAdapter da = new SqlDataAdapter();
        //            da.SelectCommand = sqlComm;

        //             da.Fill(ds);

        //        }
        //    }

        //    return ds;
        //}

        //public async Task <tblCatalogo> GetCatalogoLista()
        //{
        //  tblCatalogo _ListaResult;
        //    ConvertirLista Ls = new ConvertirLista();
        //    DataSet ds = new DataSet();
        //    List<tblCatalogo> res = new List<tblCatalogo>();

        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        using (var command = new Microsoft.Data.SqlClient.SqlCommand("spConsultaCatalogo", connection))
        //        {
        //            SqlCommand sqlComm = new SqlCommand("spConsultaCatalogo", connection);
        //            //sqlComm.Parameters.AddWithValue("@Start", StartTime);
        //            //sqlComm.Parameters.AddWithValue("@Finish", FinishTime);
        //            //sqlComm.Parameters.AddWithValue("@TimeRange", TimeRange);

        //            sqlComm.CommandType = CommandType.StoredProcedure;

        //            SqlDataAdapter da = new SqlDataAdapter();
        //            da.SelectCommand = sqlComm;

        //            da.Fill(ds);


        //            _ListaResult =  Ls.ListaRetorno(ds);

        //        }
        //    }

        //    return _ListaResult;
        //}
    }
}

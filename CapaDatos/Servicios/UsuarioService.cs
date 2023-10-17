using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.Servicios
{
    public class UsuarioService
    {

        private readonly ConexionSQL _dbContext;
        private readonly string _connectionString;

        public UsuarioService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CadenaSQL");
        }

        public void ExecuteStoredProcedure(string NombreSP)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(NombreSP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
        }

        //public async Task<dynamic> ExecuteStoredProcedureDynamic()
        //{
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        using (var command = new Microsoft.Data.SqlClient.SqlCommand("StoredProcedureName", connection))
        //        {
                  
        //            return await connection.QueryAsync<dynamic>(
        //           @"SELECT Id, FechaEmision, NumeroSeguimiento, UsuarioRut, SolicitudEstadoId
        //           FROM Solicitudes
        //           WHERE Id=@id",
        //           new { id }
        //           );

        //        }
        //    }
        //}

    }
}

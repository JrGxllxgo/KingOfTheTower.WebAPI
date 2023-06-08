using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Common
{
    internal class Connections
    {
        #region Fields

        private static string _connectionString = "Server=tcp:sql-server-kot.database.windows.net,1433;Initial Catalog=tfc-kingofthetower-db;Persist Security Info=False;User ID=admin-gallego;Password=@tfckot23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 60;";

        #endregion

        #region Attributes

        internal static string StringConnection { get => _connectionString; }

        #endregion

        #region Methods

        /// <summary>
        ///     Ejecuta la query que se envía por parámetro y se recoge
        ///     un resultado
        /// </summary>
        /// <param name="sql">Consulta SQL</param>
        public void ExecuteReader(string sql)
        {
            using (var connection = new SqlConnection(Connections.StringConnection))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(sql, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // TO DO -> Hay que ver que casos se van a desarrollar
                    }
                }
                catch (Exception ex)
                {
                    var m = ex.Message;
                    throw;
                }
                finally 
                {
                    connection.Close();
                } 
            }
        }

        /// <summary>
        ///     Ejecuta la query que se envía por parámetro y se devuelve
        ///     el númeo de registros afectados
        /// </summary>
        /// <param name="sql">Consulta SQL</param>
        public int ExecuteNonQuery(string sql)
        {
            var result = 0;

            using (var connection = new SqlConnection(Connections.StringConnection))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(sql, connection);
                    var reader = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    var m = ex.Message;
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return result;
        }

        #endregion
    }
}

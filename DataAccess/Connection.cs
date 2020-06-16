using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        public SqlConnection getConnection(String dataSource)
        {
            SqlConnection conexion = new SqlConnection("server=DIEGO-PC ; database=base1 ; integrated security = true");
            try
            {
                conexion.Open();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}

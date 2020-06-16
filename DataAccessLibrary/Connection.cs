using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class Connection
    {
        #region "PATRON SINGLETON"
        private static Connection connection = null;

        private Connection() { }

        public static Connection getInstance()
        {
            if (connection == null)
            {
                connection = new Connection();
            }
            return connection;
        }
        #endregion

        public SqlConnection getConnection()
        {
          
            try
            {
                SqlConnection conexion = new SqlConnection();
                //conexion.ConnectionString = "Data Source=0.0.0.0; Initial Catalog=test; User ID=ss; Password=qRr8/1qNn__aaaaw|";
                conexion.ConnectionString = GetConnectionString();
                conexion.Open();
                return conexion;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }

        public String GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DataAccessLibrary
{
    public class GaugesDAO
    {
        public bool createGaugeByIdProject (Gauges gauges)
        {
            SqlConnection sqlConnection = null;
            SqlCommand cmd = null;
          //  SqlDataReader dr = null;
            bool response = false;
            try
            {
                sqlConnection = DataAccess.Connection.getInstance().getConnection();
                cmd = new SqlCommand("sp_CreateGauges", sqlConnection);
                cmd.Parameters.AddWithValue("@idProject", gauges.codigo_proyecto);
                cmd.Parameters.AddWithValue("@nameGauge", gauges.nombre_indicador);
                cmd.Parameters.AddWithValue("@valueGauge", gauges.valor_indicador);
                cmd.Parameters.AddWithValue("@observationGauge", gauges.observacion_indicador);
                cmd.CommandType = CommandType.StoredProcedure;
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch(Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
            return response;
        }
    }
}

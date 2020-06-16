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
    public class ProyectosDAO
    {
        public List<Proyecto> getByIdProject(int idProject)
        {
            SqlConnection sqlConnection = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Proyecto> listProjectById = new List<Models.Proyecto>();
            try
            {

                sqlConnection = DataAccess.Connection.getInstance().getConnection();
                cmd = new SqlCommand("sp_getProjectById", sqlConnection);               
                cmd.Parameters.AddWithValue("@idProject", idProject);
                cmd.CommandType = CommandType.StoredProcedure;
               // sqlConnection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Proyecto proyecto = new Models.Proyecto();
                    proyecto.nombre_proyecto = dr["nombre_proyecto"].ToString(); 
                    proyecto.id_proyectos = Convert.ToInt32(dr["id_proyectos"].ToString());
                    proyecto.estatus_proyecto = dr["estatus_proyecto"].ToString();
                    proyecto.observacion_proyecto =  dr["observacion_proyecto"].ToString();
                    listProjectById.Add(proyecto);
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
            return listProjectById;
        }
    }
}

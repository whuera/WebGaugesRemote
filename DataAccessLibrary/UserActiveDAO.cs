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
    public class UserActiveDAO
    {
        public UserApp getUserActiveById(string login)
        {
            SqlConnection sqlConnection = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string userBase = null;
           // bool response = false;
            UserApp userBdd = new UserApp();
            try
            {
                sqlConnection = DataAccess.Connection.getInstance().getConnection();
                cmd = new SqlCommand("sp_getActiveUser", sqlConnection);
                cmd.Parameters.AddWithValue("@userLogin", login);
                cmd.CommandType = CommandType.StoredProcedure;                                
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   userBase =  dr["usuario"].ToString();
                    userBdd.nombres = dr["nombres"].ToString();
                    userBdd.apellidos = dr["apellidos"].ToString();
                    userBdd.usuario = dr["usuario"].ToString();
                    userBdd.dataform = Convert.ToInt32(dr["dataform"]);
                    userBdd.app_rol = Convert.ToInt32(dr["id_roles"]);
                    userBdd.area = Convert.ToInt32(dr["id_areas"]);
                }                
              //  response = userBase != null ? true : false;
            }
            catch (Exception ex)
            {
               // response = false;
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
            return userBdd;
        }


    
        public bool createActiveUser(UserApp userApp)
        {
            SqlConnection sqlConnection = null;
            SqlCommand cmd = null;
            //  SqlDataReader dr = null;
            bool response = false;
            try
            {
                sqlConnection = DataAccess.Connection.getInstance().getConnection();
                cmd = new SqlCommand("sp_CreateActiveUser", sqlConnection);
                cmd.Parameters.AddWithValue("@firtsNames", userApp.nombres);
                cmd.Parameters.AddWithValue("@lastNames", userApp.apellidos);
                cmd.Parameters.AddWithValue("@area", userApp.area);
                cmd.Parameters.AddWithValue("@email", userApp.email);
                cmd.Parameters.AddWithValue("@usuario", userApp.usuario);
                cmd.Parameters.AddWithValue("@dataform", 1);
                cmd.Parameters.AddWithValue("@status_user", userApp.estatus);
                cmd.Parameters.AddWithValue("@rol", userApp.rol);
                cmd.CommandType = CommandType.StoredProcedure;
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch (Exception ex)
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

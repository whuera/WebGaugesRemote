using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BusinessRule
{
   public class AppImpl : app
    {
        public string getAppCode()
        {
            //Connection conn = new Connection();
            //System.Data.SqlClient.SqlConnection sqlConnection = conn.getConnection();
            return "get connection ok";
            //throw new NotImplementedException();
        }
    }
}

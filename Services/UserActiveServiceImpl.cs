using DataAccessLibrary;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary
{
    public class UserActiveServiceImpl : IActiveUser
    {
        public bool createActiveUser(UserApp userApp)
        {
            bool response = false;
            try
            {
                UserActiveDAO userActiveDAO = new UserActiveDAO();
                response = userActiveDAO.createActiveUser(userApp);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
            return response;
        }

        public UserApp getActiveUserById(string login)
        {
            //bool response = false;
            UserApp userApp = new UserApp();
            try
            {
                UserActiveDAO userActiveDAO = new UserActiveDAO();
                userApp = userActiveDAO.getUserActiveById(login);
            }catch(Exception ex)
            {
                throw new NotImplementedException();
            }
            return userApp;
            
        }
        
        


    }
}

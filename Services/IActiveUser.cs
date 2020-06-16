using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary
{
    public interface IActiveUser
    {
        UserApp getActiveUserById(string login);

        bool createActiveUser(UserApp userApp);
    }
}

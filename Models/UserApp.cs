using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserApp
    {
        public string usuario { get; set; }
        public string password { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public int estatus { get; set; }
        public int area { get; set; }
        public int dataform { get; set; }
        public int rol { get; set; }

        public int app_rol { get; set; }

    }
}

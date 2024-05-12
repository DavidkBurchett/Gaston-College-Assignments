using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    //this is the password object used for properly communicating with the database.
    public class PasswordModel
    {
        public int ID { get; set; }
        public string Application { get; set; }
        public string Password { get; set; }
    }
}

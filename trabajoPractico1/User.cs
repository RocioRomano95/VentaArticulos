using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace trabajoPractico1
{
    public class User
    {

        private int _id;
        private string _name;
        private string _lastName;
        private string _userName;
        private string _password;
        private string _email;


        public User(int id, string name, string lastName, string userName, string password, string email)
        {
            _id = id;
            _name = name;
            _lastName = lastName;
            _userName = userName;
            _password = password;
            _email = email;
        }   


        public int Id { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } } 
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string Password { get { return _password; } set { _password = value; }  }
        public string Email { get { return _email; } set { _email = value; } }
    
    } 

}

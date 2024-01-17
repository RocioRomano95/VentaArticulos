using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace trabajoPractico1
{
    public class Sale
    {
        private int _id;
        private string _comments;
        private int _userId;

        public Sale( int id,string comments,int userId)
        {
            _id = id;       
            _comments = comments;
            _userId = userId;
        }

        public int Id { get { return _id; }}
        public string Comments { get { return _comments; } set { _comments = value;  } }
        public int UserId { get { return _userId; } set { _userId = value; } }
    }
}

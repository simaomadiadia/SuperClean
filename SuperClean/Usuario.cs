using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class Usuario
    {
        private string username;


        public void setUsername(string username)
        {
            this.username= username;
        }

        public string getUsername()
        {
            return username; 
        }
    }
}

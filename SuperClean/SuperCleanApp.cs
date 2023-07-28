using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class SuperCleanApp
    {

        private Dictionary<string, Residencia> usersHomes;
        
        public SuperCleanApp() 
        { 
            usersHomes = new Dictionary<string, Residencia>();
        }
    }
} 

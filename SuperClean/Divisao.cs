using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class Divisao
    {
        private int idDivisao;
        private string name;
        private int cleanTime;
        private int cleanInterval;

        public Divisao()
        {
            Console.WriteLine("Foi criado um compartimento .");
        }

        public Divisao(int idDivisao,string name, int cleanTime,int cleanInterval)
        {
            this.idDivisao = idDivisao;
            this.name = name;
            this.cleanTime = cleanTime;
            this.cleanInterval = cleanInterval;
        }

       


        public void setIdDivisao(int idDivisao)
        {
            this.idDivisao= idDivisao;
        }

        public int getIdDivisao() {
        
        return this.idDivisao;
        }

        public void setName(string name) {
            this.name= name;
        }
        public string getName() { 
            return this.name; 
        }

        public void setCleanTime(int cleanTime)
        {
            this.cleanTime= cleanTime;

        }
        public int getCleanTime()
        {
            return this.cleanTime;
        }

        public void setCleanInterval(int cleanInterval) {
            this.cleanInterval= cleanInterval;
        }

        public int getCleanInterval()
        {
            return this.cleanInterval;
        }



      
    }
}

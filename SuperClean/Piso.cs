using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class Piso
    {
        private string name;
        public List<Divisao> divisoes = new List<Divisao>();

        


        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
         
        public void addDivisao( Divisao divisao)
        {
            divisoes.Add(divisao);
        }

        public void removerDivisao(Divisao divisao)
        {
           
        }

        // metodo que permite mostrar nome do piso e os seus compartimentos ou divisoes
        public void MostrarPiso()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("{");
            foreach (var divisao in divisoes)
            {
                Console.Write(
                    $"  Name          :{divisao.getName()} \n" +
                    $"  CleanTime     :{divisao.getCleanTime()}\n" +
                    $"  CleanInterval :{divisao.getCleanInterval()} \n \n"
                    );
            }
            Console.WriteLine("}\n \n");
        }
    }
}

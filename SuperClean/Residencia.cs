using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class Residencia
    {
        public string name;
        public DateTime lastUpdated;
        public List<Piso> pisos;


        public Residencia(string name) 
        {
            this.name = name;
            this.lastUpdated = DateTime.Now;
            this.pisos = new List<Piso>() ;
        
        }

        public void addPiso(Piso piso)
        {
            pisos.Add(piso);
        }
       

        //metodo que permite mostra usuario de uma residencia e os seus respeitivos pisos e divisoes
       /* public void mostrarResidencia()
        {
            Console.WriteLine("Home");
            Console.WriteLine("Username " + this.username);

            Console.WriteLine("{");
            foreach (var piso in pisos)
            {
                Console.Write(
                    $" {piso.getName()} \n"
                    );
                foreach (var divisao in piso.divisoes)
                {
                    Console.WriteLine("    -"+divisao.getName());
                }
            }
            Console.WriteLine("}\n \n");




        }*/

    }
}

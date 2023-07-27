using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class Residencia
    {
        private int idResidencia;
        private string username;
        public List<Piso> pisos = new List<Piso>() ;


        public void setIdResidencia(int idResidencia)
        {
            this.idResidencia = idResidencia;
        }

        public int getIdResidencia() {
            return this.idResidencia;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getUsername()
        {
            return this.username;
        }

        public void addPiso(Piso piso)
        {
            pisos.Add(piso);
        }
       

        //metodo que permite mostra usuario de uma residencia e os seus respeitivos pisos e divisoes
        public void mostrarResidencia()
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




        }

    }
}

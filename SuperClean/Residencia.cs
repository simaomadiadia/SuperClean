using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        // metedo para adicionar um novo piso a residência
        public void AdicionarPiso(string nomePiso) 
        {
            Piso piso = pisos.Find(p => p.getName() == nomePiso);
            if (piso != null) { throw new ArgumentException("piso já existente na residência"); }

            pisos.Add(new Piso(nomePiso));
            lastUpdated = DateTime.Now;
        }

        // método para editar o nome de um piso existente
        public void EditarNomePiso(string nomePisoAntigo, string nomePisoNovo) 
        {
            Piso piso = this.pisos.Find(p => p.getName() == nomePisoAntigo);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na residência"); }

            piso.setName(nomePisoNovo);
            lastUpdated = DateTime.Now;
        }

        // método para apagar um piso na residência 
        public void ApagarPiso(string nomePiso) 
        {
            Piso piso = this.pisos.Find(p => p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            this.pisos.Remove(piso);
            lastUpdated = DateTime.Now;
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

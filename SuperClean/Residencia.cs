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

        // Método Para adicionar uma nova divisão ao piso 
        public void AdicionarDivisao(string nomePiso, string nomeDivisao, int cleanTime, int cleanInterval) 
        {
            Piso piso = this.pisos.Find(p => p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            piso.AdicionarDivisao(nomeDivisao, cleanTime, cleanInterval);
            lastUpdated = DateTime.Now;
        }

        // método para editar uma divisão existente no piso
        public void EditarDivisao(string nomePiso, string nomeDivisaoAntigo, string nomeDivisaoNovo, int cleanTime, int cleanIntervalo) 
        {
            Piso piso = this.pisos.Find(p => p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            piso.editarDivisao(nomeDivisaoAntigo, nomeDivisaoNovo, cleanTime, cleanIntervalo);
            lastUpdated = DateTime.Now;
        }

        // metodo para apagar uma divisao num piso
        public void ApagarDivisao(string nomePiso, string nomeDivisao) 
        {
            Piso piso = this.pisos.Find(p=> p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("piso não encontrado na Residência"); }
            piso.ApagarDivisao(nomeDivisao);
            lastUpdated= DateTime.Now;
        }

    }
}

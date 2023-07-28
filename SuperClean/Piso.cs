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
        public List<Divisao> divisoes;

        public Piso(string name) 
        {
            this.name = name;
            this.divisoes = new List<Divisao>();
        }

        // metodo para adicionar uma nova divisão ao piso
        public void AdicionarDivisao(string nomeDivisao, int cleanTime, int cleanIntervalo) 
        {
            Divisao divisao = divisoes.Find(d => d.name == nomeDivisao);
            if (divisao != null) { throw new ArgumentException("Divisão já existente no piso"); }
            divisoes.Add(new Divisao(nomeDivisao,cleanTime, cleanIntervalo));
        }

        // metodo para editar uma divisão existente no piso 
        public void editarDivisao(string nomeDivisaoAntigo, string nomeDivisaoNovo, int cleanTime, int cleanIntervalo) 
        {
            Divisao divisao = divisoes.Find(d => d.name == nomeDivisaoAntigo);
            if (divisao == null) { throw new ArgumentException("Divisão não encontrada no piso"); }

            divisao.name = nomeDivisaoNovo;
            divisao.cleanTime = cleanTime;
            divisao.cleanInterval = cleanIntervalo;
        }

        // metodo para apagar uma divisao existentes no piso
        public void ApagarDivisao(string nomeDivisao) 
        {
            Divisao divisao = divisoes.Find(d=> d.name == nomeDivisao);
            if(divisao != null) { throw new ArgumentException("Divisão não encontrada no piso"); }
            divisoes.Remove(divisao);
        }
  
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
    }
}

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
        private List<Divisao> divisoes;

        public Piso(string name) 
        {
            this.name = name;
            this.divisoes = new List<Divisao>();
        }

        // metodo para adicionar uma nova divisão ao piso
        public void AdicionarDivisao(string nomeDivisao, int cleanTime, int cleanIntervalo) 
        {
            Divisao divisao = divisoes.Find(d => d.getName() == nomeDivisao);
            if (divisao != null) { throw new ArgumentException("Divisão já existente no piso"); }
            divisoes.Add(new Divisao(nomeDivisao,cleanTime, cleanIntervalo));
        }

        // metodo para editar uma divisão existente no piso 
        public void editarDivisao(string nomeDivisaoAntigo, string nomeDivisaoNovo, int cleanTime, int cleanIntervalo) 
        {
            Divisao divisao = divisoes.Find(d => d.getName() == nomeDivisaoAntigo);
            if (divisao == null) { throw new ArgumentException("Divisão não encontrada no piso"); }

            divisao.setName(nomeDivisaoNovo);
            divisao.setCleanTime(cleanTime);
            divisao.setCleanInterval(cleanIntervalo);
        }

        // metodo para apagar uma divisao existentes no piso
        public void ApagarDivisao(string nomeDivisao) 
        {
            Divisao divisao = divisoes.Find(d=> d.getName() == nomeDivisao);
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

        public void setDivisoes(List<Divisao> divisoes)
        {
        this.divisoes = divisoes;
        }

        public List<Divisao> getDivisoes() { return this.divisoes; }
    }
}

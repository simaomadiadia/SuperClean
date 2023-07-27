using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class Divisao
    {
        private string idDivisao;
        private string name;
        private int cleanTime;
        private int cleanInterval;
        private DateTime? lastCleanDate;

        public Divisao()
        {
            Console.WriteLine("Foi criado um compartimento .");
        }

        public Divisao(string name, int cleanTime,int cleanInterval)
        {
            this.idDivisao = Guid.NewGuid().ToString();
            this.name = name;
            this.cleanTime = cleanTime;
            this.cleanInterval = cleanInterval;
            this.lastCleanDate = null;
        }

         // metodo para marcar uma limpesa na divisao

        public void MarcarLimpesa() 
        { 
         this.lastCleanDate = DateTime.Now;
        
        }

        // metodo para remover a marcação da divisão

        public void RemoverLimpesa() 
        {
            this.lastCleanDate = null;
        
        }

        // metodo para verificar se a divisão esta suja

        public bool EstaSuja() 
        {
            if(this.lastCleanDate == null) { return true; } // se ainda nao foi limpa esta suja

            DateTime dataAtual = DateTime.Now;
            
            int diasDesdeUltimaLimpesa = (int)dataAtual.Subtract(this.lastCleanDate.Value).TotalDays;

            if(diasDesdeUltimaLimpesa >= this.cleanInterval) { return true;} // se ja passou o intervalo de limpesa esta suja
            
            return false;  // caso contrario esta limpa
        }

        // metodo para obter o tempo esperado ate a próxima limpesa

        public int ObterTempoProximaLimpesa() 
        { 
            if (this.lastCleanDate == null) { return this.cleanInterval; } // se ainda não limpa o tempo esperado é o intervalo de limpesa

            DateTime dataAtual = DateTime.Now;
            int diasDesdeUltimaLimpesa = (int)dataAtual.Subtract(this.lastCleanDate.Value).TotalDays;

            int tempoProximaLimpesa = this.cleanInterval - diasDesdeUltimaLimpesa;

            return tempoProximaLimpesa >= 0 ? tempoProximaLimpesa : 0; // retorna o tempo restante para a proxima limpesa ou (0) se ja passou o interv.
        }
    }
}

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

        public Divisao(string name, int cleanTime,int cleanInterval)
        {
            idDivisao = Guid.NewGuid().ToString(); // Guid serve para um id único, e não repetido permito que o id divisão seja único. 
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

        // metodo para obter o tempo esperado ate a próxima limpeza
        public int ObterTempoProximaLimpeza() 
        { 
            if (this.lastCleanDate == null) { return this.cleanInterval; } // se ainda não limpa o tempo esperado é o intervalo de limpesa

            DateTime dataAtual = DateTime.Now;
            int diasDesdeUltimaLimpeza = (int)dataAtual.Subtract(this.lastCleanDate.Value).TotalDays;
            int tempoProximaLimpeza = this.cleanInterval - diasDesdeUltimaLimpeza;

            return tempoProximaLimpeza >= 0 ? tempoProximaLimpeza : 0; // retorna o tempo restante para a proxima limpeza ou (0) se ja passou o interv.
        }

        public void setName(string name) 
        { 
            this.name = name;
        }

        public string getName() { return this.name;}

        public string getIdDivisao() { return idDivisao;}

        public void setCleanTime(int cleanTime) 
        {
            this.cleanTime = cleanTime;
        }
        
        public int getCleanTime() { return cleanTime; }

        public void setInterval(int interval) 
        {
            this.cleanInterval= interval;
        }

        public int getCleanInterval() {  return cleanInterval; }

        public void setLastCleanDate(DateTime lastCleanDate) 
        {
        this.lastCleanDate = lastCleanDate;
        }
    }

}

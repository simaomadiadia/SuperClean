using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    internal class SuperCleanApp
    {

        private Dictionary<string, Residencia> usersHomes;
        
        public SuperCleanApp() 
        { 
            usersHomes = new Dictionary<string, Residencia>();
        }

        // metodo para criar um novo utilizador e a sua residência
        public void CriarUtlizador(string nomeUtilizador) 
        {
            if (usersHomes.ContainsKey(nomeUtilizador)) 
            {
                throw new ArgumentException("Utilizador já existe");
            }

            usersHomes.Add(nomeUtilizador, new Residencia(nomeUtilizador));
        }

        // metodo para criar uma nova residência para utilizador
        public void CriarResidência(string nomeUtlizador) 
        { 
            if (!usersHomes.ContainsKey(nomeUtlizador))
            {
                throw new ArgumentException("Utilizador não encontrado");
            }

            usersHomes[nomeUtlizador] = new Residencia(nomeUtlizador);
        }

        // metodo para adicionar um novo piso a residência do ultilizador
        public void AdicionarPiso(string nomeUtlizador, string nomePiso) 
        { 
            if(!usersHomes.ContainsKey(nomeUtlizador))
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            usersHomes[nomeUtlizador].AdicionarPiso(nomePiso);
        }

        // metodo para editar nome de um piso existente na residencia do utilizador 
        public void EditarNomePiso(string nomeUtilizador, string nomePisoAntigo, string nomePisoNovo) 
        {
            if (!usersHomes.ContainsKey(nomeUtilizador)) 
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            usersHomes[nomeUtilizador].EditarNomePiso(nomePisoAntigo, nomePisoNovo);
        }


    }
} 

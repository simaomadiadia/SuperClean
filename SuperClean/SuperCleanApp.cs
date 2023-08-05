using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
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

        // Metodo para verificar se o utilizador existe
        public bool ExisteUtilizador(string nomeUtilizador)
        {
            return usersHomes.ContainsKey(nomeUtilizador);
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
        public void CriarResidencia(string nomeUtlizador) 
        { 
            if (!usersHomes.ContainsKey(nomeUtlizador))
            {
                throw new ArgumentException("Utilizador não encontrado");
            }

            usersHomes[nomeUtlizador] = new Residencia(nomeUtlizador);
        }

        // metodo para obter toda residencia do utilizador
        public List<string> GetResidencias(string nomeUtilizador) 
        {
            if (usersHomes.ContainsKey(nomeUtilizador)) 
            {
                Residencia residencia = usersHomes[nomeUtilizador];
                return residencia.GetHomes();
            }
            else { return new List<string>(); }
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

        // Método para apagar um piso existente na residência do utilizador
        public void ApagarPiso(string nomeUtilizador, string nomePiso) 
        {
            if (!usersHomes.ContainsKey(nomeUtilizador)) 
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            usersHomes[nomeUtilizador].ApagarPiso(nomePiso);
        }

        // Metodo para adicionar uma nova divisão a um piso na residência do utilizador
        public void AdicionarDivisao(string nomeUtilizador, string nomePiso, string nomeDivisao, int cleanTime, int cleanInterval) 
        {
            if (!usersHomes.ContainsKey(nomeUtilizador)) 
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            usersHomes[nomeUtilizador].AdicionarDivisao(nomePiso,nomeDivisao, cleanTime, cleanInterval);
        }

        // Metodo para editar uma divisão existente no piso na residência do utilizador
        public void EditarDivisao(string nomeUtilizador, string nomePiso, string nomeDivisaoNovo, string nomeDivisaoAntigo, int cleanTime, int cleanInterval) 
        {
            if (!usersHomes.ContainsKey(nomeUtilizador)) 
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            usersHomes[nomeUtilizador].EditarDivisao(nomePiso, nomeDivisaoNovo, nomeDivisaoAntigo, cleanTime, cleanInterval);
        }

        // Metodo para apagar uma divisão num piso na residencia do Utilizador
        public void ApagarDivisao(string nomeUtilizador, string nomePiso, string nomeDivisao) 
        {
            if (!usersHomes.ContainsKey(nomeUtilizador)) 
            {
                throw new ArgumentException("Utilizar não encontrado");
            }
            usersHomes[nomeUtilizador].ApagarDivisao(nomePiso,nomeDivisao);
        }

        // Metodo para marcar a limpeza de uma divisão no piso na Residência do Utilizador
        public void MarcarLimpeza(string nomeUtilizador, string nomePiso, string nomeDivisao) 
        {
            if (!usersHomes.ContainsKey(nomeUtilizador)) 
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            usersHomes[nomeUtilizador].MarcarLimpeza(nomePiso, nomeDivisao);
        }

        // Metodo para remover a marcação de Limpeza de uma divisão num piso na residencia do utlização
        public void RemoverLimpeza(string nomeUtilizador, string nomeDivisao, string nomePiso) 
        {
            if (!usersHomes.ContainsKey(nomeUtilizador))
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            usersHomes[nomeUtilizador].RemoverLimpeza(nomeDivisao, nomePiso);
        }

        // Método para visualizar a arvore da divisões de um piso da residencia do utilizador
        public string VisualizarArvoreDivisoes(string nomeUtilizador)
        {
            if (!usersHomes.ContainsKey(nomeUtilizador))
            {
                throw new ArgumentException("Utilizador não encontrado");
            }
            return usersHomes[nomeUtilizador].VisualizarArvoreDivisoes();
        }

        // Método para pressistir os dados em ficheiro json 
        public void GuardarDadosEmFicheiroJson(string nomeFicheiro)
        {
            try
            {
                // criação de object que contém os dados dos utilizadores
                List<SerializableUser> serializableUsers = new List<SerializableUser>();
                
                // procorre todos os utilizadores para a Serialização
                foreach(var userData in usersHomes) 
                {
                    string userName = userData.Key;
                    Residencia userHome = userData.Value;
                    
                    // cria um objecto Serializable para o Utilizador contendo o seu nome e as suas casas
                    SerializableUser serializableUser = new SerializableUser { UserName = userName, Residencia = new List<SerializableResidencia> ()};

                    // precorre todas as casas do Utilizador para a Serialização
                  //  foreach(var residencias in userHome.getho)
                }

                string jsonString = JsonSerializer.Serialize(usersHomes);
                Console.WriteLine(jsonString);
                File.WriteAllText(nomeFicheiro, jsonString);
                Console.WriteLine("Dados guardados com sucesso");

            } catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gravar os dados: {ex.Message}");
            }
        }

        // Método para carregar os dados do Ficheiro Json
        public void CarregarDadosDoFicheiroJson(string nomeFicheiro) 
        {
            try
            {
                if (File.Exists(nomeFicheiro))
                {
                    string jsonString = File.ReadAllText(nomeFicheiro);
                    usersHomes = JsonSerializer.Deserialize<Dictionary<string, Residencia>>(jsonString);
                    Console.WriteLine("Dados Carregados com Sucesso");
                }
                else { Console.WriteLine("Ficheiro de Dados Não encontrado. Sera criado um Ficheiro novo"); }

            } catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gravar os Dados:{ex.Message}");
            }
        }

    }
}

[Serializable]
public class SerializableUser 
{
    public string UserName 
    {
        get; set;
    }
    public List<SerializableResidencia> Residencia { get; set; }
}

// class Sealizable para guardar os dados da casa 
[Serializable]
public class SerializableResidencia 
{
    public string Name { get; set; }
    public List<SerializablePiso> pisos { get; set; }
}
// class sealizable para guardar os dados dos pisos
[Serializable]
public class SerializablePiso 
{
    public string Name { get; set; }
    public List<SerializableDivisao> divisoes { get; set; }
}

// class Sealizable para guardar os dados da divisão
[Serializable]
public class SerializableDivisao 
{ 
    public string Name { get; set; }
    public int CleanTime { get; set; } 
    public int CleanInterval { get; set; }
}
// See https://aka.ms/new-console-template for more information
using SuperClean;

class Program 
{
    static void Main() 
    {
        SuperCleanApp app = new SuperCleanApp();

        // carregar dados do ficheiro, se houver 
        app.CarregarDadosDoFicheiroJson("dados.json");

        Console.WriteLine("\n\nBenvindo ao Super Clean!\n\n");
        Console.WriteLine("Digite o nome do Utilizador: ");
        string nomeUtilizador = Console.ReadLine();

        try
        {
            if(!app.ExisteUtilizador(nomeUtilizador)) 
            { 
                // se o Utilizador não existir, Cria um nome
                app.CriarUtlizador(nomeUtilizador);
            }

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\n--------  Menu  --------");
                Console.WriteLine("\n1. Adicionar Piso");
                Console.WriteLine("\n2. Adicionar Divisão");
                Console.WriteLine("\n3. Adicionar Limpeza");
                Console.WriteLine("\n4. Visualizar Área de Divisões");
                Console.WriteLine("\n0. Sair");
                Console.WriteLine("Opção: ");
                string opcao = Console.ReadLine();

                switch (opcao) 
                {
                    case "1":
                        Console.WriteLine("Nome do Piso Adicionar: ");
                        string nomePiso = Console.ReadLine();
                        app.AdicionarPiso(nomeUtilizador, nomePiso);
                        Console.WriteLine($"Piso '{nomePiso}' adicionado com sucesso!");

                        break;
                    case "2":
                        Console.WriteLine("Nome do piso aonde adicionar divisão: ");
                        string nomePiso1 = Console.ReadLine();
                        Console.WriteLine("Nome da divisão adicionar: ");
                        string nomeDivisao = Console.ReadLine();
                        Console.WriteLine("Tempo da Limpeza da divisão (Em minutos): ");
                        int cleanTime = int.Parse(Console.ReadLine());
                        Console.WriteLine("Intervalo de Limpeza da Divisão (Em dias): ");
                        int cleanInterval = int.Parse(Console.ReadLine());
                        app.AdicionarDivisao(nomeUtilizador, nomePiso1, nomeDivisao, cleanTime, cleanInterval);
                        Console.WriteLine($"Divisão '{nomeDivisao}' adicionada no piso '{nomePiso1}' com sucesso!");

                        break;
                    case "3":
                        Console.WriteLine("Opção 3");
                        break;
                    case "4":
                        Console.WriteLine("Opção 4");
                        break;
                    case "0":
                        Console.WriteLine("Opcão 0");
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Por favor, tente novamente.");
                        break;
                }
            }
            
        }catch (Exception ex) { Console.WriteLine($"Erro: {ex.Message}"); }
    }
}

// criacao de um Piso
//Piso p0 = new Piso();

//p0.setName("Piso 0 ");

// Criacao de  Compartimento de um determinado Piso
/*
Divisao d12 = new Divisao(1,"Garagem",20,25);
Divisao d13 = new Divisao(2, "Dispensa",11,23);
*/

/* Criacao de  Compartimento de um determinado Piso e
 adicao de compartimento no Piso 0 */

//p0.addDivisao(new Divisao(1, "Garagem", 20, 25));
//p0.addDivisao(new Divisao(2, "Dispensa", 11, 23));

// Listar todos compartimento de um Piso

//p0.MostrarPiso();





// criacao de um Piso
//Piso p1 = new Piso();
//p1.setName("Piso 1");

/* Criacao de  Compartimento de um determinado Piso */
/*
Divisao d1 = new Divisao(1, "quarto 1",12,10);
Divisao d2 = new Divisao(2,"quarto 2",13,16);
Divisao d3 = new Divisao(3,"sala",9,5);
Divisao d4 = new Divisao(4,"wc",15,19);
*/
/* Criacao de  Compartimento de um determinado Piso e
 adicao de compartimento no Piso 1 */
//p1.addDivisao(new Divisao(1, "quarto 1", 12, 10));
//p1.addDivisao(new Divisao(2, "quarto 2", 13, 16));
//p1.addDivisao(new Divisao(3, "sala", 9, 5));
//p1.addDivisao(new Divisao(4, "wc", 15, 19));


// Listar todos compartimento de um Piso

//p1.MostrarPiso();



// criacao de residencia  e adicao de pisos

//Residencia r1= new Residencia();
//r1.setUsername("Elson123");
//r1.addPiso(p0);
//r1.addPiso(p1);

//r1.mostrarResidencia(); ;















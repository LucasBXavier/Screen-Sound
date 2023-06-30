// Screen Sound
using System.Xml;

string mensagemBoasVindas = "Bem-Vindo ao Screen Sound";
//List<string> ListaDasBandas = new List<string> {"U2", "The Beatles", "Metallica" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatle", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas);
}


void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite '1' para registrar uma banda");
    Console.WriteLine("Digite '2' para mostrar todas as bandas");
    Console.WriteLine("Digite '3' para avaliar uma banda");
    Console.WriteLine("Digite '4' para exibir a media de uma banda");
    Console.WriteLine("Digite '0' para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: 
            RegistrarBandas();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4:
            MediaDaBanda();
            break;
        case 0:
            Sair();
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcoes("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloOpcoes("Bandas Registradas");

    //for (int i = 0;  i < ListaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("\nAperte qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBandas()
{
    //digitar a banda que deseja avaliar
    //se a banda existir >> atribuir nota
    // senão, voltar ao menu
    Console.Clear();
    ExibirTituloOpcoes("Avaliar Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota você atribuíria a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso, a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void MediaDaBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Media das Bandas");
    Console.WriteLine("Digite o nome da banda que deseja ver a media de avaliação: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.Write($"\nA média da banda {nomeDaBanda} é: {notasDaBanda.Average()}");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void Sair()
{
    Console.WriteLine("Até a próxima");
    Thread.Sleep(1000);
}

void ExibirTituloOpcoes(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesMenu();
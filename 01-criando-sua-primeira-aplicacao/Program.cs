Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirMenuPrincipal()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaBanda();
            break;
        case -1:
            Console.WriteLine("\nAté uma próxima vez! :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            Console.WriteLine("Aguarde para tentar novamente...");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenuPrincipal();
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de banda\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda,new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuPrincipal();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibição das bandas registradas\n");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuPrincipal();
}

void AvaliarBanda()
{
    Console.Clear();
    Console.WriteLine("Avaliar bandas registradas\n");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que deseja atribuir a banda {nomeDaBanda}? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi atribuida com sucesso a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenuPrincipal();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuPrincipal();
    }

}

void ExibirMediaBanda()
{
    Console.Clear();
    Console.WriteLine("Avaliação das bandas registradas\n");
    Console.Write("Digite o nome da banda que deseja exibir a média de avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average(); 
        Console.WriteLine($"\nA banda {nomeDaBanda} possuí a média de avaliações de: {mediaDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenuPrincipal();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuPrincipal();
    }
}
ExibirMenuPrincipal();
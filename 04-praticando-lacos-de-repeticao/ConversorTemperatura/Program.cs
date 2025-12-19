//Você está desenvolvendo um conversor de temperatura que permite ao usuário escolher entre duas opções: converter de Celsius para Fahrenheit ou de Fahrenheit para Celsius. O programa deve exibir um menu com essas opções e repetir até que o usuário escolha sair.

//Para isso, você precisará de um programa que:
//Exiba um menu com as opções de conversão e saída.
//Permita ao usuário escolher uma das opções.
//Exiba uma mensagem de Operação inválida caso escolhido uma opção que não existe.
//Realize a conversão de temperatura com base na escolha do usuário.
//Repita o menu até que o usuário escolha sair.

//Dicas:
//Fórmula para conversão de Celsius para fahrenheit: (celsius * 9 / 5) + 32
//Fórmula para conversão de fahrenheit para Celsius: (fahrenheit - 32) * 5 / 9

//Exemplo de entrada:
//1 - Celsius para Fahrenheit
//2 - Fahrenheit para Celsius
//3 - Sair
//Escolha uma opção: 1
//Digite a temperatura em Celsius: 25

//Saída esperada:
//25°C equivalem a 77°F

int opcao;
do
{
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine()!);
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
            break;
        case 2:
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahr = double.Parse(Console.ReadLine()!);
            double cel = (fahr - 32) * 5 / 9;
            Console.WriteLine($"{fahr}°F equivalem a {cel}°C");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 3);
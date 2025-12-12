//Imagine que você está desenvolvendo uma funcionalidade para um sistema de planos de saúde. A ideia é classificar um cliente conforme a sua idade em uma das faixas: infantil(0 a 12 anos), adolescente(13 a 17), adulto(18 a 59) ou idoso(60 ou mais).

//Crie um programa que:
//Receba a idade do cliente como entrada.
//Classifique-o em uma das faixas
//Infantil (0 a 12 anos)
//Adolescente (13 a 17 anos)
//Adulto (18 a 59 anos)
//Idoso (60 anos ou mais)
//Exiba a categoria correspondente

//Exemplo de entrada:
//Digite a idade: 18

//Saída esperada:
//Classificação: adulto

Console.Write("Digite a idade: ");
int idade = int.Parse(Console.ReadLine()!);

if (idade >= 60)
{
    Console.WriteLine("Idoso");
}
else if (idade >= 18)
{
    Console.WriteLine("Adulto");
}
else if (idade >= 13)
{
    Console.WriteLine("Adolescente");
}
else if (idade >= 0)
{
    Console.WriteLine("Infantil");
}
else
{
    Console.WriteLine("Idade inválida");
}
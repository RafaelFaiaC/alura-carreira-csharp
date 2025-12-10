//Você foi contratado por uma empresa de construção civil. A empresa está expandindo os seus projetos e precisa de um sistema para calcular a área de terrenos retangulares. Para isso utilize a fórmula:
//área = largura * comprimento

//Para essa atividade, você deve criar um programa que:
//Declare duas variáveis para a largura e comprimento, respectivamente.
//Aplique a fórmula mencionada para calcular a área do terreno.
//Exiba o resultado do cálculo.

//Exemplo de entrada:
//double largura = 10.5;
//double comprimento = 20.3;

//Saída esperada:
//A área do terreno é: 213,15 metros quadrados.

Console.Write("Informe a largura do terreno: ");
float largura = float.Parse(Console.ReadLine()!);
Console.Write("Informe o comprimento do terreno: ");
float comprimento = float.Parse(Console.ReadLine()!);
float area = largura * comprimento;
Console.WriteLine($"A área do terreno é: {area} metros quadrados.");
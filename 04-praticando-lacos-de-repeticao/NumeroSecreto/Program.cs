//Imagine que você está desenvolvendo um jogo onde o jogador deve tentar adivinhar qual é o número secreto. O desafio é criar um programa que continue solicitando tentativas até que o jogador acerte o número, fornecendo feedback a cada tentativa.

//Crie um programa que:
//Declare uma variável com um inteiro para ser o número secreto.
//Verifique a cada interação se o número digitado é igual ao número secreto.
//Se o jogador errar, o programa informa que a tentativa está errada e solicita uma nova tentativa.
//Se o jogador acertar o número, o programa exibe uma mensagem de parabéns e encerra o jogo.

//Exemplo de entrada:
//Tente adivinhar o número entre 1 e 10: 7

//Saída esperada:
//Parabéns, você acertou!

int numeroSecreto = 5;
int tentativa = 0;

while (tentativa != numeroSecreto)
{
    Console.Write("Tente adivinhar o número entre 1 e 10: ");
    tentativa = int.Parse(Console.ReadLine()!);
    if (tentativa != numeroSecreto)
    {
        Console.WriteLine("Número errado, tente novamente.");
    }
}
Console.WriteLine("Parabéns, você acertou!");
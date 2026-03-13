//Imagine que você é responsável por gerenciar doações de uma campanha solidária. Cada contribuição recebida é registrada em um sistema, mas para saber o valor total arrecadado, é necessário somar manualmente todas as entradas.

//Seu desafio é criar um programa que automatize esse cálculo, percorrendo uma lista de valores e exibindo o montante final, garantindo que nenhum valor seja deixado de fora.
//Crie um programa que:

//Declare um array de números representando doações.
//Utilize um loop para somar todos os valores contidos no array.
//Exiba o total calculado na tela.

//Exemplo de entrada:
//double[] doacoes = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };

//Saída esperada:
//Total de doações: 979,23

double[] doacoes = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };
double totalDoacoes = 0.0;

foreach (double doacao in doacoes)
{
    totalDoacoes += doacao;
}

Console.WriteLine($"Total de doações: {totalDoacoes}");
//Imagine que você está desenvolvendo um sistema de gestão de estoque para um centro de distribuição de alimentos. Seu desafio é criar um programa que classifique os produtos conforme seu tipo, para otimizar o armazenamento em áreas específicas do armazém.

//Crie um programa que:
//Receba um código numérico (1 ou 2) representando o tipo de produto.
//Classifique o produto como:
//“Perecível” para código 1.
//“Não perecível” para código 2.
//Alerte o usuário caso o código seja inválido.

//Exemplo de entrada:
//Digite o código do produto (1 ou 2): 1

//Saída esperada:
//Perecível

Console.Write("Digite o código do produto (1 ou 2): ");
int codigo = int.Parse(Console.ReadLine()!);

if  (codigo == 1)
{
    Console.WriteLine("Perecível");
}
else if (codigo == 2)
{
    Console.WriteLine("Não Perecível");
}
else
{
    Console.WriteLine("Código digitado é inválido");
}
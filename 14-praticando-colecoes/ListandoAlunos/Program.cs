//Imagine que você é responsável por organizar as notas finais de uma turma em um sistema acadêmico. Cada aluno possui um nome único e uma nota que pode variar em precisão (como 8.5 ou 7.75). Seu desafio é criar uma estrutura que armazene essas informações de forma eficiente e as exiba de maneira clara para futuras consultas.

//Crie um programa que:
//Declare um dicionário com as informações de nome e nota de cada aluno
//Use um loop para iterar sobre essas notas
//Exiba as notas na tela
//Como iterar um dicionário? Antes de exibir as notas, é importante entender como o dicionário armazena os dados. Um KeyValuePair<tipo 1, tipo 2 > representa um par de elementos onde:
//tipo 1 é a chave (no caso, o nome do aluno).
//tipo 2 é o valor associado (a nota).
//Quando percorremos o dicionário com foreach, cada iteração retorna um KeyValuePair contendo um nome e sua respectiva nota, que podem ser acessados pelas propriedades Key e Value. Por exemplo, no caso da loja de eletrônicos, visto em vídeo:

//foreach (KeyValuePair < tipo 1, tipo 2> produto in produtos)  
//{  
//     Console.WriteLine($"ID: {produto.Key} - Nome: {produto.Value}");
//}  

//Ou, podemos simplificar usando var:
//foreach (var produto in produtos)
//{
//    Console.WriteLine($"ID: {produto.Key} - Nome: {produto.Value}");
//}

//Exemplo de entrada:
//notas.Add("Ana", 8.75m);
//notas.Add("Bruno", 6.90m);
//notas.Add("Clara", 9.25m);

//Saída esperada:
//Aluno: Ana - Nota: 8,75
//Aluno: Bruno - Nota: 6,90
//Aluno: Clara - Nota: 9,25

Dictionary<string, decimal> notas = new Dictionary<string, decimal>();
notas.Add("Ana", 8.75m);
notas.Add("Bruno", 6.90m);
notas.Add("Clara", 9.25m);

foreach (var nota in notas)
{
    Console.WriteLine($"Aluno: {nota.Key} - Nota: {nota.Value}");
}

//Imagine que você está desenvolvendo um sistema de sorteio para um evento beneficente. Cada participante cadastrou seu nome, e agora você precisa manipular a lista de forma aleatória para que os nomes fiquem embaralhados.

//Crie um programa que:
//Declare uma lista de nomes.
//Organize a lista em ordem alfabética.
//Inverta a ordem da lista.
//Remova o primeiro elemento e o adicione novamente na lista.
//Agora verifique quem está no índice 3 da lista e exiba o nome no console.

//Exemplo de entrada:
//List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };

//Saída esperada:
//Lista original:
//Ana, Carlos, Mariana, João, Lúcia

//Após Sort (ordem alfabética):
//Ana, Carlos, João, Lúcia, Mariana

//Após Reverse (ordem invertida):
//Mariana, Lúcia, João, Carlos, Ana

//Após remover o primeiro e adicioná-lo no fim:
//Lúcia, João, Carlos, Ana, Mariana

//A pessoa sorteada foi: Ana

List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };

Console.WriteLine("Lista original:");
Console.WriteLine(string.Join(", ", nomes));

Console.WriteLine("\nApós Sort (Ordem alfabética):");
nomes.Sort();
Console.WriteLine(string.Join(", ", nomes));

Console.WriteLine("\nApós Reverse (ordem invertida):");
nomes.Reverse();
Console.WriteLine(string.Join(", ", nomes));

Console.WriteLine("\nApós remover o primeiro e adicioná-lo no fim:");
string nomeRemovido = nomes[0];
nomes.RemoveAt(0);
nomes.Add(nomeRemovido);
Console.WriteLine(string.Join(", ", nomes));

Console.WriteLine($"\nA pessoa sorteada foi: {nomes[3]}");


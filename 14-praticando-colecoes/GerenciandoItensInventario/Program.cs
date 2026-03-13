//Imagine que você está desenvolvendo um sistema de inventário para um jogo. Seu objetivo é gerenciar os itens que o jogador carrega, garantindo que o inventário seja atualizado corretamente quando itens forem removidos ou novos itens forem adquiridos.

//Crie um programa que:
//Inicialize um dicionário com itens.
//Remova um item específico do inventário.
//Adicione um novo item ao inventário.
//Exiba a lista atualizada de itens.

//Exemplo de entrada:
//Dictionary<int, string> inventario = new Dictionary<int, string>()
//        {
//            { 1, "Espada Longa" },
//            { 2, "Arco Curto" },
//            { 3, "Escudo de Ferro" }
//        };

//Saída esperada:
//Itens no inventário inicial:
//ID: 1 - Espada Longa
//ID: 2 - Arco Curto
//ID: 3 - Escudo de Ferro
//---------------------
//Itens no inventário atualizado:
//ID: 1 - Espada Longa
//ID: 4 - Poção de Vida
//ID: 3 - Escudo de Ferro

Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" }
        };

Console.WriteLine("Itens no inventário inicial:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}

Console.WriteLine("---------------------");

inventario.Remove(2);
inventario.Add(4, "Poção de Vida");
Console.WriteLine("Itens no inventário atualizado:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}
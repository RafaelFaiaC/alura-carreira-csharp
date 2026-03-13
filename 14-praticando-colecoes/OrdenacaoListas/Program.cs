//Você está desenvolvendo um sistema de gerenciamento para uma conferência de inovação tecnológica. Durante o credenciamento, os participantes precisam ser chamados em ordem alfabética para evitar congestionamentos. Porém, a lista inicial de inscritos foi cadastrada sem organização, e o comitê exige que o terceiro nome da lista ordenada seja destacado para uma cerimônia especial.

//Crie um programa que:
//Declare um array com nomes de participantes.
//Ordene esse array alfabeticamente.
//Identifique e exiba o terceiro nome da lista após a ordenação.

//Exemplo de entrada:
//string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };

//Saída esperada:
//O terceiro nome da lista após ordenação é: Carolina

string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };

Array.Sort(nomes);

Console.WriteLine($"O terceiro nome da lista após ordenação é: {nomes[2]}");
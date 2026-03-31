//Imagine que você está desenvolvendo um sistema de formatação de relatórios para uma empresa de logística. Os relatórios precisam exibir informações como endereços, valores e datas em um formato padronizado, utilizando quebras de linha, tabulações e outros caracteres especiais para melhor organização visual.

//Crie um programa que:
//Solicite ao usuário:
//Nome do cliente.
//Endereço.
//Valor do frete.
//Data de entrega.
//Exiba os dados formatados em um bloco organizado.

//Exemplo de entrada:
//Digite o nome do cliente:
//Arthur Dent
//Digite o endereço:
//Rua do Chá Inglês, 42
//Digite o valor do frete:
//42,00
//Digite a data de entrega:
//15 / 05 / 2025

//Saída esperada:
//========== RELATÓRIO DE ENTREGA ==========

//Cliente:         "Arthur Dent"
//Endereço:        "Rua do Chá Inglês, 42"
//Valor do frete: R$ 42,00
//Data:            15/05/2025

//==========================================

Console.Write("Digite o nome do cliente: ");
string nomeCliente = Console.ReadLine()!;

Console.Write("Digite o endereço: ");
string endereco = Console.ReadLine()!;

Console.Write("Digite o valor do frete: ");
string valorFrete = Console.ReadLine()!;

Console.Write("Digite a data de entrega: ");
string dataEntrega = Console.ReadLine()!;

Console.WriteLine(@$"
========== RELATÓRIO DE ENTREGA ==========

Cliente:         ""{nomeCliente}""
Endereço:        ""{endereco}""
Valor do frete:  R$ {valorFrete}
Data:            {dataEntrega}

==========================================");
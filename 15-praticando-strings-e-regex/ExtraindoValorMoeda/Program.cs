//Imagine que você está desenvolvendo um sistema de processamento de recibos digitais, onde é necessário identificar o valor total de cada transação para registro no banco de dados. Seu programa deve ser capaz de localizar o primeiro valor monetário formatado em reais (R$) dentro do texto, garantindo que apenas valores válidos sejam capturados.

//Crie um programa que:
//Receba um texto contendo valores monetários no formato "R$ XX,XX".
//Extraia apenas o primeiro valor encontrado nesse formato.
//Exiba o valor capturado na tela.

//Exemplo de entrada:
//Digite o texto do recibo:
//O valor total é R$ 99,90 e pode ser parcelado em 3x de R$ 33,30.

//Saída esperada:
//Valor encontrado: R$ 99,90

using System.Text.RegularExpressions;

Console.Write("Digite o texto do recibo: ");
string textoRecibo = Console.ReadLine()!;

Regex regexValor = new Regex(@"R\$ \d+(,\d{2})?");

Console.WriteLine($"Valor encontrado: {regexValor.Match(textoRecibo)}");
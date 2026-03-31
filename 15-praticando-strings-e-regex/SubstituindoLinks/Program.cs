//Imagine que você está desenvolvendo um sistema de pré-moderação para um fórum online, onde todos os links compartilhados precisam ser ocultados temporariamente até que sejam aprovados por um moderador. Seu programa deve identificar qualquer URL no texto e substituí-la por um marcador genérico, garantindo que os usuários não acessem conteúdos potencialmente inseguros antes da revisão.

//Crie um programa que:
//Receba um texto contendo links.
//Identifique todas as URLs que começam com "http://" ou "https://".
//Substitua cada URL encontrada por "[LINK]".
//Exiba o texto modificado na tela.

//Exemplo de entrada:
//Digite o texto:
//Acesse https://meusite.com ou http://exemplo.org para mais informações.

//Saída esperada:
//Acesse[LINK] ou[LINK] para mais informações.

using System.Text.RegularExpressions;

Console.WriteLine("Digite o texto: ");
string texto = Console.ReadLine()!;

Regex regex = new Regex(@"https?://\S+");

string resultado = regex.Replace(texto, "[LINK]");

Console.WriteLine(resultado);
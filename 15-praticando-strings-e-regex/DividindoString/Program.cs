//Imagine que você está desenvolvendo um sistema de monitoramento de erros para uma aplicação web. Cada registro de log contém informações importantes separadas por vírgulas, incluindo data, tipo de erro e mensagem detalhada. Seu objetivo é processar esses logs para facilitar a análise dos problemas. Para isso, você precisa criar um programa que:

//Declare uma string de log no formato "data,tipo,mensagem"
//Separe essa string em partes individuais usando a vírgula como delimitador
//Exiba cada informação de forma organizada e legível

//Exemplo de entrada:
//log = "2025-03-25,Erro,Arquivo não encontrado";

//Saída esperada:
//Data: 2025 - 03 - 25
//Tipo de erro: Erro
//Mensagem: Arquivo não encontrado

string log = "2025-03-25,Erro,Arquivo não encontrado";
string[] partes = log.Split(',');

Console.WriteLine(partes[0]);
Console.WriteLine(partes[1]);
Console.WriteLine(partes[2]);
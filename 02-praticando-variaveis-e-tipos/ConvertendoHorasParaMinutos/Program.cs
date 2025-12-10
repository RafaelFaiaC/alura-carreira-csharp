//Imagine que você está desenvolvendo um sistema de gerenciamento de tempo para um aplicativo de produtividade. Esse sistema precisa converter o tempo total de atividades, registrado em minutos, para um formato mais legível (horas e minutos), facilitando a visualização do usuário.

//Crie um programa que:
//Declare uma variável com um valor inteiro representando o total de minutos.
//Calcule quantas horas completas existem nesse valor e quantos minutos restam.
//Exiba o resultado no formato X horas e Y minutos.

//Exemplo de entrada:
//int minutos = 250;

//Saída esperada:
//Tempo: 4 horas e 10 minutos   

Console.Write("Quantos minutos de atividade foram realiados? ");
int minutos = int.Parse(Console.ReadLine()!);
int horas = (minutos / 60);
minutos = (minutos % 60);
Console.WriteLine($"Tempo: {horas} horas e {minutos} minutos");
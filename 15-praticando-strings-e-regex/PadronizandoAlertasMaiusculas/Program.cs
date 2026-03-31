//Você está desenvolvendo um sistema de notificações críticas para um ambiente corporativo, onde todos os alertas devem seguir um padrão visual para chamar atenção imediata. Seu programa precisa garantir que mensagens de aviso - como expiração de sessão ou falhas de segurança - sejam exibidas integralmente em letras maiúsculas, independentemente de como foram digitadas ou recebidas.

//Crie um programa que:
//Receba uma string contendo um alerta.
//Converta todos os caracteres para maiúsculas.
//Exiba o texto padronizado na tela.

//Exemplo de entrada:
//Digite o alerta:
//atenção: seu acesso será expirado em 5 minutos.

//Saída esperada:
//ATENÇÃO: SEU ACESSO SERÁ EXPIRADO EM 5 MINUTOS.

Console.Write("Digite o alerta: ");
string alerta = Console.ReadLine()!;

Console.WriteLine(alerta.ToUpper());
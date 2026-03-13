//Você está desenvolvendo um sistema de recompensas para uma plataforma de ensino. Quando alunos completam desafios difíceis, eles recebem mensagens secretas que só podem ser lidas quando decifradas. Para decifrar uma mensagem, é preciso invertê-la.

//A mensagem atual é:
//'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o'.

//Crie um programa que:
//Inicialize uma lista com os caracteres descritos acima
//Decifre a mensagem dada pelos caracteres descritos
//Exiba o resultado

//Saída esperada:
//o
//l
//á
 
//m
//u
//n
//d
//o

List<char> mensagemSecreta = new List<char> { 'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o' };
mensagemSecreta.Reverse();

foreach (char caractere in mensagemSecreta)
{
    Console.WriteLine(caractere);
}

//Imagine que você é responsável pelo sistema de monitoramento das notas dos alunos de uma escola. Cada aluno tem sua nota monitorada e é importante verificar se algum aluno está com a nota abaixo da média de aprovação. Caso a nota de algum aluno esteja abaixo da média, você precisa gerar um alerta. O alerta de aprovação é uma média de 7.0, ou seja, qualquer aluno com nota abaixo disso deve gerar um aviso.

//Seu desafio é escolher o laço de repetição mais adequado para percorrer a lista de alunos e verificar se as notas deles estão dentro da faixa de aprovação.

//List<double> notas= new List<double>
//        {
//    8.5,
//    6.2,
//    9.1,
//    5.8,
//    7.4
//        };

//Saída esperada:
//O aluno com a nota 8,5 está indo muito bem!
//O aluno com a nota 6,2 está abaixo da média!
//O aluno com a nota 9,1 está indo muito bem!
//O aluno com a nota 5,8 está abaixo da média!
//O aluno com a nota 7,4 está indo muito bem!

List<double> notas = new List<double> {8.5, 6.2, 9.1, 5.8, 7.4};

foreach (var nota in notas)
{
    if (nota < 7.0)
    {
        Console.WriteLine($"O aluno com a nota {nota} está abaixo da média!");
    }
    else
    {
        Console.WriteLine($"O aluno com a nota {nota} está indo muito bem!");
    }
}
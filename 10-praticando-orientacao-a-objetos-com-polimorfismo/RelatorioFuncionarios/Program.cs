//Imagine que você está construindo um sistema de RH que gera relatórios personalizados. Você criou uma classe base chamada Funcionario, e duas subclasses: Gerente e Desenvolvedor. Cada tipo de funcionário deve gerar um relatório diferente, sobrescrevendo um método chamado GerarRelatorio().

//Crie essas três classes com um método public virtual string GerarRelatorio() na base, e sobrescreva esse método nas classes filhas.

//Exemplo de entrada:
//Funcionario f1 = new Gerente();
//Funcionario f2 = new Desenvolvedor();

//Console.WriteLine(f1.GerarRelatorio());
//Console.WriteLine(f2.GerarRelatorio());

//Exemplo de saída:
//Relatório do gerente: supervisiona a equipe.
//Relatório do desenvolvedor: escreve código e corrige bugs.

Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());
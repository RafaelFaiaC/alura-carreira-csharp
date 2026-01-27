//Imagine que você está desenvolvendo um sistema de folha de pagamento. A classe Funcionario possui um salário que só pode ser aumentado via método, e o novo valor não pode ser menor que o atual. Você quer garantir que essa regra não seja burlada.

//Crie uma classe Funcionario com:
//Uma propriedade pública Nome.
//Um campo privado salario.
//Um construtor que receba nome e salário inicial.
//Um método público ReajustarSalario(double novoValor) que apenas aceite valores maiores que o salário atual.
//Uma propriedade pública de leitura Salario (apenas get).

//Exemplo de entrada:
//Funcionario f = new Funcionario("Fernanda Lima", 4000);
//f.ReajustarSalario(3500); // Inválido
//f.ReajustarSalario(4200); // Válido

//Exemplo de saída:
//Erro: O novo salário deve ser maior que o atual.
//Funcionário: Fernanda Lima
//Salário atual: R$ 4200,00

Funcionario f = new Funcionario("Fernanda Lima", 4000);
f.ReajustarSalario(3500); // Inválido
f.ReajustarSalario(4200); // Válido

Console.WriteLine("Funcionário: " + f.Nome);
Console.WriteLine("Salário atual: R$ " + f.Salario.ToString("F2"));
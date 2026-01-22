//Você está desenvolvendo um sistema interno para uma empresa que deseja organizar as informações de seus colaboradores. A empresa possui funcionários fixos, que recebem salário mensal, e freelancers, que trabalham por projetos com valores específicos. Seu desafio é criar uma estrutura que represente esses dois tipos de colaboradores, aproveitando os conceitos de herança para evitar repetição de código.

//Crie um programa que:
//Defina uma classe base Funcionario com os atributos Nome e Cargo.
//Crie uma classe filha Freelancer que herde de Funcionario e adicione o atributo ValorProjeto.
//Crie uma classe filha Interno que herde de Funcionario e adicione o atributo Salario.
//Instancie pelo menos um objeto de cada classe filha, atribuindo valores a cada atributo.
//Exiba as informações no terminal.

//Exemplo de entrada:
//Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
//Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);

//Saída esperada:
//Funcionária Luciana – Cargo: Desenvolvedora – Salário: R$ 7000,00
//Freelancer Carlos – Cargo: Designer – Projeto atual: R$ 3500,00

Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);

Console.WriteLine($"Funcionária {f1.Nome} – Cargo: {f1.Cargo} – Salário: R$ {f1.Salario}");
Console.WriteLine($"Freelancer {f2.Nome} – Cargo: {f2.Cargo} – Projeto atual: R$ {f2.ValorProjeto}");
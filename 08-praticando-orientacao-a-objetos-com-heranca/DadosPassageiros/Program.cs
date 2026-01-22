//Imagine que você está desenvolvendo um sistema para uma empresa de transporte que precisa gerenciar informações sobre seus passageiros. Cada pessoa cadastrada possui dados básicos, como nome e idade, mas os passageiros também podem informar quantos bilhetes já adquiriram. Seu objetivo é criar uma estrutura que organize essas informações de forma clara e eficiente.

//Crie um programa que:
//Defina uma classe Pessoa com os atributos Nome e Idade.
//Crie a classe Passageiro, herdando de Pessoa, e adicione o atributo QuantidadeBilhetes.
//Implemente um método dentro de Passageiro para exibir os dados formatados no console.
//Cadastre dois passageiros com dados fictícios e exiba suas informações.

//Exemplo de entrada:
//Passageiro p1 = new Passageiro("Lúcia", 45, 3);
//Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

//Saída esperada:
//Passageiro: Lúcia - Idade: 45 - Bilhetes: 3
//Passageiro: Rodrigo - Idade: 30 - Bilhetes: 1

Passageiro p1 = new Passageiro("Lúcia", 45, 3);
Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

p1.ExibirDados();
p2.ExibirDados();
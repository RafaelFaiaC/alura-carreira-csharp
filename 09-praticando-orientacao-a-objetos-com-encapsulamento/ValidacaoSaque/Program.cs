//Imagine que você está desenvolvendo uma aplicação bancária e precisa encapsular o comportamento de um saque de dinheiro.

//Por questões de segurança, a lógica de validação do saque não pode ficar dentro da própria conta, mas deve ser delegada a uma classe interna de segurança, responsável por validar os limites permitidos para a operação.

//Crie:
//Uma classe ContaBancaria, com:
//Propriedade pública Titular
//Campo privado saldo
//Construtor para definir o titular e saldo inicial
//Método público Sacar(double valor) que só realiza o saque se a classe interna de segurança permitir
//Propriedade Saldo (somente leitura)

//Uma classe SegurancaConta (com modificador internal), com:
//Um método ValidarSaque(double valor) que apenas autoriza saques de até R$ 1000

//Exemplo de entrada:
//ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
//conta.Sacar(1500); // inválido
//conta.Sacar(800);  // válido

//Exemplo de saída:
//Saque negado pela política de segurança.
//Saque realizado com sucesso.
//Saldo atual: R$ 1700,00

ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
conta.Sacar(1500); // inválido
conta.Sacar(800);  // válido
Console.WriteLine("Saldo atual: R$ " + conta.Saldo.ToString("F2"));
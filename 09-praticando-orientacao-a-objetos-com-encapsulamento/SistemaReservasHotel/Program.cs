//Imagine que você está desenvolvendo um sistema para um hotel que deseja organizar suas reservas. Ao realizar uma reserva, é necessário associar um hóspede a um quarto, registrar a quantidade de diárias e calcular automaticamente o valor total da estadia. Mas, é importante garantir que:

//A quantidade de diárias seja obrigatoriamente maior que zero;
//O valor da diária do quarto não seja negativo nem nulo;
//O sistema não permita alterações manuais no valor total da reserva.
//Você deve garantir essas regras usando encapsulamento adequado, protegendo os dados e centralizando a lógica de verificação e cálculo dentro das próprias classes.

//Crie:

//Classe Hospede:
//Propriedade pública Nome, definida no construtor

//Classe Quarto:
//Propriedade pública Numero
//Propriedade ValorDiaria, com get e set, validando que o valor seja positivo

//Classe Reserva:
//Campo privado diarias
//Propriedade somente leitura Hospede (objeto)
//Propriedade somente leitura Quarto (objeto)
//Propriedade somente leitura ValorTotal (calculada)
//Construtor que receba Hospede, Quarto e diarias, e valide se as diárias são maiores que zero

//Exemplo de entrada:
//Hospede hospede = new Hospede("Juliana Moura");
//Quarto quarto = new Quarto(101);
//quarto.ValorDiaria = 250;
//Reserva reserva = new Reserva(hospede, quarto, 3);

//Exemplo de saída:
//Reserva para: Juliana Moura
//Quarto: 101
//Valor total: R$ 750,00

Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);

Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
Console.WriteLine("Quarto: " + reserva.Quarto.Numero);
Console.WriteLine("Valor total: R$ " + reserva.ValorTotal.ToString("F2"));
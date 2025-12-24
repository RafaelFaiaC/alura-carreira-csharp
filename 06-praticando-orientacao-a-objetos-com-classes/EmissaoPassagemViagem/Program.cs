//Você está criando um sistema de emissão de passagens para uma agência de viagens. Cada passagem precisa obrigatoriamente conter o nome do passageiro e o destino, definidos no momento da criação.

//Crie uma classe chamada Passagem que tenha:
//Uma propriedade pública Passageiro.
//Uma propriedade pública Destino.
//Um construtor que obrigue o preenchimento dessas informações na criação do objeto.
//Depois, crie uma instância da classe e exiba os dados da passagem.

//Exemplo de entrada:
//Passagem passagem = new Passagem("Lucas Souza", "Paris");

//Exemplo de saída:
//Passageiro: Lucas Souza
//Destino: Paris

Passagem passagem = new Passagem("Lucas Souza", "Paris");

Console.WriteLine("Passageiro: " + passagem.Passageiro);
Console.WriteLine("Destino: " + passagem.Destino);
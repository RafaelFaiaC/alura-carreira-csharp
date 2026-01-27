//Você está criando um sistema de monitoramento de veículos para uma empresa de transporte. A classe Veiculo precisa controlar a velocidade atual, mas a empresa quer garantir que ninguém consiga alterar diretamente esse valor, para evitar fraudes. O valor só pode ser alterado através de um método autorizado.

//Crie uma classe chamada Veiculo que tenha:
//Uma propriedade pública Placa.
//Um campo privado velocidadeAtual.
//Um método público AtualizarVelocidade(double novaVelocidade) que atualize a velocidade.
//Uma propriedade pública de leitura (get) chamada VelocidadeAtual que retorne a velocidade atual.

//Exemplo de entrada:
//Veiculo veiculo = new Veiculo("ABC-1234");
//veiculo.AtualizarVelocidade(72.5);

//Exemplo de saída:
//Veículo: ABC - 1234
//Velocidade atual: 72,5 km / h

Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtualizarVelocidade(72.5);
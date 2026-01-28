//Você está desenvolvendo um simulador para um aplicativo de mobilidade urbana. Os usuários podem escolher diferentes meios de transporte para calcular o tempo estimado de chegada até o destino. O cálculo muda de acordo com o tipo de transporte utilizado:

//Ônibus: tempo estimado = (distância × 2) +5 minutos
//Metrô: tempo estimado = distância + 5 minutos
//Bicicleta: tempo estimado = distância × 4 minutos
//Sua missão é:
//Criar a classe base Transporte, com o método virtual CalcularTempo(int distanciaKm) que retorna um int (minutos).
//Criar as classes Onibus, Metro e Bicicleta, sobrescrevendo esse método com regras diferentes.
//Criar uma lista com diferentes meios de transporte e exibir o tempo estimado de cada um.

//Exemplo de entrada:
//List<Transporte> opcoes = new List<Transporte>
//{
//    new Onibus(),
//    new Metro(),
//    new Bicicleta()
//};

//int distancia = 10;

//foreach (var transporte in opcoes)
//{
//    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
//}

//Exemplo de saída:
//Onibus: 25 min
//Metro: 15 min
//Bicicleta: 40 min

List<Transporte> opcoes = new List<Transporte>
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};

int distancia = 10;

foreach (var transporte in opcoes)
{
    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
}
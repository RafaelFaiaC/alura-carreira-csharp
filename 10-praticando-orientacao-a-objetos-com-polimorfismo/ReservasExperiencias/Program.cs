//Você está desenvolvendo um sistema de reservas para uma agência de turismo. Os clientes podem reservar passeios presenciais, como trilhas e city tours, ou experiências online, como workshops virtuais de culinária ou fotografia.

//O sistema trata todas as reservas como Reserva, mas cada tipo tem um processo diferente ao ser confirmada:
//A reserva presencial deve informar o ponto de encontro.
//A reserva online deve enviar um link de acesso.
//Sua missão é:
//Criar a classe base Reserva, com um método virtual Confirmar().
//Criar as classes ReservaPresencial e ReservaOnline, que sobrescrevem esse método.
//Criar uma lista com diferentes tipos de reserva e processá-las em um foreach, chamando Confirmar().

//Exemplo de entrada:
//List<Reserva> reservas = new List<Reserva>
//{
//    new ReservaPresencial("Trilha na Serra"),
//    new ReservaOnline("Workshop de Culinária Italiana")
//};

//foreach (var reserva in reservas)
//{
//    reserva.Confirmar();
//}

//Exemplo de saída:
//Confirmando reserva presencial: Trilha na Serra
//Ponto de encontro: Praça Central, às 8h
//Confirmando reserva online: Workshop de Culinária Italiana
//Link de acesso enviado por e-mail!

List<Reserva> reservas = new List<Reserva>
{
    new ReservaPresencial("Trilha na Serra"),
    new ReservaOnline("Workshop de Culinária Italiana")
};

foreach (var reserva in reservas)
{
    reserva.Confirmar();
}
class ReservaOnline : Reserva
{
    public ReservaOnline(string titulo) : base(titulo) { }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva online: {Titulo}");
        Console.WriteLine("Link de acesso enviado por e-mail!");
    }
}

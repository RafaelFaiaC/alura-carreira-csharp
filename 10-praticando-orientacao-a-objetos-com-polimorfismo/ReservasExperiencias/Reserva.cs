class Reserva
{
    public string Titulo { get; set; }

    public Reserva(string titulo)
    {
        Titulo = titulo;
    }

    public virtual void Confirmar()
    {
        Console.WriteLine("Confirmando reserva genérica.");
    }
}

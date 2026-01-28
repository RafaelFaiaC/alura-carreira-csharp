class SMS : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}

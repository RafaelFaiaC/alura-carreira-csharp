class Push : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando PUSH: {mensagem}");
    }
}

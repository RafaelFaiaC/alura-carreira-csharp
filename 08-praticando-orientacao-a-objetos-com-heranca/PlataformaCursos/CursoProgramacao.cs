class CursoProgramacao : ICurso
{
    private string titulo;
    private Instrutor instrutor;

    public CursoProgramacao(string titulo, Instrutor instrutor)
    {
        this.titulo = titulo;
        this.instrutor = instrutor;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {titulo}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {titulo} - Instrutor(a): {instrutor.Nome} ({instrutor.Especialidade})");
    }
}

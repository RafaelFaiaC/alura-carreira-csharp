class CursoDesign : ICurso
{
    private string titulo;
    private Instrutor instrutor;

    public CursoDesign(string titulo, Instrutor instrutor)
    {
        this.titulo = titulo;
        this.instrutor = instrutor;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {titulo}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {titulo} - Instrutor: {instrutor.Nome} ({instrutor.Especialidade})\n");
    }
}
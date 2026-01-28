//Imagine que você está desenvolvendo uma plataforma de cursos. Nela, os usuários podem avaliar diferentes tipos de conteúdo: aulas gravadas ou materiais complementares.

//Essas atividades são tratados como Conteudo, mas cada tipo tem informações específicas:
//A aula gravada possui uma duração em minutos.
//O material complementar possui um número de páginas.
//Sua missão é:
//Criar a classe base Conteudo com uma propriedade Titulo e o método virtual ExibirInfo().
//Criar as classes AulaGravada e MaterialComplementar, sobrescrevendo o método ExibirInfo().
//Criar uma lista de Conteudo e, ao percorrê-la, exibir as informações específicas de cada item.

//Exemplo de entrada:
//List<Conteudo> conteudos = new List<Conteudo>
//{
//    new AulaGravada("POO na prática", 45),
//    new MaterialComplementar("Resumo do módulo 2", 12)
//};

//foreach (var conteudo in conteudos)
//{
//    conteudo.ExibirInfo();
//}

//Exemplo de saída.
//Título: POO na prática  
//Duração: 45 min

//Título: Resumo do módulo 2  
//Páginas: 12

List<Conteudo> conteudos = new List<Conteudo>
{
    new AulaGravada("POO na prática", 45),
    new MaterialComplementar("Resumo do módulo 2", 12)
};

foreach (var conteudo in conteudos)
{
    conteudo.ExibirInfo();
}
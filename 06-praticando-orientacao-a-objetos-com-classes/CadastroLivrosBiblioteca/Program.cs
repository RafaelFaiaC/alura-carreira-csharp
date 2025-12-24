//Imagine que você está desenvolvendo uma aplicação para uma biblioteca que precisa cadastrar livros. Cada livro deve ter um título e um autor.

//Crie uma classe chamada Livro que possua duas propriedades públicas: Titulo e Autor. Depois, crie um objeto dessa classe e preencha os dados com um título e autor de sua escolha e exiba a saída.

//Exemplo de entrada:
//meuLivro.Titulo = "Dom Casmurro";
//meuLivro.Autor = "Machado de Assis";

//Exemplo de saída:
//Livro: Dom Casmurro
//Autor: Machado de Assis

Livro meuLivro = new Livro();
meuLivro.Titulo = "Dom Casmurro";
meuLivro.Autor = "Machado de Assis";

Console.WriteLine("Livro: " + meuLivro.Titulo);
Console.WriteLine("Autor: " + meuLivro.Autor);
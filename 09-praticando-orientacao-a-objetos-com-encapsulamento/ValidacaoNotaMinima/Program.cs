//Você está desenvolvendo um sistema de avaliação para uma escola. Um professor só pode atribuir notas maiores ou iguais a 0 e menores ou iguais a 10. Nenhum outro ponto do sistema pode alterar a nota de um aluno diretamente.

//Crie uma classe chamada Avaliacao com:
//Uma propriedade pública Aluno.
//Uma propriedade Nota, com get público e set privado.
//Um método público AtribuirNota(double nota) que só permita valores entre 0 e 10. Se o valor for inválido, exiba uma mensagem de erro.

//Exemplo de entrada:
//Avaliacao avaliacao = new Avaliacao("Carla Silva");
//avaliacao.AtribuirNota(11);   // inválido
//avaliacao.AtribuirNota(8.5);  // válido

//Exemplo de saída:
//Erro: A nota deve estar entre 0 e 10.
//Aluno: Carla Silva
//Nota atribuída: 8,5

Avaliacao avaliacao = new Avaliacao("Carla Silva");
avaliacao.AtribuirNota(11);   // inválido
avaliacao.AtribuirNota(8.5);  // válido

Console.WriteLine("Aluno: " + avaliacao.Aluno);
Console.WriteLine("Nota atribuída: " + avaliacao.Nota);
//Imagine que você está desenvolvendo um placar online para um torneio de games, onde milhares de jogadores competem em tempo real. Para evitar poluição visual e garantir uma experiência limpa aos espectadores, o sistema deve exibir apenas as pontuações únicas, sem repetições, e em ordem crescente.

//Crie um programa que:
//Escolha a melhor estrutura para armazenar os scores.
//Garanta que os dados estejam ordenados.
//Exiba os valores no console.

//Exemplo de entrada:
//scores.Add(150);
//scores.Add(90);
//scores.Add(200);
//scores.Add(120);
//scores.Add(150);
//scores.Add(80);
//scores.Add(180);
//scores.Add(200);

//Saída esperada:
//Scores únicos em ordem crescente:
//80
//90
//120
//150
//180
//200

HashSet<int> scores = new HashSet<int>();

scores.Add(150);
scores.Add(90);
scores.Add(200);
scores.Add(120);
scores.Add(150);
scores.Add(80);
scores.Add(180);
scores.Add(200);

List<int> scoresOrdenados = new List<int>(scores);
scoresOrdenados.Sort();

Console.WriteLine("Scores únicos em ordem crescente:");
foreach (int score in scoresOrdenados)
{
    Console.WriteLine(score);
}
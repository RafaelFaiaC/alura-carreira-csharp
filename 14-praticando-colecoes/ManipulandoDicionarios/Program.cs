//Você está desenvolvendo um sistema de gerenciamento de tarefas para uma equipe de desenvolvimento. Os membros do time podem adicionar suas tarefas diárias, mas, ao final do sprint, todas as tarefas concluídas são removidas do quadro, dando espaço para novas atividades.
//Você é responsável por implementar essa lógica usando um dicionário para armazenar as tarefas e seus responsáveis. O programa deve limpar o dicionário simulando o fim do sprint, adicionar novas tarefas para o próximo ciclo e, por fim, listar todas as atividades atualizadas para a equipe.

//Crie um programa que:
//Inicialize um dicionário com algumas tarefas
//Remova todas as tarefas do dicionário
//Adicione novas tarefas
//Liste as novas tarefas
//Dica: O método Clear() esvazia completamente o dicionário, removendo todos os itens de uma só vez. Isso é útil quando precisamos reiniciar uma coleção sem criar uma nova instância.

//Exemplo de entrada:
//Tarefas antigas:
//Dictionary<string, string> tarefas = new Dictionary<string, string>()
//{
//{ "Refatorar módulo de login", "Ana" },
//{ "Testar API de pagamentos", "Pedro" }
//};

//Novas tarefas:
//tarefas.Add("Implementar autenticação OAuth", "João");
//tarefas.Add("Otimizar consultas SQL", "Maria");
//tarefas.Add("Atualizar documentação", "Carlos");

//Saída esperada:
//Tarefas do próximo sprint:
//-Implementar autenticação OAuth: João
//- Otimizar consultas SQL: Maria
//- Atualizar documentação: Carlos

Dictionary<string, string> tarefas = new Dictionary<string, string>()
{
{ "Refatorar módulo de login", "Ana" },
{ "Testar API de pagamentos", "Pedro" }
};
tarefas.Clear();
tarefas.Add("Implementar autenticação OAuth", "João");
tarefas.Add("Otimizar consultas SQL", "Maria");
tarefas.Add("Atualizar documentação", "Carlos");

Console.WriteLine("Tarefas do próximo sprint:");
foreach (var tarefa in tarefas)
{
    Console.WriteLine($"- {tarefa.Key}: {tarefa.Value}");
}
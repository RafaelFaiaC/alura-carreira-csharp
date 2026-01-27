//Você está desenvolvendo um sistema de gestão de projetos. Cada projeto possui uma lista de tarefas internas, que não pode ser acessada nem modificada diretamente de fora da classe. O sistema só permite adicionar tarefas, e precisa mostrar quantas já existem.

//Crie uma classe Projeto com:
//Uma propriedade pública Nome.
//Uma lista privada de strings chamada tarefas.
//Um método público AdicionarTarefa(string tarefa) que insere uma nova tarefa.
//Um método público ExibirTarefas() que imprime todas as tarefas.
//Uma propriedade somente leitura QuantidadeTarefas, baseada no tamanho da lista.

//Exemplo de entrada:
//Projeto projeto = new Projeto("Sistema de Inventário");
//projeto.AdicionarTarefa("Criar tela de login");
//projeto.AdicionarTarefa("Implementar banco de dados");
//projeto.ExibirTarefas();

//Exemplo de saída:
//Projeto: Sistema de Inventário
//Tarefas:
//-Criar tela de login
//- Implementar banco de dados
//Total: 2 tarefas

Projeto projeto = new Projeto("Sistema de Inventário");
projeto.AdicionarTarefa("Criar tela de login");
projeto.AdicionarTarefa("Implementar banco de dados");
projeto.ExibirTarefas();
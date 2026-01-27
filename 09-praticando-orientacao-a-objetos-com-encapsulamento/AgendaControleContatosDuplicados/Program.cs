//Você está desenvolvendo um sistema de agenda pessoal. Cada agenda pode conter vários contatos, mas você quer garantir que:

//A lista de contatos não possa ser acessada nem modificada diretamente por fora da classe.
//Nenhum contato com o mesmo nome seja adicionado duas vezes.
//O sistema informe se o contato foi adicionado ou recusado, para que outras partes possam reagir.

//Então para isso, crie:
//Uma classe Contato, com:
//Propriedades públicas Nome e Telefone.

//Uma classe Agenda, com:
//Propriedade pública Proprietario.
//Um campo privado e readonly contatos (do tipo List<Contato>).
//Um método público bool AdicionarContato(Contato contato), que verifica se o nome já existe.
//Um método ListarContatos(), que imprime os contatos.
//Uma propriedade pública somente leitura QuantidadeContatos.

//Exemplo de entrada:
//Agenda agenda = new Agenda("Marina Souza");
//agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
//agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
//agenda.AdicionarContato(new Contato("Julia", "21988776655"));
//agenda.ListarContatos();

//Exemplo de saída:
//Contato com esse nome já está na agenda.
//Agenda de: Marina Souza
//Contatos:
//-Carlos | 11998887777
//- Julia | 21988776655
//Total de contatos: 2

Agenda agenda = new Agenda("Marina Souza");
agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();
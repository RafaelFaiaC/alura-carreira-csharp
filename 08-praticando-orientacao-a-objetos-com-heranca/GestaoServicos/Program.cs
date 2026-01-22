//Imagine que você está criando um sistema para uma empresa de tecnologia que oferece diferentes tipos de serviços (como manutenção ou consultoria). Cada serviço tem um responsável técnico (funcionário), e cada tipo de serviço possui sua própria forma de executar a tarefa.

//O objetivo é garantir que todos os serviços possam ser executados de forma padronizada, mas com lógica específica. E, cada serviço deve conter um funcionário responsável.

//Seu desafio é combinar interface e composição para representar essa estrutura.

//Crie um programa que:
//Defina a interface IServico, com o método ExecutarServico().
//Crie a classe Funcionario, com os atributos Nome e Departamento.
//Crie as classes Manutencao e Consultoria, que implementam IServico.
//Em cada classe, associe um Funcionario por composição e implemente o método ExecutarServico() com:
//O tipo do serviço
//O título da tarefa
//E os dados do funcionário responsável.
//No Program.cs, instancie os serviços e chame o método ExecutarServico().

//Exemplo de entrada:
//Funcionario tecnico = new Funcionario("João", "TI");
//IServico s1 = new Manutencao("Atualização de servidor", tecnico);

//Funcionario analista = new Funcionario("Marina", "Consultoria");
//IServico s2 = new Consultoria("Planejamento estratégico", analista);

//s1.ExecutarServico();
//s2.ExecutarServico();

//Saída esperada:
//Executando serviço de manutenção: Atualização de servidor
//Responsável: João - Departamento: TI

//Executando serviço de consultoria: Planejamento estratégico
//Responsável: Marina - Departamento: Consultoria

Funcionario tecnico = new Funcionario("João", "TI");
IServico s1 = new Manutencao("Atualização de servidor", tecnico);

Funcionario analista = new Funcionario("Marina", "Consultoria");
IServico s2 = new Consultoria("Planejamento estratégico", analista);

s1.ExecutarServico();
s2.ExecutarServico();
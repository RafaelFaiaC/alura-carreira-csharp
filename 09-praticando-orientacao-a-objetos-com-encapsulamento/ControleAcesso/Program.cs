//Você está desenvolvendo um sistema de acesso a dados médicos. Informações sensíveis, como um código de prontuário, não devem ser acessadas de fora da aplicação, mas ainda podem ser lidas por classes dentro do mesmo projeto.

//Crie duas classes:
//Paciente(pública), com propriedades públicas Nome e Idade.
//HistoricoMedico (com modificador internal), contendo uma propriedade CodigoProntuario e um método ExibirCodigo() que imprime o código no console.
//No programa principal, crie um paciente e um histórico médico, e exiba os dados.

//Exemplo de entrada:
//Paciente paciente = new Paciente("Luiz Costa", 42);
//HistoricoMedico historico = new HistoricoMedico("XPT-9987");
//historico.ExibirCodigo();

//Exemplo de saída:
//Código do prontuário: XPT - 9987

Paciente paciente = new Paciente("Luiz Costa", 42);
HistoricoMedico historico = new HistoricoMedico("XPT-9987");
historico.ExibirCodigo();
//Imagine que você está desenvolvendo o backend de um painel administrativo com vários botões. Cada botão realiza uma ação específica, como salvar, editar ou excluir dados.

//Você quer permitir que cada ação tenha sua própria lógica.

//Sua missão é:
//Criar a interface IAcaoBotao com o método Executar().
//Criar as classes SalvarAcao, EditarAcao e ExcluirAcao, que implementam essa interface.
//Criar uma lista de ações e executá-las em um foreach.

//Exemplo de entrada:
//List<IAcaoBotao> acoes = new List<IAcaoBotao>
//{
//    new SalvarAcao(),
//    new EditarAcao(),
//    new ExcluirAcao()
//};

//foreach (var acao in acoes)
//{
//    acao.Executar();
//}

//Exemplo de saída:
//Salvando dados no banco...  
//Editando informações do cadastro...  
//Excluindo registro do sistema...

List<IAcaoBotao> acoes = new List<IAcaoBotao>
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};

foreach (var acao in acoes)
{
    acao.Executar();
}
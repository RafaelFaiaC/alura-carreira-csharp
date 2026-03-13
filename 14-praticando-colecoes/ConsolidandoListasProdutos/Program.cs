//Imagine que você é responsável por organizar o inventário de uma loja de eletrônicos. Durante uma atualização de estoque, surgiu a necessidade de unir duas listas de produtos em uma única lista para facilitar a gestão. Seu objetivo é criar um programa que adicione os itens de uma lista secundária à lista principal.

//Crie um programa que:
//Declare duas listas distintas de produtos.
//Adicione todos os elementos da lista secundária na lista principal.
//Exiba a lista principal com todos os produtos.

//Exemplo de entrada:
//List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick”};
//List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad” };

//Saída esperada:
//Lista consolidada:
//Mouse
//Teclado
//Monitor
//Joystick
//Headset
//Webcam
//Smartphone
//Mousepad

List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick" };
List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };

foreach (string produto in produtosSecundaria)
{
    produtosPrincipal.Add(produto);
}

Console.WriteLine("Lista consolidada:");
foreach (string produto in produtosPrincipal)
{
    Console.WriteLine(produto);
}

//Você é responsável por implementar o sistema de autenticação de um aplicativo corporativo. O sistema precisa diferenciar entre administradores, usuários cadastrados e visitantes, garantindo o acesso adequado a cada perfil.

//Crie um programa que:

//Solicite que o usuário digite seu nome
//Verifique se o nome corresponde ao do administrador (ex: "Admin")
//Caso não seja o administrador, exibir uma mensagem de "Usuário não cadastrado" e apresentar um menu com opções:
//Cadastrar novo usuário
//Acessar como convidado
//Sair do sistema
//Exemplo de entrada:

//Sistema de Autenticação
//-----------------------
//Digite seu nome de usuário: Arthur Dent
//Copiar código
//Saída esperada:

//Caso a opção escolhida seja cadastrar novo usuário:

//Usuário não cadastrado.
//Opções disponíveis:
//[1] Cadastrar novo usuário
//[2] Acessar como convidado
//[3] Sair
//1
//Novo usuário 'Arthur Dent' cadastrado com sucesso!
//Copiar código
//Caso a opção escolhida seja entrar como convidado:

//Usuário não cadastrado.
//Opções disponíveis:
//[1] Cadastrar novo usuário
//[2] Acessar como convidado
//[3] Sair
//2
//Acesso concedido como convidado.
//Copiar código
//Caso o usuário esteja cadastrado:

//Bem-vindo, Arthur Dent!Você é responsável por implementar o sistema de autenticação de um aplicativo corporativo. O sistema precisa diferenciar entre administradores, usuários cadastrados e visitantes, garantindo o acesso adequado a cada perfil.

//Crie um programa que:

//Solicite que o usuário digite seu nome
//Verifique se o nome corresponde ao do administrador (ex: "Admin")
//Caso não seja o administrador, exibir uma mensagem de "Usuário não cadastrado" e apresentar um menu com opções:
//Cadastrar novo usuário
//Acessar como convidado
//Sair do sistema
//Exemplo de entrada:

//Sistema de Autenticação
//-----------------------
//Digite seu nome de usuário: Arthur Dent
//Copiar código
//Saída esperada:

//Caso a opção escolhida seja cadastrar novo usuário:

//Usuário não cadastrado.
//Opções disponíveis:
//[1] Cadastrar novo usuário
//[2] Acessar como convidado
//[3] Sair
//1
//Novo usuário 'Arthur Dent' cadastrado com sucesso!

//Caso a opção escolhida seja entrar como convidado:

//Usuário não cadastrado.
//Opções disponíveis:
//[1] Cadastrar novo usuário
//[2] Acessar como convidado
//[3] Sair
//2
//Acesso concedido como convidado.

//Caso o usuário esteja cadastrado:
//Bem-vindo, Arthur Dent!

Console.WriteLine("Sistema de Autenticação");
Console.WriteLine("-----------------------");
Console.Write("Digite seu nome de usuário: ");

string username = Console.ReadLine()!;

if (username == "Admin")
{
    Console.WriteLine($"Bem-vindo, {username}!");
}

else
{
    Console.WriteLine("Usuário não cadastrado.");
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] Cadastrar novo usuário");
    Console.WriteLine("[2] Acessar como convidado");
    Console.WriteLine("[3] Sair");

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Novo usuário '{username}' cadastrado com sucesso!");
            break;

        case 2:
            Console.WriteLine("Acesso concedido como convidado.");
            break;

        case 3:
            Console.WriteLine("Saindo do sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida. O sistema será encerrado.");
            break;
    }
}
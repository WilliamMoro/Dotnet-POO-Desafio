using DesafioPOO.Models;

bool exibirMenu = true;
Console.WriteLine("Seja Bem-Vindo ao VendeCell, selecione sua opção abaixo");

Cadastro cadastro = new Cadastro();

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar um iPhone");
    Console.WriteLine("2 - Ver os iPhones Cadastrados");
    Console.WriteLine("3 - Cadastrar um Nokia");
    Console.WriteLine("4 - Ver os Nokias Cadastrados");
    Console.WriteLine("5 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            cadastro.InserirDados("1");
            break;

        case "2":
            cadastro.CelularesIphoneCadastrados();
            break;

        case "3":
            cadastro.InserirDados("3");
            break;

        case "4":
            cadastro.CelularesNokiaCadastrados();
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine();
    Console.WriteLine("1 - Para registrar uma banda");
    Console.WriteLine("2 - Para mostrar bandas cadastradas");
    Console.WriteLine("3 - Para avaliar uma banda");
    Console.WriteLine("4 - Para exibir a média de uma banda");
    Console.WriteLine("0 - Para sair da aplicação");

    Console.WriteLine();
    Console.Write("Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // O sinal de ! no final do comando diz que não aceito nulo
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break; 
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 0: Console.WriteLine("Tchau Tchau :)");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda a ser registrada: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"Banda {nomeDaBanda} registrada com SUCESSO!!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}


ExibirOpcoesDoMenu();
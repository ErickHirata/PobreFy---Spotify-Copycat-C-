// Screen Sound / PobreFy - Nosso App De Musica

// Registro das Variáveis do Projeto
string mensagemDeBoasVindas = "Boas Vindas ao PobreFy - Nosso App de Música!";

// Declaração de Função
void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
██████╗░░█████╗░██████╗░██████╗░███████╗███████╗██╗░░░██╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝╚██╗░██╔╝
██████╔╝██║░░██║██████╦╝██████╔╝█████╗░░█████╗░░░╚████╔╝░
██╔═══╝░██║░░██║██╔══██╗██╔══██╗██╔══╝░░██╔══╝░░░░╚██╔╝░░
██║░░░░░╚█████╔╝██████╦╝██║░░██║███████╗██║░░░░░░░░██║░░░
╚═╝░░░░░░╚════╝░╚═════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░░░░╚═╝░░░");    // @ --> Serve pra poder Exibir a string Literal
    Console.WriteLine(mensagemDeBoasVindas);                    // @ Verbatin Literal
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("");
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\n Digite sua opção: ");  //Write e não Consolie.WriteLine --> Para não pular linha
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //vai ler o input e pega so int
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 0:
            Console.WriteLine("Saindo do programa...");
            break;

        default:
            Console.WriteLine("Opção inválida. Digite o número da opção desejada.");
            break;
    }
}

//Chamando a Função pra mostrar msg
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
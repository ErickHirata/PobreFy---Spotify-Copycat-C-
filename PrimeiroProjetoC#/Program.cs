// Screen Sound / PobreFy - Nosso App De Musica

// Registro das Variáveis do Projeto
string mensagemDeBoasVindas = "Boas Vindas ao PobreFy - Nosso App de Música!";
List<string> listaDasBandas = new List<string>();

// Logo
void ExibirLogo()
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
    Console.Clear();
    ExibirLogo();

    Console.WriteLine("");
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\n Digite sua opção: ");  //Write e não Consolie.WriteLine --> Para não pular linha

    string opcaoEscolhida = Console.ReadLine()!;            //vai ler o input e pega so int
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); 

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
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

void RegistrarBandas()
{
    Console.Clear(); //Limpa a tela do console
    ExibirLogo();

    Console.WriteLine("\n #REGISTRO DE BANDAS# ");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;       //aqui ele le o INPUT do nomeDaBanda
    listaDasBandas.Add(nomeDaBanda);                //Aqui ele registra a banda na lista de Banda
    Console.WriteLine($"A Banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

//Chamando a Função pra mostrar msg
ExibirOpcoesDoMenu();
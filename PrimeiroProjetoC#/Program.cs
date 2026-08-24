// Screen Sound / PobreFy - Nosso App De Musica

// Registro das Variáveis do Projeto
string mensagemDeBoasVindas = "Boas Vindas ao PobreFy - Nosso App de Música!\n ";
//List<string> listaDasBandas = new List<string>{"One Direction", "The Beatles", "Warriors From The Past", "Metalica", "Imagine Dragons"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>

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
            MostrarBandasRegistradas();
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
    ExibirTituloDaOpcaoMenu("#REGISTRO DE BANDAS#"); 
    
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;       //aqui ele le o INPUT do nomeDaBanda
    listaDasBandas.Add(nomeDaBanda);                //Aqui ele registra a banda na lista de Banda
    Console.WriteLine($"A Banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcaoMenu("#TODAS AS BANDAS REGISTRADAS:#"); 

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    /*for (int i = 0; i < listaDasBandas.Count; i++)       //Enquanto tiver banda (maior q 0) ele vai contar e mostrar as bandas
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    } */

    Console.WriteLine("\n Digite qualquer tecla para sair da Lista de Bandas e voltar para o Menu Principal\n ");
    Console.ReadKey();

    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcaoMenu(string titulo)
{
    int Qt_Letras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(Qt_Letras, '═');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

//Chamando a Função pra mostrar msg
ExibirOpcoesDoMenu();
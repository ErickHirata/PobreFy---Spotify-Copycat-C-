// Screen Sound / PobreFy - Nosso App De Musica

// Registro das Variáveis do Projeto
string mensagemDeBoasVindas = "Boas Vindas ao PobreFy - Nosso App de Música!\n ";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); 
bandasRegistradas.Add("One Direction", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int> { 9, 10, 8 });
bandasRegistradas.Add("Warriors From The Past", new List<int> { 7, 8, 9 });
bandasRegistradas.Add("Metalica", new List<int> { 10, 9, 10 });
bandasRegistradas.Add("Imagine Dragons", new List<int> { 8, 9, 10 });
bandasRegistradas.Add("Capitao Minhoca", new List<int> ());

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
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDeUmaBanda();
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
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
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

    foreach (string banda in bandasRegistradas.Keys)    //Vai pegar as chaves de Nome de banda do Dicionario
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

void AvaliarUmaBanda()
{
    //Digital qual banda será avaliada
    //Verificar se a banda existe no dicionário --> pra poder dar nota
    // Se não volta pro Menu

    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcaoMenu("#AVALIAR BANDA!:#");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece?: ");
        int nota = int.Parse(Console.ReadLine()!);      // pega o que o user deu de nota e converte a string pra int
        bandasRegistradas[nomeDaBanda].Add(nota);       // Pega a lista de notas associada à nomeDaBanda e adiciona a nova nota nela.
        Console.WriteLine($"\nA nota {nota} foi registrada com Sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();

        //Console.WriteLine("Deseja Avaliar mais uma Banda?");

        ExibirOpcoesDoMenu();
    } 
    else 
    {
        Console.Write($"\nA banda {nomeDaBanda} não foi Encontrada no cadastro e por isso não pode receber uma avaliação");
        Console.WriteLine("\n Digite qualquer Tecla para Pesquisar outro nome pra avaliar outra banda");
        Console.ReadKey();
        Console.Clear();
        AvaliarUmaBanda();
    }

}

void ExibirMediaDeUmaBanda()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcaoMenu("#Exibir Média Da Banda:#");

    Console.Write("Digite o nome da banda que deseja ver a Média de Nota: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite qualquer tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.Write($"\nA banda {nomeDaBanda} não foi Encontrada no cadastro e por isso não Há como mostrar a nota");
        Console.WriteLine("\n Digite qualquer Tecla para Pesquisar outro nome pra consultar a nota da banda");
        Console.ReadKey();
        Console.Clear();
        ExibirMediaDeUmaBanda();
    }
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
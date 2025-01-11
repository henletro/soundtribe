string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Angra", new List<int> { 10, 9, 5 });
bandasRegistradas.Add("Rhapsody Of Fire", new List<int> { 10, 8, 9 });

void ExibirLogo()
{
    Console.WriteLine(@"
███████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀███─▄─▄─█▄─▄▄▀█▄─▄█▄─▄─▀█▄─▄▄─█
█▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█████─████─▄─▄██─███─▄─▀██─▄█▀█
▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▀▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▄▄▄▀
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite [1] para registrar uma banda");
    Console.WriteLine("Digite [2] para mostrar todas as bandas");
    Console.WriteLine("Digite [3] para avaliar uma banda");
    Console.WriteLine("Digite [4] para exibir a média de uma banda");
    Console.WriteLine("Digite [0] para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica >= 0 && opcaoEscolhidaNumerica < 5)
    {
        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                MostrarBandasRegistradas();
                break;
            case 3:
                AvaliarUmaBanda();
                break;
            case 4:
                ExibirMediaDaBanda();
                break;
            case 0:
                Console.Clear();
                Console.WriteLine(@"
▄▀█ ▀█▀ █▀▀   ▄▀█   █▀█ █▀█ █▀█ ▀▄▀ █ █▀▄▀█ ▄▀█
█▀█ ░█░ ██▄   █▀█   █▀▀ █▀▄ █▄█ █░█ █ █░▀░█ █▀█");
                break;

        }
    }

    while (opcaoEscolhidaNumerica < 0 || opcaoEscolhidaNumerica > 4 )
    {
        Console.Clear();
        Console.WriteLine(@"
█▀▄ █ █▀▀ █ ▀█▀ █▀▀   █░█ █▀▄▀█ ▄▀█   █▀█ █▀█ █▀▀ ▄▀█ █▀█   █░█ ▄▀█ █░░ █ █▀▄ ▄▀█ ▀
█▄▀ █ █▄█ █ ░█░ ██▄   █▄█ █░▀░█ █▀█   █▄█ █▀▀ █▄▄ █▀█ █▄█   ▀▄▀ █▀█ █▄▄ █ █▄▀ █▀█ ▄");
        Thread.Sleep(1500);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro Das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Console.Write("[1] Para registrar outra banda [2] Para voltar para o menu: ");
    int seletor = int.Parse(Console.ReadLine()!);

    while (true)
    {
        if (seletor == 1)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro Das Bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.Write("[1] Para registrar outra banda [2] Para voltar para o menu: ");
            seletor = int.Parse(Console.ReadLine()!);

        }

        else if (seletor == 2)
        {
            Console.Clear();
            Console.WriteLine("Voltando ao menu...");
            Thread.Sleep(1500);
            Console.Clear();
            break;

        }

        else
        {
            Console.Clear();
            Console.Write(@"
█▀▄ █ █▀▀ █ ▀█▀ █▀▀   █░█ █▀▄▀█ ▄▀█   █▀█ █▀█ █▀▀ ▄▀█ █▀█   █░█ ▄▀█ █░░ █ █▀▄ ▄▀█ ▀
█▄▀ █ █▄█ █ ░█░ ██▄   █▄█ █░▀░█ █▀█   █▄█ █▀▀ █▄▄ █▀█ █▄█   ▀▄▀ █▀█ █▄▄ █ █▄▀ █▀█ ▄
");
            Thread.Sleep(1500);
            Console.Clear();
            Console.Write("[1] Para registrar outra banda [2] Para voltar para o menu: ");
            seletor = int.Parse(Console.ReadLine()!);
            Console.Clear();
        }
    }
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("");
    Console.Write("Digite uma tecla para voltar para o menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2300);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Precione uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Media das bandas");
    Console.Write("Digite a banda que você deseja saber a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.Write("Digite uma tecla para voltar para o menu inicial: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Precione uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
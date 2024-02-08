//Criar um programa que permita ao usuário inserir o nome do aluno e suas notas, e em seguida calcule e exiba a média das notas.

//Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

//notasAlunos["Alex"] = new List<double> { 9.0, 9.0, 9.0 };
//notasAlunos["Bia"] = new List<double> { 7.0, 8.0, 6.5 };

//foreach (var aluno in notasAlunos)
//{
//    double soma = 0;
//    for (int i = 0; i < aluno.Value.Count; i++)
//    {
//        soma += aluno.Value[i];
//    }
//    double media = soma / aluno.Value.Count;
//    Console.WriteLine($"Média de {aluno.Key}: {media}");
//}


//Criar um programa que gerencie o estoque de uma loja.
//Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

//Dictionary<string, int> estoque = new Dictionary<string, int>
//{
//    {"camisetas", 50 },
//    {"Calças", 30 },
//    {"Tênis", 20 }
//};

//string produto = "Calças";

//if (estoque.ContainsKey(produto))
//{
//    Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
//}
//else
//{
//    Console.WriteLine("Produto não encontrado no estoque.");
//}

//Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.

//Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
//{
//    {"Qual é a capital do Brasil?", "Brasília" },
//    {"Quanto é 10 vezes 5?", "50" },
//    {"Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
//};

//int pontuacao = 0;

//foreach (var pergunta in perguntasERespostas)
//{
//    Console.WriteLine(pergunta.Key);
//    Console.WriteLine("Sua resposta: ");
//    string respostaUsuario = Console.ReadLine();

//    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
//    {
//        Console.WriteLine("Correto!\n");
//        pontuacao++;
//    } 
//    else
//    {
//        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
//    }
//}

//Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");

//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

//Dictionary<string, string> usuarios = new Dictionary<string, string>
//{
//    {"user1","senha123" },
//    {"user2", "abc456" },
//};

//string nomeUsario = "user1";
//string senha = "senha123";

//if (usuarios.ContainsKey(nomeUsario) && usuarios[nomeUsario] == senha)
//{
//    Console.WriteLine("Login bem-sucedido");
//}
//else
//{
//    Console.WriteLine("Nome de usuário ou senha incorreta");
//}


// Calcular média dos carros vendidos abaixo, apenas uma chave específica

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};


//foreach (var carro in vendasCarros.Keys)
//{
//    Console.WriteLine($"O carro {carro} vendeu: {MostrarMedia}");
//}


double mediaVendasFerrari = vendasCarros["Ferrari LaFerrari"].Average();
Console.WriteLine("Média de vendas da Ferrati LaFerrari: " + mediaVendasFerrari);


//void MostrarMedia()
//{
//    foreach (var carro in vendasCarros)
//    {
//        int soma = 0;
//        for (int i = 0; i < carro.Value.Count; i++)
//        {
//            soma += carro.Value[i];
//        }
//        int media = soma / carro.Value.Count;
//        Console.WriteLine(media);
//    }
//}

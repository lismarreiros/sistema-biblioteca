using sis_biblioteca;

Biblioteca biblioteca = new Biblioteca();
var arrayLivros = new List<Livro>();
Livro livro1 = new Livro(1, "O Grande Gatsby");
Livro livro2 = new Livro(2, "Dom Casmurro");
Livro livro3 = new Livro(3, "Misery");
Livro livro4 = new Livro(4, "It A Coisa");
Livro livro5 = new Livro(5, "O Conde de Monte Cristo");
Livro livro6 = new Livro(6, "Percy Jackson e o Ladrão de Raios");
Livro livro7 = new Livro(7, "Harry Potter e o Cálice de Fogo");
Livro livro8 = new Livro(8, "O Hobbit");
Livro livro9 = new Livro(9, "Harry Potter e a Pedra Filosofal");
Livro livro10 = new Livro(10, "Crepúsculo");
arrayLivros.AddRange(new List<Livro> { 
    livro1, livro2, livro3, livro4, livro5, 
    livro6, livro7, livro8, livro9, livro10 
});
foreach (var livro in arrayLivros)
{
    biblioteca.CadastroLivro(livro);
}

// biblioteca.ListarLivros();

Console.WriteLine("Bem vindo a Biblioteca Ponei!");
Console.WriteLine("Por favor, registre o locatário");
Console.WriteLine("Digite o seu nome:");
string usuarioNome = Console.ReadLine().Trim();

Pessoa pessoa = new Pessoa(1, usuarioNome);
Console.WriteLine("Pessoas cadastradas >>>> ");
foreach (var p in biblioteca.pessoas)
{
    Console.WriteLine(p.nome);
}
biblioteca.CadastroPessoa(pessoa);

var menu = """
           Escolha uma opção:
           1 - Listar todos os livros 
           2 - Emprestar livro
           3 - Sair
           """;

Console.WriteLine(menu);
int opcaoEscolhida = int.Parse(Console.ReadLine());
while (opcaoEscolhida != 3)
{
    if (opcaoEscolhida == 1)
    {
        biblioteca.ListarLivros();
        Console.WriteLine(menu);
        opcaoEscolhida = int.Parse(Console.ReadLine());
    } else if (opcaoEscolhida == 2)
    {
        Console.WriteLine("Digite o id do livro escolhido:");
        int idLivroEscolhido = int.Parse(Console.ReadLine());
        var livroEncontrado = biblioteca.livros.Find(x => x.id == idLivroEscolhido);
        if (livroEncontrado != null)
        {
            biblioteca.EmprestarLivro(livroEncontrado, pessoa);
            Console.WriteLine(menu);
            opcaoEscolhida = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Erro!");
            return;
        }
    } 
}



// greatGatsby.Emprestar("José");

// testes da classe Livro!
// Console.WriteLine($"{greatGatsby.titulo} - status: {greatGatsby.status}");
// Console.WriteLine($"{domCasmurro.titulo} - status: {domCasmurro.status}");
        
// domCasmurro.Emprestar("Camille");
// greatGatsby.Devolver();
// Console.WriteLine($"locatário(?): {greatGatsby.locatario}");
//
// Pessoa maria = new Pessoa(1, "Maria");
// Pessoa joao = new Pessoa(2, "João");

// pessoa.PegarLivro(greatGatsby);
// pessoa.PegarLivro(domCasmurro);

// Console.WriteLine($"teste: {greatGatsby.status}");

// biblioteca.CadastroLivro(greatGatsby);
// biblioteca.CadastroLivro(domCasmurro);
// biblioteca.CadastroPessoa(maria);
// biblioteca.CadastroPessoa(joao);
//
// biblioteca.ListarLivros();
// biblioteca.EmprestarLivro(greatGatsby, maria);
// Console.WriteLine($"Livro {greatGatsby.titulo} está {greatGatsby.status}, pois {greatGatsby.locatario} pegou emprestado");
// greatGatsby.Devolver();
// biblioteca.DevolverLivro(greatGatsby, maria);
// // Console. WriteLine($"Livro {greatGatsby.titulo} está {greatGatsby.status}, pois {maria.nome} já devolveu!");
//
// biblioteca.EmprestarLivro(domCasmurro, maria);
// Console.WriteLine("Livros da Maria: ");
// foreach (var livro in maria.livros)
// {
//     Console.WriteLine(livro.titulo);
// }

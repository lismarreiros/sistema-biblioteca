using sis_biblioteca;

Livro greatGastby = new Livro(1, "Great Gatsby");
Livro domCasmurro = new Livro(2, "Dom Casmurro");
// greatGastby.Emprestar("José");

// testes da classe Livro!
// Console.WriteLine($"{greatGastby.titulo} - status: {greatGastby.status}");
// Console.WriteLine($"{domCasmurro.titulo} - status: {domCasmurro.status}");
        
// domCasmurro.Emprestar("Camille");
// greatGastby.Devolver();
// Console.WriteLine($"locatário(?): {greatGastby.locatario}");

Pessoa maria = new Pessoa(1, "Maria");
Pessoa joao = new Pessoa(2, "João");

// pessoa.PegarLivro(greatGastby);
// pessoa.PegarLivro(domCasmurro);

// Console.WriteLine($"teste: {greatGastby.status}");

Biblioteca biblioteca = new Biblioteca();
biblioteca.CadastroLivro(greatGastby);
biblioteca.CadastroLivro(domCasmurro);
biblioteca.CadastroPessoa(maria);
biblioteca.CadastroPessoa(joao);

biblioteca.ListarLivros();
biblioteca.EmprestarLivro(greatGastby, maria);
Console.WriteLine($"Livro {greatGastby.titulo} está {greatGastby.status}, pois {greatGastby.locatario} pegou emprestado");
// greatGastby.Devolver();
// biblioteca.DevolverLivro(greatGastby, maria)
// Console.WriteLine($"Livro {greatGastby.titulo} está {greatGastby.status}, pois {maria.nome} já devolveu!");

biblioteca.EmprestarLivro(domCasmurro, maria);
Console.WriteLine("Livros da Maria: ");
foreach (var livro in maria.livros)
{
    Console.WriteLine(livro.titulo);
}

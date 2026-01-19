using sis_biblioteca;

Livro greatGastby = new Livro(1, "Great Gatsby");
Livro domCasmurro = new Livro(2, "Dom Casmurro");
// greatGastby.Emprestar("José");

// testes da classe Livro!
Console.WriteLine($"{greatGastby.titulo} - status: {greatGastby.status}");
Console.WriteLine($"{domCasmurro.titulo} - status: {domCasmurro.status}");
        
// domCasmurro.Emprestar("Camille");
greatGastby.Devolver();
Console.WriteLine($"locatário(?): {greatGastby.locatario}");

Pessoa pessoa = new Pessoa(1, "Maria");

pessoa.PegarLivro(greatGastby);
pessoa.PegarLivro(domCasmurro);

Console.WriteLine($"teste: {greatGastby.status}");
    
greatGastby.Emprestar("maria");
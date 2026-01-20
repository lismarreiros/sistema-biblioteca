namespace sis_biblioteca;

public class Biblioteca
{
    public List<Livro> livros = new List<Livro>();
    public List<Pessoa> pessoas = new List<Pessoa>();

    public void CadastroLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void CadastroPessoa(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
    }
    
    public void ListarLivros()
    {
        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.id} | {livro.titulo} - status: {livro.status}");
        }    
    }

    public void EmprestarLivro(Livro livro, Pessoa pessoa)
    {
        livro.Emprestar(pessoa.nome);
        pessoa.PegarLivro(livro);
    }
    
    public void DevolverLivro(Livro livro, Pessoa pessoa)
    {
        livro.Devolver();
        pessoa.DevolverLivro(livro);
    }
    
}
namespace sis_biblioteca;

public class Pessoa
{
    public int id { get; set; }
    public string nome { get; set; }
    public List<Livro> livros { get; set; }

    public Pessoa(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
        livros = new List<Livro>();
    }

    public void PegarLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"{livro} adicionado com sucesso.");
    }

    public void DevolverLivro(Livro livro)
    {
        livros.Remove(livro);
        Console.WriteLine($"{livro} removido com sucesso.");
    }
}
namespace sis_biblioteca;

public class Livro
{
    public int id {get; set; }
    public string titulo {get; set; }
    public string status {get; set; }
    public string locatario {get; set; } = null!;

    public Livro (int Id, string Titulo)
    {
        id = Id;
        titulo = Titulo;
        status = "Disponível";
    }

    public void Emprestar(string nomeLocatario)
    {
        if (status.Equals("Disponível"))
        {
            locatario = nomeLocatario ;
            status = "Emprestado";
            Console.WriteLine($"{titulo} foi emprestado com sucesso para {locatario}");
        }
        else
        {
            Console.WriteLine("Livro indisponível para empréstimo.");
        }
        
    }

    public void Devolver()
    {
        locatario = "";
        Console.WriteLine($"{titulo} foi devolvido!");
        status = "Disponível";
    }
}
namespace ScreenSound2.Modelos;


internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public int Duracao { get; set; }
    public Banda Artista { get; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Diponivel no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}
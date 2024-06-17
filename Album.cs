class Album
{
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => listaDeMusicas.Sum(msc => msc.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        listaDeMusicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine($"{musica.Nome}");
        }
        Console.WriteLine($"Duração total do álbum (em segundos): {DuracaoTotal}");
    }
}
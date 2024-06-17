class Banda
{
    private List<Album> discografia = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        discografia.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia de {Nome}");
        foreach(Album album in discografia)
        {
            Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal} segundos)");
        }
    }
}

Banda djonga = new Banda("Djonga");

Album albumDoDjonga = new Album("O Dono do Lugar");

Musica musica1 = new Musica(djonga, "conversa com uma menina branca")
{
    Duracao = 100,
    Disponivel = false,
};

Musica musica2 = new Musica(djonga, "tôbem")
{
    Duracao = 200,
    Disponivel = true,
};


albumDoDjonga.AdicionarMusica(musica1);
albumDoDjonga.AdicionarMusica(musica2);
djonga.AdicionarAlbum(albumDoDjonga);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoDjonga.ExibirMusicasDoAlbum();
djonga.ExibirDiscografia();

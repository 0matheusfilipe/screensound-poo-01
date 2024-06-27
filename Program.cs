Banda djonga = new Banda("Djonga");

Musica msc1 = new Musica(djonga, "HAT TRICK")
{
    Duracao = 258,
    Disponivel = true,
};
Musica msc2 = new Musica(djonga, "BENÉ")
{
    Duracao = 228,
    Disponivel = true,
};
Musica msc3 = new Musica(djonga, "LEAL")
{
    Duracao = 212,
    Disponivel = true,
};
Musica msc4 = new Musica(djonga, "DEUS E O DIABO NA TERRA DO SOL")
{
    Duracao = 387,
    Disponivel = true,
};
Musica msc5 = new Musica(djonga, "TIPO")
{
    Duracao = 229,
    Disponivel = true,
};
Musica msc6 = new Musica(djonga, "LADRÃO")
{
    Duracao = 262,
    Disponivel = true,
};
Musica msc7 = new Musica(djonga, "BENÇA")
{
    Duracao = 224,
    Disponivel = true,
};
Musica msc8 = new Musica(djonga, "VOZ")
{
    Duracao = 312,
    Disponivel = true,
};
Musica msc9 = new Musica(djonga, "MLK 4TR3V1D0")
{
    Duracao = 75,
    Disponivel = false,
};
Musica msc10 = new Musica(djonga, "FALCÃO")
{
    Duracao = 222,
    Disponivel = true,
};
Musica msc11 = new Musica(djonga, "conversa com uma menina branca")
{
    Duracao = 100,
    Disponivel = false,
};
Musica msc12 = new Musica(djonga, "tôbem")
{
    Duracao = 200,
    Disponivel = true,
};

Album LADRÃO = new Album("Ladrão");
LADRÃO.AdicionarMusica(msc1);
LADRÃO.AdicionarMusica(msc2);
LADRÃO.AdicionarMusica(msc3);
LADRÃO.AdicionarMusica(msc4);
LADRÃO.AdicionarMusica(msc5);
LADRÃO.AdicionarMusica(msc6);
LADRÃO.AdicionarMusica(msc7);
LADRÃO.AdicionarMusica(msc8);
LADRÃO.AdicionarMusica(msc9);
LADRÃO.AdicionarMusica(msc10);
djonga.AdicionarAlbum(LADRÃO);

Album oDonoDoLugar = new Album("O Dono do Lugar");
oDonoDoLugar.AdicionarMusica(msc11);
oDonoDoLugar.AdicionarMusica(msc12);
djonga.AdicionarAlbum(oDonoDoLugar);

msc1.ExibirFichaTecnica();
msc2.ExibirFichaTecnica();
msc3.ExibirFichaTecnica();
msc4.ExibirFichaTecnica();
msc5.ExibirFichaTecnica();
msc6.ExibirFichaTecnica();
msc7.ExibirFichaTecnica();
msc8.ExibirFichaTecnica();
msc9.ExibirFichaTecnica();
msc10.ExibirFichaTecnica();
msc11.ExibirFichaTecnica();
msc12.ExibirFichaTecnica();
LADRÃO.ExibirMusicasDoAlbum();
oDonoDoLugar.ExibirMusicasDoAlbum();
djonga.ExibirDiscografia();

Console.WriteLine();

Episodio ep1 = new(4, "A Melhor Forma de Aprender a Programar", 45);
ep1.AdicionarConvidado("Dev Erik");

Episodio ep2 = new(2, "Aprendendo a programar só pelo dinheiro?", 78);
ep2.AdicionarConvidado("Pedro Torres");

Episodio ep3 = new(3, "A Carreira de Engenheiro de Software", 87);
ep3.AdicionarConvidado("Prof. Fábio Martinez");

Episodio ep0 = new(1, "Faculdade pra programar?", 93);
ep0.AdicionarConvidado("Não Consta.");

Podcast podcast = new("Chat dos Devs", "Micael Mota");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.AdicionarEpisodio(ep0);

podcast.ExibirDetalhes();

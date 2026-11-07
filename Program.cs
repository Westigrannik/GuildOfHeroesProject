Game Undertale = new Game("Undertale", "RPG", 2015);
Game Ferma = new Game("Весёлая ферма", "time management", 2007);
Game SSFE = new Game("Serious Sam First Encounter", "Shooter", 2001);

Catalog catalog = new Catalog("Библиотека Staem");

catalog.Games.Add(Undertale);
catalog.Games.Add(Ferma);
catalog.Games.Add(SSFE);

if (catalog.Games.Count > 0) {
    Console.WriteLine($"Первая игра: {catalog.Games[0].Name}");
    Console.WriteLine($"Последняя игра: {catalog.Games[catalog.Games.Count - 1].Name}");
}

foreach (Game game in catalog.Games)
{
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}

Game ETG = new Game("Enter The Gungeon", "Roguelike", 2016);
catalog.Games.Add(ETG);

Console.WriteLine($"Первая игра: {catalog.Games[0].Name}");
Console.WriteLine($"Последняя игра: {catalog.Games[catalog.Games.Count - 1].Name}");

int cc = 0;
foreach (Game game in catalog.Games)
{
    if (game.Year > 2010) { cc++; }
}
Console.WriteLine($"Количество игр, которые вышли позже 2010: {cc}");

Undertale.Rate(11);
foreach (Game game in catalog.Games)
{
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}
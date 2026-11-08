Game Undertale = new Game("Undertale", "RPG", 2015);
Game Ferma = new Game("Весёлая ферма", "time management", 2007);
Game SSFE = new Game("Serious Sam First Encounter", "Shooter", 2001);
Game ETG = new Game("Enter The Gungeon", "Roguelike", 2016);

Catalog catalog = new Catalog("Библиотека Staem");

catalog.AddGame(Undertale);
catalog.AddGame(Ferma);
catalog.AddGame(SSFE);
catalog.AddGame(ETG);
List<Game> Folder = catalog.GetGames();

if (Folder.Count > 0) {
    Console.WriteLine($"Первая игра: {Folder[0].Name}");
    Console.WriteLine($"Последняя игра: {Folder[Folder.Count - 1].Name}");
}

foreach (Game game in Folder)
{
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}

// |||||||||

Game? found = catalog.FindGame(" UNDERtale ");
if (found != null) {
    Console.WriteLine($"Найдена игра по запросу « UNDERtale »: {found.Name}");
} else {
    Console.WriteLine("По запросу « UNDERtale » ничего нет.");
}

Game? found1 = catalog.FindGame(" volgu ");
if (found1 != null) {
    Console.WriteLine($"Найдена игра по запросу « volgu »: {found1.Name}");
} else {
    Console.WriteLine("По запросу « volgu » ничего нет.");
}

Console.WriteLine();

catalog.AddGame(ETG);
Console.WriteLine(catalog.RemoveGame("Волгу"));
Console.WriteLine(catalog.GameCount);

// |||||||||

Console.WriteLine($"Первая игра: {Folder[0].Name}");
Console.WriteLine($"Последняя игра: {Folder[Folder.Count - 1].Name}");
Console.WriteLine($"Количество игр, которые вышли позже 2010: {catalog.CountByYear(2010)}");

foreach (Game game in Folder)
{
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}
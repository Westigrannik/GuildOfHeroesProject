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

// foreach (Game game in Folder)
// {
//     Console.WriteLine(game.GetInfo());
//     Console.WriteLine();
// }

ReviewBlock block = new ReviewBlock(catalog);
Review IGN = new Review(1, "Ревью от Игрового журналиста", 20);
Console.WriteLine($"Ревью добавлено: {block.AddReview(IGN)}");
Console.WriteLine($">>> №{IGN.Id}: {IGN.Title} <<<");

Console.WriteLine($"Назначение Андертейла: {block.TryAssign(1, " undertale ")}");
Game? assigned = IGN.AssignedGame;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Рейтинг после назначения: {Undertale.Rating}");

Console.WriteLine($"Завершение: {block.TryWin(1)}");
Console.WriteLine($"Опыт после завершения: {Undertale.Rating}");
Console.WriteLine($"Повторное завершение: {block.TryWin(1)}");
Console.WriteLine($"Опыт после повтора: {Undertale.Rating}");
Console.WriteLine();

Console.WriteLine(IGN.GetInfo());
Console.WriteLine(Undertale.GetInfo());
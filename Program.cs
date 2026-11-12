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
Review review1 = new Review(1, "Ревью от Игрового журналиста", 20);
Review review2 = new Review(2, "Обзор от стримера", 50);
block.AddReview(review1);
block.AddReview(review2);

Console.WriteLine($"Ревью 1: {block.TryAssign(1, "Undertale")}");
Console.WriteLine($"Ревью 2: {block.TryAssign(2, "Undertale")}");
block.TryCancel(1);
Console.WriteLine($"Ревью 2 (после отмены первого): {block.TryAssign(2, "Undertale")}");
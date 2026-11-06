Game Undertale = new Game("Undertale", "RPG", 2015);
Game Ferma = new Game("Весёлая ферма", "time management", 2007);
Game SSFE = new Game("Serious Sam First Encounter", "Shooter", 2001);



Console.WriteLine(Undertale.GetInfo());
Console.WriteLine();
Console.WriteLine(Ferma.GetInfo());
Console.WriteLine();
Console.WriteLine(SSFE.GetInfo());
Console.WriteLine();

Undertale.Rate(10);
Ferma.Rate(-10);
SSFE.Rate(100);

Console.WriteLine(Undertale.GetInfo());
Console.WriteLine();
Console.WriteLine(Ferma.GetInfo());
Console.WriteLine();
Console.WriteLine(SSFE.GetInfo());
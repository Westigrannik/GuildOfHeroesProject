public class Catalog {
    public List<Game> _Games = new List<Game>();
    public string Name { get; private set; }
    public int GameCount {
        get {return _Games.Count; }
    }

    public Catalog(string name) {
        Name = name;
    }

    public bool AddGame(Game game) {
    if (FindGame(game.Name) != null) {
        return false;
    }

    _Games.Add(game);
    return true;
    }

    public bool RemoveGame(string name) {
    Game? game = FindGame(name);
    if (game == null) {
        return false;
    }
    return _Games.Remove(game);
    }


    public Game? FindGame(string name) {
    if (string.IsNullOrWhiteSpace(name)) {
        return null;
    }

    string searchName = name.Trim();

    foreach (Game game in _Games) {
        if (string.Equals(game.Name, searchName, StringComparison.OrdinalIgnoreCase)) {
            return game;
        }
        }
    return null;
    }


    public int CountByYear(int minimum) {
        int cc = 0;
        foreach (Game game in _Games) {
            if (game.Year >= minimum) { cc++; }
        }
        return cc;
    }


    public List<Game> GetGames() {
        List<Game> result = new List<Game>();
        foreach (Game game in _Games) {
            result.Add(game);
        }
        return result;
        }
}



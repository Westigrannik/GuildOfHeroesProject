public class Review {
    public int Id { get; private set; }
    public string Title { get; private set; }
    public int WinRate { get; private set; }
    public Game? AssignedGame { get; private set; }
    public bool IsSuccessfull { get; private set; }

    public Review(int id, string title, int winrate) {
        Id = id;

        if (string.IsNullOrWhiteSpace(title)) {
            Title = "Безымянный ревью";
        } else {
            Title = title.Trim();
        }

        WinRate = winrate;
        if (WinRate < 1) {
            WinRate = 1;
        }

        AssignedGame = null;
        IsSuccessfull = false;
    }


public bool TryAssign(Game game) {
    if (IsSuccessfull) {
        return false;
    }
    if (AssignedGame != null) {
        return false;
    }

    AssignedGame = game;
    return true;
}

public bool TryWin() { // ЭТО ЯВЛЯЕТСЯ TRYFINISH
    if (IsSuccessfull) {
        return false;
    }
    Game? game = AssignedGame;
    if (game == null) {
        return false;
    }

    Random rnd = new Random();
    int chance = rnd.Next(1, 100);
    if (chance < 60) {
        return false;
    }
    if (!game.canRate(WinRate)) {
        return false;
    }

    game.Rate(WinRate);
    IsSuccessfull = true;
    return true;
}

    // пусть гетифно тоже будет тут \/ \/ \/
    public string GetInfo() {
        string text = "не назначен";
        if (AssignedGame != null) {
            text = AssignedGame.Name;
        }
        string textcomplete = "нет";
        if (IsSuccessfull) {
            textcomplete = "да";
        }

        return $"№{Id} «{Title}»: Игра {text}, Прошла проверку: {textcomplete}";
    }


}
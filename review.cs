public class Review {
    public int Id { get; private set; }
    public string Title { get; private set; }
    public int WinRate { get; private set; }
    public Game? AssignedGame { get; private set; }
    public ReviewStatus Status { get; private set; }

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
        Status = ReviewStatus.Open;
    }


public bool TryAssign(Game game) {
    if (Status != ReviewStatus.Open) {
        return false;
    }
    if (AssignedGame != null) {
        return false;
    }

    AssignedGame = game;
    Status = ReviewStatus.Assigned;
    return true;
}

public bool TryWin() { // ЭТО ЯВЛЯЕТСЯ TRYFINISH
    if (Status != ReviewStatus.Assigned) {
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
    Status = ReviewStatus.Done;
    return true;
    }

    public bool TryCancel() {
    if (Status != ReviewStatus.Open && Status != ReviewStatus.Assigned) {
        return false;
    }

    Status = ReviewStatus.Cancelled;
    return true;
}


    public string GetStatusText() {
    switch (Status) {
        case ReviewStatus.Open:
            return "открыто";
        case ReviewStatus.Assigned:
            return "назначено";
        case ReviewStatus.Done:
            return "Прошло";
        case ReviewStatus.Cancelled:
            return "отменено";
        default:
            return "неизвестно";
        }
    }   


    // пусть гетифно тоже будет тут \/ \/ \/
    public string GetInfo() {
        string text = "не назначен";
        if (AssignedGame != null) {
            text = AssignedGame.Name;
        }

        return $"№{Id} «{Title}»: Игра {text}: {GetStatusText()}";
    }


}
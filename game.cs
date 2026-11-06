public class Game {
    private string _name = "Неизвестная игра";
    public string Name {
        get {
        return _name;
    }
        private set {
        if (string.IsNullOrWhiteSpace(value)) {
            _name = "Неизвестная игра";
            return;
        }
        _name = value.Trim();
    }
}
    public string Category { get; private set; }
    public int Year { get; private set; }
    public int Rating { get; private set; }

    public Game(string name, string category, int year) {
        Name = name;
        Category = category;
        Year = year;
        Rating = 1;
    }
// ||||| Рейтинг
    public void Rate(int rt){
        if ((Rating + rt > 100) || (Rating + rt < 0)) {
            return;
        }
        Rating += rt;
    }
// ||||| Инфа
    public string GetInfo(){
        return $">>> {Name} <<<\n" +
                $">>> {Category} <<<\n" +
                $">>> {Year} <<<\n" +
                $">>> {Rating} <<<";
    }
}
public class Game {
    public string Name;
    public string Category;
    public int Year;
    public int Rating;

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
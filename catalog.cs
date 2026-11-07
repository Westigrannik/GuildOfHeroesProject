public class Catalog {
    public string Name { get; private set; }
    public List<Game> Games { get; private set; } = new List<Game>();

    public Catalog(string name) {
        Name = name;
    }
}
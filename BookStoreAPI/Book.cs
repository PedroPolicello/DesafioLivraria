namespace BookStoreAPI;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Genres Genre { get; set; }
    public double Price { get; set; }
    public int AmoutInStock { get; set; }
}

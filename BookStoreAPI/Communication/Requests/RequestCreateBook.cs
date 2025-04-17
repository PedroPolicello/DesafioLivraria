namespace BookStoreAPI.Communication.Requests;

public class RequestCreateBook
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Genres Genre { get; set; }
    public double Price { get; set; }
}

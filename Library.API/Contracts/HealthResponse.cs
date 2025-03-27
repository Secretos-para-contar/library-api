namespace Library.API.Contracts;

public class HealthResponse
{
    public long Id { get; set; }
    public string Author { get; set; } = string.Empty;
    public DateTime CreateAt { get; set; }
}
namespace ClassLibrary2;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int RecipeId { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }
}
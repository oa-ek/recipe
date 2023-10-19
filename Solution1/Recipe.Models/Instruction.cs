namespace ClassLibrary2;

public class Instruction
{
    public int Id { get; set; }
    public string Step { get; set; } // Опис кроку приготування
    public int RecipeId { get; set; } // Зовнішній ключ для зв'язку з рецептом
    // Зв'язок з рецептом
    public Recipe Recipe { get; set; }
}
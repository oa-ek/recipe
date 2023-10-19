namespace ClassLibrary2
{
    public class Recipe
    {
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            RecipeInstructions = new List<Instruction>(); // Змінено ім'я з Instructions на RecipeInstructions
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Instruction> RecipeInstructions { get; set; } // Змінено ім'я з Instructions на RecipeInstructions
        public Category Category { get; set; }
        public User Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string PhotoUrl { get; set; }
    }
}
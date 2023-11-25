
namespace Karizma_Challenge.Models.Domain
{
    public class Recette
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string etape { get; set; }
        public int duree {  get; set; }
        public ICollection<Ingredient> Ingredients { get; set;}

        
    }
}

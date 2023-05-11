namespace CarRelation.Models
{
    public class Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cost { get; set; }

        public int BrandId { get; set; }
        public Brand brand { get; set; }
    }
}

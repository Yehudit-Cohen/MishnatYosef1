namespace MisnatYosef.Entities
{
    public class product
    {


        public int Id { get; set; } 
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public product(int id,string name,string category,double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }
    }
}

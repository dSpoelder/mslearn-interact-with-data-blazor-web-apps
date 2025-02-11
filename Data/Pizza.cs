namespace BlazingPizza.Data
{
    // Pizza Item from Database
    public class Pizza
    {
        public int PizzaID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }
    }
}
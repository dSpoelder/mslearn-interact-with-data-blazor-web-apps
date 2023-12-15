namespace BlazingPizza.Data
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreContext db)
        {
            //Method (sub) for building a sample database, takes a custom database object (db, inherited from Microsoft.EntityFrameworkCore.DbContext) to populate
            //Build an array of PizzaSpecial Items
            var specials = new PizzaSpecial[]
            {
                new() { Id = 1, Name = "Baconator", BasePrice = 11.99M, Description = "A Lot of Bacon!", ImageUrl = "img/pizzas/bacon.jpg" },
                new() { Id = 2, Name = "Chimken Picha", BasePrice = 12.99M, Description = "MMMMMMM!", ImageUrl = "img/pizzas/meaty.jpg" },
                new() { Id = 3, Name = "Ik Wil Kaas", BasePrice = 10.99M, Description = "Ik ben ook een klant!", ImageUrl = "img/pizzas/cheese.jpg" },
                new() { Id = 4, Name = "Mama Margherita", BasePrice = 9.99M, Description = "For Basic B*tches!", ImageUrl = "img/pizzas/margherita.jpg" },
                new() { Id = 5, Name = "Mushroom!", BasePrice = 10.99M, Description = "Badger, Badger, Badger, ...!", ImageUrl = "img/pizzas/mushroom.jpg" },
                new() { Id = 6, Name = "Big PP", BasePrice = 11.99M, Description = "Look At All Those Pepperonies!", ImageUrl = "img/pizzas/pepperoni.jpg" },
                new() { Id = 7, Name = "Leaf Lovers Special", BasePrice = 7.99M, Description = "Treehugger's and Greenhorn's delight!", ImageUrl = "img/pizzas/salad.jpg" }
            };
        }
    }
}
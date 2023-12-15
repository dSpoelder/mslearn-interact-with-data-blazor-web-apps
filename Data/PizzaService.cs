using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace BlazingPizza.Data
{
    //  Get Pizza Data
    public class PizzaService
    {
        public async Task<Pizza[]> GetPizzasAsync()
        {
            return await Task.Run( () => new Pizza[] {
                new() { PizzaID = 1, Name = "Pizza 1", Description = "First Pizza in List", Price = 1.99M },
                new() { PizzaID = 2, Name = "Pizza 2", Description = "Second Pizza in List", Price = 2.99M, Vegan = true },
                new() { PizzaID = 3, Name = "Pizza 3", Description = "Third Pizza in List", Price = 3.99M, Vegetarian = true },
                new() { PizzaID = 4, Name = "Pizza 4", Description = "Fourth Pizza in List", Price = 4.99M, Vegan = true, Vegetarian = true }
            } );
        }
    }
}
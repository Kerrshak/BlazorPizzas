namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync = Task.Run(() => 
    {
        Pizza[] pizzas = 
        {
            new Pizza { PizzaId = 1, Name = "Meateor", Description = "For the meatatarians", Price = 15.00M, Vegetarian = false, Vegan = false}
        };

        return pizzas;
    });
}
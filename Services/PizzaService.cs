using ContosoPizza.Models;
using ContosoPizza.DbContexts;
using System.Collections.Generic;

namespace ContosoPizza.Services;

public class PizzaService
{
    private PizzaDbContext dbContext;
    public PizzaService(PizzaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public List<Pizza> GetAll() => this.dbContext.GetAll();
    public Pizza? Get(int id) => this.dbContext.Get(id);
    public void Add(Pizza pizza)
    {
        this.dbContext.Add(pizza);
    }
    public void Update(Pizza pizza)
    {
        var pizzaDb = Get(pizza.Id);
        if(pizzaDb is null)return;
        pizzaDb.Name = pizza.Name;
        this.dbContext.Update(pizzaDb);
    }
    public void Delete(int id)
    {
        var pizzaDb = Get(id);
        if (pizzaDb is null)return;
        this.dbContext.Remove(pizzaDb);
    }

}
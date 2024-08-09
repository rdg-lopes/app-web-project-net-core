using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using ContosoPizza.Models;

namespace ContosoPizza.DbContexts;

public class PizzaDbContext : DbContext
{
    public DbSet<Pizza> pizzas{get;set;}
    public PizzaDbContext(DbContextOptions options):base(options)
    {
    }

    public List<Pizza> GetAll() => this.pizzas.ToList();
    public Pizza? Get(int id) => this.pizzas.FirstOrDefault(p => p.Id == id);
    public void Add(Pizza pizza)
    {
        this.pizzas.Add(pizza);
        SaveChanges();
    }
    public void Update(Pizza pizza)
    {
        var pizzaDb = Get(pizza.Id);
        if(pizzaDb is null)return;
        pizzaDb.Name = pizza.Name;
        SaveChanges();
    }
    public void Delete(int id)
    {
        var pizzaDb = Get(id);
        if (pizzaDb is null)return;
        this.pizzas.Remove(pizzaDb);
        SaveChanges();
    }

}
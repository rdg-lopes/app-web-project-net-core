using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace app_web.Pages;

public class ListaPizzaModel : PageModel
{
    private readonly PizzaService pizzaService;
    public IList<Pizza> PizzaList{get;set;} = default!;
    public ListaPizzaModel(PizzaService pizzaService)
    {
        this.pizzaService = pizzaService;
    }
    public void OnGet()
    {
        this.PizzaList = this.pizzaService.GetAll();
    }
}
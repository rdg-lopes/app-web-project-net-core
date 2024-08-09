using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app_web.Pages;

public class ListaUserModel : PageModel
{
    private readonly ILogger<ListaUserModel> logger;

    public ListaUserModel(ILogger<ListaUserModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {
        
    }

}

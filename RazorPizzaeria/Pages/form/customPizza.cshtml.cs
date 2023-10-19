using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_web.Model;
namespace RazorPizzaeria.Pages.form
{
    public class customPizzaModel : PageModel
    {
        [BindProperty]
        
        public  Pizzas pizza { get; set; }
        public float pizzaprice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            pizzaprice = pizza.baseprice;
            if (pizza.cheese) pizzaprice += 1;
            if (pizza.tomatosauce) pizzaprice += 1;
            if (pizza.beef) pizzaprice += 1;
            if (pizza.hum) pizzaprice += 1;
            if (pizza.pineapple) pizzaprice += 3;
            if (pizza.peperoni) pizzaprice += 1;
            if (pizza.mushroom) pizzaprice += 1;
            if (pizza.tuna) pizzaprice += 1;
            return RedirectToPage("/checkout/checkout", new { pizza.pizzaname, pizzaprice });

        }
    }
}

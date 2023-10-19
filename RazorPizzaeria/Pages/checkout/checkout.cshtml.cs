using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaeria.Pages.checkout
{[BindProperties (SupportsGet =true)]
    public class checkoutModel : PageModel
    {
        public string pizzaname { get; set; }
        public string imagetitle { get; set; }
        public float pizzaprice  { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(pizzaname)) pizzaname = "custom";
            if (string.IsNullOrWhiteSpace(imagetitle)) imagetitle = "image1";
        }
    }
}

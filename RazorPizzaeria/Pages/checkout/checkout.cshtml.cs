using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_web.Data;
using Pizza_web.Model;

namespace RazorPizzaeria.Pages.checkout
{[BindProperties (SupportsGet =true)]
    public class checkoutModel : PageModel
    {
        public string pizzaname { get; set; }
        public string imagetitle { get; set; }
        public float pizzaprice  { get; set; }
        readonly ApplicationDBContext _context;
        public checkoutModel(ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(pizzaname)) pizzaname = "custom";
            if (string.IsNullOrWhiteSpace(imagetitle)) imagetitle = "image1";
            pizzaorder pizzaorders = new pizzaorder();
            pizzaorders.pizaaname= pizzaname;
            pizzaorders.pizzaprice= pizzaprice;
            _context.pizzaorders.Add(pizzaorders);
            _context.SaveChanges();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_web.Data;
using Pizza_web.Model;

namespace pizaaweb.Pages
{
    public class ordersModel : PageModel
    {
        public List<pizzaorder> pizzaorders = new List<pizzaorder>();
        readonly ApplicationDBContext _context;
        public ordersModel( ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            pizzaorders = _context.pizzaorders.ToList();
        }
    }
}

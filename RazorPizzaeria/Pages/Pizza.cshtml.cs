using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_web.Model;

namespace RazorPizzaeria.Pages
{
    public class PizzaModel : PageModel
    {
       public List<Pizzas> fakepizzadb = new List<Pizzas>() {
        new Pizzas(){pizzaname="managesh" ,imagetitle="image1",cheese=true,peperoni=true,baseprice=3,finalprice=5},
        new Pizzas() { pizzaname = "hawa" ,imagetitle = "image2",cheese = true,peperoni = true,baseprice = 2,finalprice = 4},
        new Pizzas() { pizzaname = "yummy" ,imagetitle = "image3",cheese = true,pineapple=true, peperoni = true,baseprice = 3,finalprice = 8},
        new Pizzas() { pizzaname = "managesh" ,imagetitle = "image1",cheese = true,peperoni = true,baseprice = 3,finalprice = 5},
        new Pizzas() { pizzaname = "hawa" ,imagetitle = "image2",cheese = true,peperoni = true,baseprice = 2,finalprice = 4},
        new Pizzas() { pizzaname = "yummy" ,imagetitle = "image3",cheese = true,pineapple = true, peperoni = true,baseprice = 3,finalprice = 8}


    };       
        public void OnGet()
        {
        }
    }
}

using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class ShoppingCarController : Controller
    {
        // GET: ShoppingCar
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            for(int i = 1; i < 11;i++ )
            {
                products.Add(new Product() { Name = "product" + i, Price = 1.3 * i * i });
            }
            ShoppingCarViewModel viewModel = new ShoppingCarViewModel();
            viewModel.Products = products;
            viewModel.Message = "欢迎购物";
            viewModel.TotalCost = products.Sum(p => p.Price);
            return View(viewModel);
        }
    }
}
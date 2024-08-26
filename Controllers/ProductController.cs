using Day1_Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1_Demo.Controllers
{
    public class ProductController : Controller
    {
        //filling the list
        public static List<Product> Product_list = new List<Product>()
        {
            new Product{Name = "Arduino UNO", Price = 500, Code = 1, count = 3, CompanyID = 1},
            new Product{Name = "Nucleo Board", Price = 2300, Code = 2 , count = 15, CompanyID = 2},
            new Product{Name = "Atmega16", Price = 200, Code = 3, count = 2, CompanyID = 3},
            new Product{Name = "Atmega32", Price = 400, Code = 4, count = 5, CompanyID = 3},
        };

        public static List<Company> comp = new List<Company> {

            new Company{ID = 1 , name = "Arduino inc."},
            new Company{ID = 2 , name = "ARM" },
            new Company{ID = 3 , name = "AVR"}
        };


        // GET: ProductController1
        public ActionResult Index()  //to show all product data
        {
            return View(Product_list);
        }

        // GET: ProductController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController1/Create
        public ActionResult Create()
        {

            Product model1 = new Product();

            model1.Companies = comp;
            return View(model1);
        }

        // POST: ProductController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {

            Product_list.Add(model);     //to insert input data to list

            return RedirectToAction(nameof(Index));
            
            
        }

        // GET: ProductController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Product_list[id]);
        }

        // POST: ProductController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product model)
        {


            Product_list[id] = model;
            return RedirectToAction(nameof(Index));
            
           
        }

        // GET: ProductController1/Delete/5
        public ActionResult Delete(int id)
        { 
            return View(Product_list[id]);
        }

        // POST: ProductController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product model)
        {
            Product_list.Remove(Product_list[id]);
             return RedirectToAction(nameof(Index));
        }
    }
}

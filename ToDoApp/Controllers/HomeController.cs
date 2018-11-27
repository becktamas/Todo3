using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        //private string name;
        //private bool done;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TodoList()
        {
            //Bevásárló lista
            var lista = new List<string>();
            lista.Add("Cukor");
            lista.Add("Só");
            lista.Add("Kenyér");
            lista.Add("Hús");
            lista.Add("Tej");
            ViewBag.Lista = lista;//Beteszi az adatokat, nem erősen típusos
            ViewBag.Message = "Saját oldal.";
            var Items = new List<TodoItem>();
            Items.Add(new TodoItem() { Name = "Só", Done = true });
            Items.Add(new TodoItem() { Name = "Kifli", Done = false });
            Items.Add(new TodoItem() { Name = "Tej", Done = false});
            Items.Add(new TodoItem() { Name = "Banán", Done = true});
            return View(Items);
        }
    }
}
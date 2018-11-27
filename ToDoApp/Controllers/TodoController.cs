using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class TodoController : Controller
    {
        public List<TodoItem> Items { get; private set; } = new List<TodoItem>
            {
                new TodoItem() { Name = "Só", Done = true },
                new TodoItem() { Name = "Kifli", Done = false },
                new TodoItem() { Name = "Tej", Done = false },
                new TodoItem() { Name = "Banán", Done = true }
            };

        public ActionResult Index()
        {
            //Bevásárló lista
            var lista = new List<string>
            {
                "Cukor",
                "Só",
                "Kenyér",
                "Hús",
                "Tej"
            };
            ViewBag.Lista = lista;//Beteszi az adatokat, nem erősen típusos
            ViewBag.Message = "Saját oldal.";
            //Items 
            return View(Items);
        }
        public ActionResult Create(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                //adatok mentése, vissza az Indexre;
                Items.Add(new TodoItem() { Name = Name, Done = false });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
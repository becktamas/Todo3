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
            return View(MyDb.Items);
        }
        public ActionResult Create(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                //adatok mentése, vissza az Indexre;
                MyDb.Items.Add(new TodoItem() { Name = Name, Done = false });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
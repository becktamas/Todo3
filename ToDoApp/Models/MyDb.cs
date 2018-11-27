using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public class MyDb
    {
        public static List<TodoItem> Items { get; private set; } = new List<TodoItem>
            {
                new TodoItem() { Name = "Só", Done = true },
                new TodoItem() { Name = "Kifli", Done = false },
                new TodoItem() { Name = "Tej", Done = false },
                new TodoItem() { Name = "Banán", Done = true }
            };

    }
}
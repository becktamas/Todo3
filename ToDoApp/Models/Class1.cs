using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public class TodoElem
    {
        string Name;
        bool Done;
        public TodoElem(string a, bool b)
        {
            Name = a;
            Done = b;
        }
    }

    
}
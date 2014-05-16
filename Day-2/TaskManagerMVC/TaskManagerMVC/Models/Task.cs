using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManagerMVC.Models
{
    public class Task
    {
        public string id { get; set; }
        public string name { get; set; }
        public string isCompleted { get; set; }
    }
}
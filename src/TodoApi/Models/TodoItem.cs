using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public string DueDate { get; set; }
        public bool IsComplete { get; set; }
    }
}

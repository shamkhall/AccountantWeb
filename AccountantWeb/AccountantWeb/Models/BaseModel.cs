using System;
using Microsoft.VisualBasic.CompilerServices;

namespace AccountantWeb.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}
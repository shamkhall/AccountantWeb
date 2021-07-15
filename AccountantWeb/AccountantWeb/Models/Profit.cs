using AccountantWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountantWeb.Model
{
    public class Profit:BaseModel
    {
        

        
        [Required] 
        public Stat? Status { get; set; }
        [Required] 
        public int Amount { get; set; }
        [Required] 
        public Curr? Currency { get; set; }
        public string Comment { get; set; }
        public bool Own { get; set; }
    }
}
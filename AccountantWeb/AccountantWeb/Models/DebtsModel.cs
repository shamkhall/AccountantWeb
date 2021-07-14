using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace AccountantWeb.Models
{
    public class DebtsModel:BaseModel
    {
        [Required]
        public int Amount { get; set; }
        [Required] 
        public string Currency { get; set; }
        [Required]
        public int Percent { get; set; }
        [Required]
        public string Comment { get; set; }

        
    }
}
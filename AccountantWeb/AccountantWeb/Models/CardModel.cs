using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace AccountantWeb.Models
{
    public class CardModel: BaseModel
    {
       
        [MaxLength(16, ErrorMessage = "maksimum 16 simvol olmalılıdır")]
        public string CardNumber { get; set; }
        [MaxLength(3,ErrorMessage = "maksimum 3 simvol olmalılıdır") ]
        public string CVV { get; set; }
        [MaxLength(4, ErrorMessage = "maksimum 4 simvol olmalılıdır")]
        public string EndDate { get; set; }

        public int Amount { get; set; }
        
        public string Currency { get; set; }
        
    }
}
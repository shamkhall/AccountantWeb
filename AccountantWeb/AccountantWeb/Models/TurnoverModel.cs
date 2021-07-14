using System;

namespace AccountantWeb.Models
{
    public class TurnoverModel:BaseModel
    {
        
        public int CardId { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        
    }
}
using System;

namespace AccountantWeb.Models
{
    public class DebtRepaymentModel:BaseModel
    {
        public int DebtsId { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Comment { get; set; }
    }
}
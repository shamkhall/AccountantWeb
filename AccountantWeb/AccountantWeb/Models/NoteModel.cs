using System;
using System.ComponentModel.DataAnnotations;

namespace AccountantWeb.Models
{
    public class NoteModel:BaseModel
    {
        
        [Required]
        public string Note { get; set; }
        
        
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountantWeb.ViewModels
{
    public class EditUserViewModel : RegisterViewModel
    {
        public EditUserViewModel()
        {
            Roles = new List<string>();
            Claims = new List<string>();
            
        }


        public string Id { get; set; }
        [Required]
        
        public IList<string> Roles { get; set; }
        public List<string> Claims { get; set; }

    }
}
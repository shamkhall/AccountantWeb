using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountantWeb.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }
        [Required(ErrorMessage = "Role adını daxil edin")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
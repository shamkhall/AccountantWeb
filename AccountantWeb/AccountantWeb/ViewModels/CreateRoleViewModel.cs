using System.ComponentModel.DataAnnotations;

namespace AccountantWeb.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}

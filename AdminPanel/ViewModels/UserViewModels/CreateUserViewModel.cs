using System.ComponentModel.DataAnnotations;

namespace AdminPanel.ViewModels.UserViewModels
{
    public class CreateUserViewModel
    {
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}

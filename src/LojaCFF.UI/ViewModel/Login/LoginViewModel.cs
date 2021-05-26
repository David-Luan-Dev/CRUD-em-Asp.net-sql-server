using System.ComponentModel.DataAnnotations;

namespace LojaCFF.UI.ViewModel.Login
{
    public class LoginViewModel
    {
        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(10)]
        public string Senha { get; set; }

        public bool PermanecerLogado { get; set; }

        public string ReturnURL { get; set; }
    }
}
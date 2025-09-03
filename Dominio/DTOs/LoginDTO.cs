using System.ComponentModel.DataAnnotations;

namespace Minimal
{
    public class LoginDTO
    {
        [EmailAddress]
        public string Email { get; set; } = default!;

        public string Senha { get; set; } = default!;
    }
}

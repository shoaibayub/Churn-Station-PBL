using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Churn_Station_PBL.Models
{
    public class LoginViewModel
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

    }
}

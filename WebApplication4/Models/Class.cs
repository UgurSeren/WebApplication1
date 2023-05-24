using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? name { set; get; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string? Email { set; get; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string? Phone { set; get; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { set; get; }

    }
}

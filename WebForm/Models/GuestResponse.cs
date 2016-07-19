using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebForm.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać imię i nazwisko.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać e-mail.")]
        [RegularExpression("^.+\\@.+\\..+$", ErrorMessage = "Proszę podać poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać nr telefonu.")]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "Proszę podać poprawny nr telefonu.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę określić, czy weźmiesz udział.")]
        public bool? WillAttend { get; set; }
    }
}
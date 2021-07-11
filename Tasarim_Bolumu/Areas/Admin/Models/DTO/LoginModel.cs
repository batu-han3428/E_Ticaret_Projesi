using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Models.DTO
{
    public class LoginModel
    {

 
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter"), MinLength(6, ErrorMessage = "En Az 6 Karakter")]
        [DisplayName("Parola")]
        public string Parola { get; set; }

        public string Token { get; set; }
    }
}

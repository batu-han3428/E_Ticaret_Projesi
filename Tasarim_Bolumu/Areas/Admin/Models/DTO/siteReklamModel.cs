using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Models.DTO
{
    public class siteReklamModel
    {

        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [DisplayName("İkon")]
        [StringLength(50, ErrorMessage = "En Fazla 50 Karakter"), MinLength(1, ErrorMessage = "En Az 1 Karakter")]
        public string icon { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [DisplayName("Yazı")]
        [StringLength(50, ErrorMessage = "En Fazla 50 Karakter"), MinLength(3, ErrorMessage = "En Az 3 Karakter")]
        public string yazi { get; set; }

    }
}

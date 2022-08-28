using CShidori.Core;
using CShidori.DataHandler;
using CShidori.Generator;
using System.ComponentModel.DataAnnotations;

namespace TAISEN.Classes
{

    public class CShidObj
    {
        [Required]
        [StringLength(10, ErrorMessage = "Saisie trop longue")]
        public string? Name { get; set; }

        [Required]
        [StringLength(4096, ErrorMessage = "Saisie trop longue")]
        public string? Input { get; set; }
    }

}

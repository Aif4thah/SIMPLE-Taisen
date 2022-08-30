using CShidori.Core;
using CShidori.DataHandler;
using CShidori.Generator;
using System.ComponentModel.DataAnnotations;

namespace TAISEN.Classes
{

    public class CShidObj
    {
        [Required]
        [StringLength(60, ErrorMessage = "Saisie trop longue")]
        public string? Name { get; set; }

        [Required]
        [StringLength(4096, ErrorMessage = "Saisie trop longue - utilisez CShidori en ligne de commandes")]
        public string? Input { get; set; }
    }

}

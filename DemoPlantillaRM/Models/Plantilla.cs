//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoPlantillaRM.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Plantilla
    {
        public int id { get; set; }
        [Required]
        [DisplayName("Jugador")]
        public string Nombre { get; set; }
        [Required]
        public string Demarcacion { get; set; }
        [Range(16, 50, ErrorMessage = "Edad incorrecta")]
        public int Edad { get; set; }
        [Required]
       public string Extracomunitario { get; set; }
    }

}

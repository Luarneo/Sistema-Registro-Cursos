using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FrontSistemaFOP.Models
{
    public class InstructorViewModel
    {
        public int IdInstructor { get; set; }

        [DisplayName("Nombre")]
        [Required]
        public string NombreCompleto { get; set; }

        public bool Estatus { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FrontSistemaFOP.Models
{
    public class GrupoViewModel
    {
        public int IdGrupo { get; set; }

        [Required]
        public string PNI { get; set; }

        
        public int IdCampana { get; set; }

        [Required]
        [DisplayName("Campaña")]
        public string Campana { get; set; }

        
        public int IdTurno { get; set; }

        [Required]
        public string Turno { get; set; }

        public int IdInstructor { get; set; }

        public bool Estatus { get; set; }

        [DisplayName("Fecha de inicio Teoria")]
        public DateTime InicioTeoria { get; set; }

        [DisplayName("Fecha de fin Teoria")]
        public DateTime FinTeoria { get; set; }

        [DisplayName("Fecha de inicio OPC")]
        public DateTime InicioOPC { get; set; }

        [DisplayName("Fecha de fin OPC")]
        public DateTime FinOPC { get; set; }
    }
}
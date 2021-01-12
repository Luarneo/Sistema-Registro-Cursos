using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace FrontSistemaFOP.Models
{
    public class AspiranteViewModel
    {
        public int IdAspirante { get; set; }

        [DisplayName("Número de empleado")]
        [Required]
        public string NumeroEmpleado { get; set; }

        [Required]
        public string Nombre { get; set; }

        [DisplayName("Apellido Paterno")]
        [Required]
        public string ApellidoPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        [Required]
        public string ApellidoMaterno { get; set; }

        public bool Estatus { get; set; }

        public int ResultadoTeoria { get; set; }

        public int ResultadoFOP { get; set; }

        public List<KeyValuePair<int,string>> ListaAsistencia { get; set; }
    }
}
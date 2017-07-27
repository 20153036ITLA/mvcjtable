using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace jTableMvc.Entidades
{
    public class Prestamos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Pagos { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Motivo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Cedula { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace jTableMvc.Entidades
{
    public class Clientes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Apellido { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.Date)]
        public DateTime Nacimiento { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Cedula { get; set; }
    }
}
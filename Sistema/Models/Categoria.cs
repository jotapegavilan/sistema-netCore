using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Campo nombre obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe contener entre 3 y 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage = "La descripción no debe exeder los 256 caracteres")]
        [Display(Name ="Descripción")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}

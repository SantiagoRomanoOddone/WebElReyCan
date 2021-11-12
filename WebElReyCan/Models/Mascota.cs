using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Mascota
    {
        
        
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha { get; set; }

        //[Column(TypeName = "time")]
        //[DisplayFormat(DataFormatString = "{hh:mm}")]
        public string Hora { get; set; }
        [Required(ErrorMessage = "Campo Requerido.")]
        [StringLength(50)]
        public string NombreMascota { get; set; }
        [StringLength(50)]
        public string Raza { get; set; }
        public int Edad { get; set; }
        [Required(ErrorMessage = "Campo Requerido.")]
        [StringLength(50)]
        public string NombreDueño { get; set; }
        [Required(ErrorMessage = "Campo Requerido.")]
        [StringLength(50)]
        public string Celular { get; set; }
    }
}
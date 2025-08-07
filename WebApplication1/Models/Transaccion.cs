using System;
using System.ComponentModel.DataAnnotations;

namespace TuProyecto.Models
{
    public class Transaccion
    {
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [Range(0.01, 100000)]
        public decimal Monto { get; set; }

        [Display(Name = "Fecha")]
        public DateTime FechaTransaccion { get; set; } = DateTime.Now;
    }
}

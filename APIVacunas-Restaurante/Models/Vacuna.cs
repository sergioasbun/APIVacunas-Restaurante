using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIVacunas_Restaurante.Models
{
    public class Vacuna
    {
        [Key]
        public int Id { get; set; }
        public string Carnet { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Dosis { get; set; }
        [Required]
        public DateTime FechaDeVacunacion { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace APIVacunas_Restaurante.Models
{
    public class Vacuna
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Dosis { get; set; }
        [Required]
        public DateTime FechaDeVacunacion { get; set; }
        [Required]
        public Usuario usuario { get; set; }

    }
}
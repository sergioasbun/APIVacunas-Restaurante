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
        public string Dosis { get; set; }
        public DateTime FechaDeVacunacion { get; set; }
        public Usuario usuario { get; set; }

    }
}
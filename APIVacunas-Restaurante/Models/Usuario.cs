using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIVacunas_Restaurante.Models
{
    public class Usuario
    {
        [Key]
        public string Carnet { get; set; }
        [Required]
        public string NombreCompleto { get; set; } 
        public ICollection<Vacuna> Vacunas { get; set; }
    }
}

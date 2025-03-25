using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace SecretosParaContar.Data.Models

{

    public class Donacion
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public int UsuarioId {get; set;}

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto {get;set;}

        [Required]
        public DateTime Fecha {get;set;} = DateTime.UtcNow;

        [Required]
        [MaxLength(50)]
        public string Medio {get;set;} =string.Empty;

        [Required]
        [MaxLength(10)]
        public string Moneda {get;set;} = "COP";

    }
}
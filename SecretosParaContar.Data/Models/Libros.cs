using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecretosParaContar.Data.Models
{
    public class Libros : BaseEntity<int>
    {
        public string Title { get; set; } = string.Empty;

        [ForeignKey("Autor")]
        public int AutorId { get; set; }
        public virtual Autor? Autor { get; set; }

        public int Year { get; set; }

        public int? Rating { get; set; }  

        public string Summary { get; set; } = string.Empty;

        public string Editorial { get; set; } = string.Empty;

        public Genre Genre { get; set; } = Genre.Unknown;

        public string Cover { get; set; } = string.Empty;

        public string DownloadLink { get; set; } = string.Empty;

        public string PdfLink { get; set; } = string.Empty;

        public string AudiobookLink { get; set; } = string.Empty;
    }

    public enum Genre
    {
        LiteraturaInfantil,
        CuentosPopulares,
        Poesia,
        Educacion,
        Cultura,
        Unknown
    }
}

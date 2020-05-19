using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorPagesMovie.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Display(Name = "Data de Lançamento"), DataType(DataType.Date)]
        public DateTime RealesedDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        [Display(Name = "Gênero")]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        [Display(Name = "Avaliação")]
        public string Rating { get; set; }  
    }
}

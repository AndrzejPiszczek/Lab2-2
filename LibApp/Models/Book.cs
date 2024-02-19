using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tytuł jest wymagany!")]
        [StringLength(99, ErrorMessage = "Tytuł nie może być dłuższy niż 99 znaków!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Autor jest wymagany!")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Gatunek jest wymagany!")]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "Data wydania jest wymagana!")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Liczba sztuk jest wymagana")]
        [Range(1, 20, ErrorMessage = "Liczbe sztuk powinna mieścić się w przedziale 1-20")]
        public byte NumberInStock { get; set; }
    }
}

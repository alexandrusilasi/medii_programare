using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Silasi_Alexandru_Lab2.Models
{
    public class Book
    {
        public int id { get; set; }

        [Display(Name = "Title")]
        public string title { get; set; }

        [Display(Name = "Author")]
        public Author? Author { get; set; }
        public int? AuthorID { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Display(Name = "Price")]
        public decimal price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publish date")]
        public DateTime publishDate { get; set; }


        public int? publisherId { get; set; }
        public Publisher? Publisher { get; set; }

        public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}

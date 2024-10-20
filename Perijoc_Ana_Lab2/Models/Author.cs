using System.ComponentModel.DataAnnotations;

namespace Perijoc_Ana_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        // Navigation property for related Books
        public ICollection<Book>? Books { get; set; }
    }
}

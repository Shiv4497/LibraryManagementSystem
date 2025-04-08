using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models
{
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string? Bio { get; set; }
    }
}

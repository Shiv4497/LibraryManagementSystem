using System.Runtime.CompilerServices;
using LibraryManagement.API.Models;

namespace LibraryManagement.API.DTOs
{
    public class AuthorsCreateUpdateDto
    {
        public string Name { get; set; }
        public string? Bio { get; set; }
    }
}

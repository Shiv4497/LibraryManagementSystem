using System;
using System.Collections.Generic;

namespace LibraryManagement.API.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public int? AuthorId { get; set; }

    public int? PublishedYear { get; set; }

    public string? Genre { get; set; }
}

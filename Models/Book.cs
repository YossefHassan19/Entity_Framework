using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string ISBN { get; set; } = default!;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishedYear { get; set; }
        public bool IsInStock { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; } = default!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;

    }
}

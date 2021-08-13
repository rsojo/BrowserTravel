using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelWeb.Models
{
    public class Author_Book
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }

    }
}

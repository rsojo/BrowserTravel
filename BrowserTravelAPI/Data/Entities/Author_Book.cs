using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelAPI.Data.Entities
{
    public class Author_Book
    {
        public int Id { get; set; }
        public int Book_id { get; set; }
        public Book Book { get; set; }
        public int Author_id { get; set; }
        public Author Author { get; set; }

    }
}

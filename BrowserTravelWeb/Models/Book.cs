using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelWeb.Models
{
  
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string PageCount { get; set; }
        public Publisher Publisher { get; set; }
        public List<Author_Book> Author_Books { get; set; }
    }
}

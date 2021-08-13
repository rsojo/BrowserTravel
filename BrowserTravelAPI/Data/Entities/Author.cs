using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelAPI.Data.Entities
{

    /// <summary>
    /// Entity that stores authors info.
    /// </summary>
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        //Navigation Properties
        public List<Author_Book> Author_Books { get; set; }
    }
}

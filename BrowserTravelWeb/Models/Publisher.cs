using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelWeb.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BranchOffice { get; set; }
        public List<Book> Books { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelAPI.Data.Entities
{

    /// <summary>
    /// Entity that stores publishers info.
    /// </summary>
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BranchOffice { get; set; }

        // Navigation Properties
        public List<Book> Books { get; set; }

    }
}

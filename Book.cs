using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_92_EF02
{
    internal class Books
    {
        public int id{ get; set; }
        public string? Name{ get; set; }
        public string? ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPage { get; set;  }
        public int  PublishedYear { get; set; }
        public bool IsInStock { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        // Navigation Properties
        public Authors? Authors { get; set; }
        public Categories? Categories { get; set; }
    }
}

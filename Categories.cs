using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_92_EF02
{
    internal class Categories
    {
        public int Id { get; set;  }
        public String ? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Books> Books { get; set; }
           = new List<Books>();

    }
}

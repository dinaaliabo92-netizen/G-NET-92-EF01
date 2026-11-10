using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_92_EF02
{
    internal class Authors
    {
        public int id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public string? Emaill { get; set; }
        public DateTime DataOfBarith { get; set; }
        public string ? Biography { get; set; }
        public ICollection<Books> Books { get; set; }
            = new List<Books>();

    }
}

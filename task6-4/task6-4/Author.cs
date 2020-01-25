using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task6_4
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

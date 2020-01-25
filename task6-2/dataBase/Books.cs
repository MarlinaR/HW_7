using System;
using System.Collections.Generic;

namespace dataBase
{
    public partial class Books
    {
        public Books()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}

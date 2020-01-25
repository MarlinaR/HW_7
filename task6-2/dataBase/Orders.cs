using System;
using System.Collections.Generic;

namespace dataBase
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int DiscId { get; set; }

        public virtual Books Disc { get; set; }
    }
}

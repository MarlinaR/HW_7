﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6_3
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Authors Author { get; set; }
        public int AuthorId { get; set; }
    }
}

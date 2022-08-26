﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.domain.Models
{
    public class Book:Entity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime PublishDate { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

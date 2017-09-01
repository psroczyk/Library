﻿using Library.DomainModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.DomainModel
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }

        public string BookTitle { get; set; }
        public string Description { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }

        public int Year { get; set; }

        public int Pages { get; set; }

        public string Publisher { get; set; }

        public string Isbn { get; set; }

        public string Ean { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

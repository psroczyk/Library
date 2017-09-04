﻿using Library.DomainModel;
using Library.DomainModel.Enums;
using System.ComponentModel;

namespace Library.Application.Queries.Books
{
    public class BookQuery:BookShortQuery
    {
        public string Id { get; set; }
      
        public int Year { get; set; }

        public int Pages { get; set; }

        public string Publisher { get; set; }

        [DisplayName("ISBN")]
        public string Isbn { get; set; }

        [DisplayName("EAN")]
        public string Ean { get; set; }
    }
}

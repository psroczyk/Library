﻿using Library.Application.General;
using Library.DomainModel;
using Library.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandler : IQueryHandler<GetAllBooksQuery, IEnumerable<BookQuery>>
    {
        private readonly Repository<Book> repository;
        public GetAllBooksQueryHandler(Repository<Book> repository)
        {
            this.repository = repository;
        }
        public IEnumerable<BookQuery> Handle(GetAllBooksQuery query)
        {
            return repository.Get(query.Page, query.PageSize).Select(i => new BookQuery
            {
                Author = i.Author,
                BookTitle = i.BookTitle,
                Ean = i.Ean,
                Id = i.Id.ToString(),
                Isbn = i.Isbn,
                Pages = i.Pages,
                Publisher = i.Publisher,
                Year = i.Year,
            });

        }
    }
}

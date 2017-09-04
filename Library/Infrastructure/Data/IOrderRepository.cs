using Library.Application.Queries.Order;
using Library.DomainModel;
using System.Collections.Generic;

namespace Library.Infrastructure.Data
{
    public interface IOrderRepository
    {
        IEnumerable<OrderQuery> GetAll(int page = 1, int pageSize = 50);

        void Insert(Order order, IEnumerable<string> booksIds);

        void InsertDetails(OrderDetails orderDetails);
    }
}

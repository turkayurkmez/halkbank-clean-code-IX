using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Product
    {

    }

    public class Order
    {

    }

    public interface IRepository<T>
    {
        IList<T> GetAll();
        T Get(int id);

      
    }

    public interface ISearchable<T>
    {
        IList<T> SearchByName(string name);
    }

    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderRepository : IRepository<Order>
    {
        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAll()
        {
            throw new NotImplementedException();
        }

     
    }
}

using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public class ProductRepo : IProductRepo
    {
        private IRepository<Product> _repository;

        public ProductRepo(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Product GetProductById(int Id)
        {
            return _repository.GetById(Id);
        }
    }
}

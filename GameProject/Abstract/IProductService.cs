using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    internal interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAll();
    }
}

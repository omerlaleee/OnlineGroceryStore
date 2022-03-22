using OnlineGroceryStore.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.DataAccessLayer.Abstracts
{
    public interface IProductDal:IRepositoryDal<Product>
    {
        Product getById(int id);
    }
}

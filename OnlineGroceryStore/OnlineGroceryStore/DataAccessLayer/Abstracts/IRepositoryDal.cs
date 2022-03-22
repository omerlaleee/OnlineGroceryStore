using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.DataAccessLayer.Abstracts
{
    public interface IRepositoryDal<T> where T : class
    {
        void add(T entitiy);
        void update(T entitiy);
        void delete(T entitiy);
        List<T> getAll();
    }
}




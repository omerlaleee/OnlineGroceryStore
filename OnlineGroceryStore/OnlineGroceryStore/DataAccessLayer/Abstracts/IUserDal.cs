using OnlineGroceryStore.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.DataAccessLayer.Abstracts
{
    public interface IUserDal : IRepositoryDal<User>
    {
        bool signIn(string userName, string password);
        bool isRegistered(User user);
        User getByUserName(string userName);
        User getById(int id);
    }
}

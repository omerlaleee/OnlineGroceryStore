using OnlineGroceryStore.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.DataAccessLayer.Abstracts
{
    public interface IShoppingCartDal : IRepositoryDal<ShoppingCart>
    {
        ShoppingCart itemAndUserIsExist(int userId, int productId);
        List<ShoppingCart> getCartOfAnUser(int userId);
        ShoppingCart getAnItemToPurchase(int userId, int productId);
        void decreaseAmount(ShoppingCart itemToPurchase);
        void deleteAllItemsOfACart(int userId);
    }
}

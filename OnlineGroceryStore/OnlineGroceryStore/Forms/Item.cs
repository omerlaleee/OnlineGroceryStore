using OnlineGroceryStore.DataAccessLayer.Abstracts;
using OnlineGroceryStore.DataAccessLayer.Concretes;
using OnlineGroceryStore.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineGroceryStore.Forms
{
    public partial class Item : Form
    {
        IProductDal productManagerDal = new ProductManagerDal();
        IShoppingCartDal shoppingCartManagerDal = new ShoppingCartManagerDal();

        public Item()
        {
            InitializeComponent();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            ShoppingCart itemToPurchase = shoppingCartManagerDal.itemAndUserIsExist(LoginedUser.getInstance().user.id, Convert.ToInt32(txtBoxProductId.Text));
            shoppingCartManagerDal.add(itemToPurchase);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

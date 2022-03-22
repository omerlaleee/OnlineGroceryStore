using OnlineGroceryStore.Core.Utilities;
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
    public partial class UC_ShoppingItem : UserControl
    {
        IShoppingCartDal shoppingCartManagerDal = new ShoppingCartManagerDal();
        MainWindow mainWindow = new MainWindow();

        public UC_ShoppingItem()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            shoppingCartManagerDal.add(shoppingCartManagerDal.getAnItemToPurchase(LoginedUser.getInstance().user.id, Convert.ToInt32(lblProductId.Text)));
            MainWindow.ActiveForm.Close();
            mainWindow.Show();
            mainWindow.btnMyCart_Click(sender, e);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            shoppingCartManagerDal.decreaseAmount(shoppingCartManagerDal.getAnItemToPurchase(LoginedUser.getInstance().user.id, Convert.ToInt32(lblProductId.Text)));
            MainWindow.ActiveForm.Close();
            mainWindow.Show();
            mainWindow.btnMyCart_Click(sender, e);
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            shoppingCartManagerDal.delete(shoppingCartManagerDal.getAnItemToPurchase(LoginedUser.getInstance().user.id, Convert.ToInt32(lblProductId.Text)));
            MainWindow.ActiveForm.Close();
            mainWindow.Show();
            mainWindow.btnMyCart_Click(sender, e);
        }
    }
}

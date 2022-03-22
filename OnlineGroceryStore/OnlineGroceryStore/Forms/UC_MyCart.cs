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
    public partial class UC_MyCart : UserControl
    {
        IShoppingCartDal shoppingCartDal = new ShoppingCartManagerDal();
        public int row { get; set; }
        public int column { get; set; }
        float totalCost = 0;

        public UC_MyCart()
        {
            InitializeComponent();
        }
       
        public void click()
        {
            row = 0;
            column = 0;
            totalCost = 0;
            tableLayoutPanelOfItemsInCart.Controls.Clear();
            foreach (ShoppingCart itemToPurchase in shoppingCartDal.getCartOfAnUser(LoginedUser.getInstance().user.id))
            {
                place(itemToPurchase);
                totalCost += itemToPurchase.amount * itemToPurchase.product.price;
            }
            if (totalCost.ToString().Length > 6)
            {
                lblShowedTotalPayment.Text = totalCost.ToString().Substring(0, 6);
            }
            else
            {
                lblShowedTotalPayment.Text = totalCost.ToString();
            }
        }

        public void place(ShoppingCart itemToPurchase)
        {
            UC_ShoppingItem ucShoppingItem = new UC_ShoppingItem();
            ucShoppingItem.pctBoxOfItem.ImageLocation = itemToPurchase.product.imagePath.ToString();
            ucShoppingItem.lblProductId.Text = itemToPurchase.product.id.ToString();
            ucShoppingItem.lblShowedName.Text = itemToPurchase.product.name.ToString();
            ucShoppingItem.lblShowedQuantity.Text = itemToPurchase.amount.ToString();
            ucShoppingItem.lblShowedUnitPrice.Text = itemToPurchase.product.price.ToString();
            ucShoppingItem.lblShowedTotalPriceOfItem.Text = (itemToPurchase.product.price * itemToPurchase.amount).ToString();
            tableLayoutPanelOfItemsInCart.Controls.Add(ucShoppingItem, column, row);
            column++;
            if (column == 1)
            {
                row++;
                column = 0;
            }
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            shoppingCartDal.deleteAllItemsOfACart(LoginedUser.getInstance().user.id);
            click();
        }

        private void btnCompletePurchase_Click(object sender, EventArgs e)
        {
            List<ShoppingCart> bill = shoppingCartDal.getCartOfAnUser(LoginedUser.getInstance().user.id);
            Bill billForm = new Bill(bill);
            MainWindow.ActiveForm.Close();
            MainWindow mainWindow = new MainWindow();
            billForm.ShowDialog();
            mainWindow.Show();
            shoppingCartDal.deleteAllItemsOfACart(LoginedUser.getInstance().user.id);
            click();
        }
    }
}

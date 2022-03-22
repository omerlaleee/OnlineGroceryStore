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
    public partial class Bill : Form
    {
        public Bill(List<ShoppingCart> bill)
        {
            InitializeComponent();
            lblDate.Text = "Date : " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            lblBillTo.Text = "Bill To : \nOnline Grocery Store\nEskisehir Osmangazi University\nComputer Engineering Department\nonlinegrocery@gmail.com";
            lblShipTo.Text = "Ship To: \n" + LoginedUser.getInstance().user.userName + "\n" + LoginedUser.getInstance().user.phoneNumber + "\n" + LoginedUser.getInstance().user.address + "\n";
            int i = 1;
            double subTotal = 0;
            foreach (ShoppingCart item in bill)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { i.ToString(), item.product.name.ToString(), item.amount.ToString(), item.product.price.ToString(), (item.product.price * item.amount).ToString(), item.product.description.ToString() });
                listViewOfBill.Items.Add(listViewItem);
                i++;
                subTotal += (item.product.price * item.amount);
            }
            if (subTotal.ToString().Length > 6)
            {
                lblSubTotal.Text = "SubTotal : " + subTotal.ToString().Substring(0, 6);
            }
            else
            {
                lblSubTotal.Text = "SubTotal : " + subTotal.ToString();
            }
            double totalCost = subTotal + 18.98;
            if (totalCost.ToString().Length > 6)
            {
                lblTotalCost.Text = "Total Cost : " + totalCost.ToString().Substring(0, 6);
            }
            else
            {
                lblTotalCost.Text = "Total Cost : " + totalCost.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

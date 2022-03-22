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
    public partial class UC_Product : UserControl
    {
        IProductDal productManagerDal = new ProductManagerDal();

        public UC_Product()
        {
            InitializeComponent();
        }

        private void pctBoxOfProduct_Click(object sender, EventArgs e)
        {
            Product itemToPurchase = productManagerDal.getById(Convert.ToInt32(lblProductId.Text));
            Item item = new Item();
            item.txtBoxProductId.Text = itemToPurchase.id.ToString();
            item.pctBoxOfItem.ImageLocation = itemToPurchase.imagePath;
            item.txtBoxName.Text = itemToPurchase.name.ToString();
            item.txtBoxPrice.Text = itemToPurchase.price.ToString();
            item.txtBoxDescription.Text = itemToPurchase.description.ToString();
            item.ShowDialog();
        }
    }
}

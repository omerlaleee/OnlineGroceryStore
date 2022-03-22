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
    public partial class UC_Store : UserControl
    {
        IProductDal productManagerDal = new ProductManagerDal();
        public int row { get; set; }
        public int column { get; set; }

        public UC_Store()
        {
            InitializeComponent();
        }

        public void click()
        {
            row = 0;
            column = 0;
            tableLayoutPanelOfProducts.Controls.Clear();
            foreach (Product product in productManagerDal.getAll())
            {
                place(product.imagePath,product.id);
            }
        }

        public void place(string imagePath,int productId)
        {
            UC_Product ucProduct = new UC_Product();
            ucProduct.pctBoxOfProduct.ImageLocation = imagePath;
            ucProduct.lblProductId.Text = productId.ToString();
            tableLayoutPanelOfProducts.Controls.Add(ucProduct, column, row);
            column++;
            if (column == 3)
            {
                row++;
                column = 0;
            }
        }
    }
}

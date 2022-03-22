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
    public partial class UC_AdminSettings : UserControl
    {
        IProductDal productManagerDal = new ProductManagerDal();

        public UC_AdminSettings()
        {
            InitializeComponent();
            showingOfExistProductsInLocal();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image File |*.jpg; *.png";
            file.ShowDialog();
            txtBoxImagePath.Text = file.FileName;
            pctBoxOfProduct.ImageLocation = txtBoxImagePath.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utils.allFieldsHaveToFill(txtBoxName, txtBoxPrice, txtBoxDescription, txtBoxImagePath))
            {
                Product product = new Product(txtBoxName.Text, float.Parse(txtBoxPrice.Text), txtBoxDescription.Text, txtBoxImagePath.Text); ;
                productManagerDal.add(product);
                string[] informationsOfProduct = {      product.id.ToString(),
                                                        product.name.ToString(),
                                                        product.price.ToString(),
                                                        product.description.ToString(),
                                                        product.imagePath.ToString() };
                ListViewItem adder = new ListViewItem(informationsOfProduct);
                listViewOfProducts.Items.Add(adder);
                Utils.clearInformationsFromBoxes(pctBoxOfProduct, txtBoxName, txtBoxPrice, txtBoxDescription, txtBoxImagePath);
            }
        }

        public void showingOfExistProductsInLocal()
        {
            foreach (Product product in productManagerDal.getAll())
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {product.id.ToString(), product.name.ToString(), product.price.ToString(), product.description.ToString(), product.imagePath.ToString() });
                listViewOfProducts.Items.Add(listViewItem);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                productManagerDal.delete(productManagerDal.getById(Convert.ToInt32(listViewOfProducts.SelectedItems[0].SubItems[0].Text)));
                listViewOfProducts.Items.Remove(listViewOfProducts.SelectedItems[0]);
                Utils.clearInformationsFromBoxes(pctBoxOfProduct, txtBoxName, txtBoxPrice, txtBoxDescription, txtBoxImagePath);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You have to select a item to delete a information!");
            }
        }

        private void listViewOfProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOfProducts.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewOfProducts.SelectedItems[0];
                txtBoxName.Text = item.SubItems[1].Text;
                txtBoxPrice.Text = item.SubItems[2].Text;
                txtBoxDescription.Text = item.SubItems[3].Text;
                txtBoxImagePath.Text = item.SubItems[4].Text;
                pctBoxOfProduct.ImageLocation = txtBoxImagePath.Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewOfProducts.SelectedItems.Count < 1)
            {
                MessageBox.Show("You have to select a item to update a information!");
            }
            else
            {
                if (Utils.allFieldsHaveToFill(txtBoxName, txtBoxPrice, txtBoxDescription, txtBoxImagePath))
                {
                    Product product = new Product(Convert.ToInt32(listViewOfProducts.SelectedItems[0].SubItems[0].Text),txtBoxName.Text, float.Parse(txtBoxPrice.Text), txtBoxDescription.Text, txtBoxImagePath.Text); ;
                    productManagerDal.update(product);
                    ListViewItem item = listViewOfProducts.SelectedItems[0];
                    item.SubItems[1].Text = product.name;
                    item.SubItems[2].Text = product.price.ToString();
                    item.SubItems[3].Text = product.description;
                    item.SubItems[4].Text = product.imagePath;
                    txtBoxImagePath.Text = pctBoxOfProduct.ImageLocation;
                    Utils.clearInformationsFromBoxes(pctBoxOfProduct, txtBoxName, txtBoxPrice, txtBoxDescription, txtBoxImagePath);
                }
            }
        }
    }
}

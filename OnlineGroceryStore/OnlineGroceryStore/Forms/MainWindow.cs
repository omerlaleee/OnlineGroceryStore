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
    public partial class MainWindow : Form
    {
        UC_Store ucStore = new UC_Store();
        UC_MyCart ucMyCart = new UC_MyCart();
        UC_AdminSettings ucAdminSettings = new UC_AdminSettings();
        UC_MyProfile ucMyProfile = new UC_MyProfile();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            pnlContainer.Controls.AddRange(new Control[] { ucStore, ucMyCart, ucAdminSettings, ucMyProfile });
            if (LoginedUser.getInstance().user.userType == false)
            {
                btnSettings.Visible = false;
            }
            btnStore_Click(sender, e);
        }

        public void btnStore_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "STORE";
            ucStore.click();
            pnlContainer.Controls["UC_Store"].BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "SETTINGS";
            pnlContainer.Controls["UC_AdminSettings"].BringToFront();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "MY PROFILE";
            pnlContainer.Controls["UC_MyProfile"].BringToFront();
        }

        public void btnMyCart_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "MY CART";
            ucMyCart.click();
            pnlContainer.Controls["UC_MyCart"].BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

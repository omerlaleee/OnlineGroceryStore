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
    public partial class SignIn : Form
    {
        IUserDal userManagerDal = new UserManagerDal();

        public SignIn()
        {
            InitializeComponent();
            txtBoxPassword.PasswordChar = '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(Utils.allFieldsHaveToFill(txtBoxUserName, txtBoxPassword))
            {
                if(userManagerDal.signIn(txtBoxUserName.Text, Utils.MD5Encryption(txtBoxPassword.Text.ToString())))
                {
                    LoginedUser.getInstance().user = userManagerDal.getByUserName(txtBoxUserName.Text.ToString());
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("There is no registiration like you entered! Please try again!");
                }
            }
        }

        private void lnkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp form = new SignUp();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

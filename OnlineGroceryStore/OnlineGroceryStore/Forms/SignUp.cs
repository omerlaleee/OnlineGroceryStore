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
    public partial class SignUp : Form
    {
        IUserDal userManagerDal = new UserManagerDal();

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Utils.allFieldsHaveToFill(txtBoxUserName, txtBoxPassword, txtBoxPasswordRepeat, txtBoxProfilePhotoPath, txtBoxAddress, txtBoxPhoneNumber)) 
            {
                if (txtBoxPassword.Text != txtBoxPasswordRepeat.Text)
                {
                    MessageBox.Show("Passwords were not be matched! Registration was not be able to done!");
                }
                else
                {
                    User user;
                    if (txtBoxUserName.Text == "admin")
                    {
                        user = new User(txtBoxUserName.Text.ToString(), Utils.MD5Encryption(txtBoxPassword.Text.ToString()), txtBoxProfilePhotoPath.Text.ToString(), txtBoxAddress.Text.ToString(), txtBoxPhoneNumber.Text.ToString(), true);
                    }
                    else
                    {
                        user = new User(txtBoxUserName.Text.ToString(), Utils.MD5Encryption(txtBoxPassword.Text.ToString()), txtBoxProfilePhotoPath.Text.ToString(), txtBoxAddress.Text.ToString(), txtBoxPhoneNumber.Text.ToString(), false);
                    }
                    if (!userManagerDal.isRegistered(user))
                    {
                        MessageBox.Show("The username is already exist! Please change the username!");
                    }
                    else
                    {
                        userManagerDal.add(user);
                        MessageBox.Show("Registiration Done!");
                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectProfilePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image File |*.jpg; *.png";
            file.ShowDialog();
            txtBoxProfilePhotoPath.Text = file.FileName;
            pctBoxOfUser.ImageLocation = txtBoxProfilePhotoPath.Text;
        }
    }
}

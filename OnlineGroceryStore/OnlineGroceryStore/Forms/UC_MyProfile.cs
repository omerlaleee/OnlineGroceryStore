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
    public partial class UC_MyProfile : UserControl
    {
        IUserDal userManagerDal = new UserManagerDal();

        public UC_MyProfile()
        {
            InitializeComponent();
            showUserInfromations();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image File |*.jpg; *.png";
            file.ShowDialog();
            txtBoxProfilePhotoPath.Text = file.FileName;
            pctBoxOfUser.ImageLocation = txtBoxProfilePhotoPath.Text;
        }

        private void showUserInfromations()
        {
            User user = LoginedUser.getInstance().user;
            txtBoxUsername.Text = user.userName.ToString();
            // txtBoxPassword.Text = user.password.ToString();
            // txtBoxPassword.Text = "Please enter your new password if you want to change it, and then click the Update button!";
            txtBoxAddress.Text = user.address.ToString();
            txtBoxPhoneNumber.Text = user.phoneNumber.ToString();
            txtBoxProfilePhotoPath.Text = user.profilePhoto.ToString();
            pctBoxOfUser.ImageLocation = txtBoxProfilePhotoPath.Text.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure about remove the user?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (dialogResult == DialogResult.Yes)
            {
                userManagerDal.delete(LoginedUser.getInstance().user);
                MainWindow.ActiveForm.Close();
                SignIn signIn = new SignIn();
                signIn.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Utils.allFieldsHaveToFill(txtBoxUsername, txtBoxPassword, txtBoxAddress, txtBoxPhoneNumber, txtBoxProfilePhotoPath))
            {
                User userToBeUpdated = new User(LoginedUser.getInstance().user.id, txtBoxUsername.Text.ToString(), Utils.MD5Encryption(txtBoxPassword.Text.ToString()), txtBoxProfilePhotoPath.Text.ToString(), txtBoxAddress.Text.ToString(), txtBoxPhoneNumber.Text.ToString(), LoginedUser.getInstance().user.userType);
                if (userManagerDal.isRegistered(userToBeUpdated))
                {
                    userManagerDal.update(userToBeUpdated);
                    MessageBox.Show("Update Done!");
                }
                else
                {
                    MessageBox.Show("The username is already exist! Please change the username!");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void txtBoxPassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Text = "";
        }
    }
}

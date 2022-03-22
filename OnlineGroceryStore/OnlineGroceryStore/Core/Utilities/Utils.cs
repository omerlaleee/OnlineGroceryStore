using OnlineGroceryStore.DataAccessLayer.Abstracts;
using OnlineGroceryStore.DataAccessLayer.Concretes;
using OnlineGroceryStore.Entities.Concretes;
using OnlineGroceryStore.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineGroceryStore.Core.Utilities
{
    public class Utils
    {
        public static bool allFieldsHaveToFill(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show("All fields have to be filled!");
                    return false;
                }
            }
            return true;
        }

        public static void clearInformationsFromBoxes(PictureBox pictureBox ,params TextBox[] textBoxes)
        {
            pictureBox.ImageLocation = "";
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

        public static string MD5Encryption(string stringToBeEncrypted)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(stringToBeEncrypted);
            array = md5.ComputeHash(array);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte byt in array)
            {
                stringBuilder.Append(byt.ToString("x2").ToLower());
            }
            return stringBuilder.ToString();
        }
    }
}

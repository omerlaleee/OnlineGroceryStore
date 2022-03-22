using OnlineGroceryStore.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Entities.Concretes
{
    public class User : IEntity
    {
        private int Id;
        private string UserName;
        private string Password;
        private string ProfilePhoto;
        private string Address;
        private string PhoneNumber;
        private bool UserType;

        public User(string userName, string password, string profilePhoto, string address, string phoneNumber, bool userType)
        {
            this.UserName = userName;
            this.Password = password;
            this.ProfilePhoto = profilePhoto;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.UserType = userType;
        }

        public User(int id, string userName, string password, string profilePhoto, string address, string phoneNumber, bool userType)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.ProfilePhoto = profilePhoto;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.UserType = userType;
        }

        public int id { get => Id; set => Id = value; }
        public string userName { get => UserName; set => UserName = value; }
        public string password { get => Password; set => Password = value; }
        public string profilePhoto { get => ProfilePhoto; set => ProfilePhoto = value; }
        public string address { get => Address; set => Address = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public bool userType { get => UserType; set => UserType = value; }
    }
}

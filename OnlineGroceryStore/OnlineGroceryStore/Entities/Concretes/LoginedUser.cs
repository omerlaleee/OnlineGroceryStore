using OnlineGroceryStore.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Entities.Concretes
{
    public class LoginedUser
    {
        private static LoginedUser loginedUser;
        public static LoginedUser getInstance()
        {
            if (loginedUser == null)
            {
                loginedUser = new LoginedUser();
            }
            return loginedUser;
        }

        private User User;
        public User user { get => User; set => User = value; }
    }
}

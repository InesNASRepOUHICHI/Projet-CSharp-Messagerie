using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfProject.Model;

namespace WpfProject.Utils
{
    public class Session
    {
        public static User user;
        public User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

    }
}

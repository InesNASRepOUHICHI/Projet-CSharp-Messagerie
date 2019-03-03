using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject.Model
{
    [Table("User")]
    public class User
    {

        private int id;
        private string username;
        private string password;
        private String token;
   

        public User() { }

        public User(int id, string username,string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public User(int id, string username, string password, string token)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.token = token;
        }
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [Column("Username"), MaxLength(50)]
        public string Username
        {
            get
            {
                return username;

            }
            set
            {
                username = value;
            }
        }
        [Column("Password"), MaxLength(50)]
        public string Password
        {
            get
            {
                return password;

            }
            set
            {
                password = value;
            }
        }

        [Column("token"), MaxLength(50)]
        public string Token
        {
            get
            {
                return token;

            }
            set
            {
                token = value;
            }
        }

        


    }

}

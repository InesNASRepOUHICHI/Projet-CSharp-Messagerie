using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.ComponentModel;
using SQLite;

namespace WpfProject.Model
{

[Table("Personne")]
    public class Personne
    {

        private int id;
        private string nickname;
        private DateTime lastSeen;
        private string pubkey;
        private string privkey;
       
        private ObservableCollection<Message> myList;



        public Personne(int id, string nickname, DateTime lastSeen, string pubkey, string privkey)
        {
            this.myList = new ObservableCollection<Message>();
            this.id = id;
            this.nickname = nickname;
            this.lastSeen = lastSeen;
            this.pubkey = pubkey;
            this.privkey = privkey;
        }

        public Personne() { }

        public Personne(int id, string nickname)
        {
            this.myList = new ObservableCollection<Message>();
            this.id = id;
            this.nickname = nickname;
        }
        public Personne(string nickname)
        {
            this.myList = new ObservableCollection<Message>();

            this.nickname = nickname;
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
        public string Nickname
        {
            get
            {
                return nickname;

            }
            set
            {
                nickname = value;
            }
        }

        [Column("LastSeen"), MaxLength(50)]
        public DateTime LastSeen
        {
            get
            {
                return lastSeen;
            }

            set
            {
                lastSeen = value;
            }
        }

        [Column("Pubkey"), MaxLength(50)]
        public String Pubkey
        {
            get
            {
                return pubkey;
            }
            set
            {
                pubkey = value;
            }
        }
        [Column("Privkey"), MaxLength(50)]
        public String Privkey
        {
            get
            {
                return privkey;
            }

            set
            {
                privkey = value;
            }
        }

        
        public ObservableCollection<Message> Search(ObservableCollection<Message> messages)
        {
            foreach (Message msg in messages)
            {
                if (msg.Receiver == Id)
                {
                    
                    myList.Add(new Message(msg.Id, msg.Msg, msg.Receiver, msg.Sender));

                }

            }
            return myList;
        }

        public void addMessageToUser(Message m)
        {
            this.myList.Add(m);
        }
        [Ignore]
        public ObservableCollection<Message> GetList
        {
            get
            {
                return myList;
            }

            set
            {
                myList = value;

            }
        }

    }
}

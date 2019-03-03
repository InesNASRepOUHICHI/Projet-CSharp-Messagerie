using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject.Model
{
    [Table("Message")]
    public class Message
    {

        private int id;
        private string message;
        private Personne from;
        private Personne to;
        private DateTime date;
        private int receiver;
        private int sender;

        public Message()
        {
        }
        public Message(int id, string message, Personne from, Personne to)
        {
            this.id = id;
            this.message = message;
            this.from = from;
            this.to = to;


        }

        public Message(int id, string message, Personne from, Personne to, DateTime date) : this(id, message, from, to)
        {
            this.date = date;
        }

        public Message(int id, string message, int receiver, int sender, DateTime date) 
        {
            this.id = id;
            this.message = message;
            this.receiver = receiver;
            this.sender = sender;
            this.date = date;
        }

        public Message(int id, string msg, int receiver, int sender)
        {
            this.id = id;
            Msg = msg;
            this.receiver = receiver;
            this.sender = sender;
        }

        public override string ToString()
        {
            return "message " + Msg  ;
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
        [Column("Message"), MaxLength(50)]
        public string Msg
        {
            get
            {
                return message;

            }
            set
            {
                message = value;
            }
        }
        [Ignore]
        public Personne From
        {
            get
            {
                return from;
            }

            set
            {
                from = value;
            }
        }
        [Ignore]
        public Personne To
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        [Column("Receiver")]
        public int Receiver
        {
            get
            {
                return receiver;
            }

            set
            {
                receiver = value;
            }
        }
        [Column("Sender")]
        public int Sender
        {
            get
            {
                return sender;
            }

            set
            {
                sender = value;
            }
        }

    }
}

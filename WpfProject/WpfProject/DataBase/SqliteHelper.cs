using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfProject.Model;



namespace WpfProject.DataBase
{
    public class SqliteHelper
    { 
        private  SQLiteConnection connection;
        private string _dbPath = "../MyDatabase.db3"; // a changer

        public SqliteHelper()
        {

            connection = new SQLiteConnection(_dbPath);

            createTable();
        }

        public void createTable()
        {
            connection.CreateTable<Personne>();
            connection.CreateTable<Message>();
        }

        public void Insert(Personne p)
        {
            connection.Insert(p);
            List<Personne> pers = connection.Table<Personne>().Where(x => x.Id == 1).ToList();

            foreach (Personne pe in pers)
            {
                Console.WriteLine("id = " + pe.Id + " " + pe.Nickname);
            }
        }



        public void Test()
        {
            Personne p1 = new Personne(1, "ines", new DateTime(2008, 3, 1, 7, 0, 0), "pubkey", "privkey");
            Personne p2 = new Personne(1, "fatma", new DateTime(2008, 3, 1, 7, 0, 0), "pubkey", "privkey");
            connection.Insert(p1);
            connection.Insert(p2);

            Message m1 = new Message(1, "salut", p1.Id, p2.Id, new DateTime(2008, 3, 1, 7, 0, 0));
            connection.Insert(m1);

            List<Personne> pers = connection.Table<Personne>().Where(x => x.Id == 1).ToList();

            foreach (Personne p in pers)
            {
                Console.WriteLine("id = " + p.Id + " " + p.Nickname);
            }

            List<Message> mes = connection.Table<Message>().Where(x => x.Id == 1).ToList();

            foreach (Message m in mes)
            {
                Console.WriteLine(m);
            }



        }


    }


}


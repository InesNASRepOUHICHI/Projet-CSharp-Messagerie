using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfProject.Commands;
using WpfProject.Commands.WpfProject.Commands;
using WpfProject.DataBase;
using WpfProject.Model;
using WpfProject.View;



namespace WpfProject.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public SqliteHelper db = new SqliteHelper();
 
           

        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Personne> personnes = new ObservableCollection<Personne>();
        private ObservableCollection<Message> messages = new ObservableCollection<Message>();
       
       
        private String msg;

        private ICommand addButtonCommand;
        private ICommand sendButtonCommand;
        private ICommand deleteButtonCommand;
       


        private Personne personneSelected;
        private Message messageSelected;

        public ViewModelBase()
        {
            db.createTable();
          
            db.Test();


            AddButtonCommand = new RelayCommand(add);
            sendButtonCommand = new RelayCommand(send);
            deleteButtonCommand = new RelayCommand(delete);
           
        }
       

       


        Personne personne = new Personne(10, "c'est moi");
        public void load()
        {

            Personne p1 = new Personne(1, "ines", new DateTime(2008, 3, 1, 7, 0, 0), "pubkey", "privkey");
            Personne p2 = new Personne(2, "fatma", new DateTime(2008, 3, 1, 7, 0, 0), "pubkey", "privkey");
            Personne p3 = new Personne(3, "ono", new DateTime(2008, 3, 1, 7, 0, 0), "pubkey", "privkey");
            Personne p4 = new Personne(4, "faten",new DateTime(2008, 3, 1, 7, 0, 0), "pubkey", "privkey");
            int id1 = p1.Id;
            int id2 = p2.Id;
            int id3 = p3.Id;
            int id4 = p4.Id;

            Message m1 = new Message(1, "hello ", id1, id2, new DateTime(2008, 3, 1, 7, 0, 0));
            Message m2 = new Message(2, "hello ", id2, id3, new DateTime(2008, 3, 1, 7, 0, 0));
            Message m3 = new Message(3, "hello ", id4, id3, new DateTime(2008, 3, 1, 7, 0, 0));
            Message m4 = new Message(4, "hello ", id1, id4, new DateTime(2008, 3, 1, 7, 0, 0));
            messages.Add(m1);
            messages.Add(m2);
            messages.Add(m3);
            messages.Add(m4);

            p1.Search(messages);
            p2.Search(messages);
            p3.Search(messages);
            p4.Search(messages);
            personne.Search(messages);


            personnes.Add(p1);
            personnes.Add(p2);
            personnes.Add(p3);
            personnes.Add(p4);
         
            personnes.Add(personne);
        }
      
      
        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }
         
        public bool NotifyPropertyChanged<T>(ref T variable, T valeur, string nomPropriete = null)
        {
            if (object.Equals(variable, valeur)) return false;

            variable = valeur;
            NotifyPropertyChanged(nomPropriete);
            return true;
        }


        public ObservableCollection<Personne> Personnes
        {
            get
            {
                Console.WriteLine("dans console");
                return personnes;
            }
            set
            {
                if (personnes != value)
                {
                    personnes = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Message> Messages
        {
            get
            {
                return messages;
            }

            set
            {
                if (messages != value)
                {
                    messages = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public Personne PersonneSelected
        {
            get
            {
                return personneSelected;
            }
            set
            {
                if (personneSelected != value)
                {
                    personneSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Message MessageSelected
        {
            get
            {
                return messageSelected;
            }
            set
            {
                if (messageSelected != null)
                {
                    messageSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICommand AddButtonCommand
        {
            get
            {
                return addButtonCommand;
            }
            set
            {
                addButtonCommand = value;
            }
        }

        public ICommand SendButtonCommand
        {
            get
            {
                return sendButtonCommand;
            }
            set
            {
                sendButtonCommand = value;
            }
        }

        public ICommand DeleteButtonCommand
        {
            get
            {
                return deleteButtonCommand;
            }
            set
            {
                deleteButtonCommand = value;
            }
        }
        public String Msg
        {
            get
            {
                return msg;
            }
            set
            {
                if (msg != "")
                {
                    msg = value;
                }
            }
        }
        private void add()
        {
            Formulaire personne = new Formulaire();
            personne.Check += personne_Check;
            personne.Show();
        }
       
        private void send()
        {

            if (PersonneSelected != null)
            {
                PersonneSelected.addMessageToUser(new Message(-1, msg, personne, PersonneSelected, new DateTime()));
                Console.WriteLine(messages.Count);

            }

        }
        void personne_Check(Personne p)
        {
            personnes.Add(new Personne(p.Id, p.Nickname));

        }

        private void delete()
        {
            if (PersonneSelected != null)
                personnes.Remove(PersonneSelected);
        }
    }

}

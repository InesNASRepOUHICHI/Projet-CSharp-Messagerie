using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfProject.DataBase;
using WpfProject.Model;

namespace WpfProject.View
{
    /// <summary>
    /// Interaction logic for Formulaire.xaml
    /// </summary>
    public partial class Formulaire : Window
    {
        private ObservableCollection<Personne> personnes;
        public SqliteHelper db = new SqliteHelper();

        public Formulaire()
        {
            InitializeComponent();
        }

        public Formulaire(ObservableCollection<Personne> personnes)
        {
            this.personnes = personnes;
        }

        private void btnAddtolist_Click(object sender, RoutedEventArgs e)
        {
            if (Check != null)
               
                Check(new Personne(int.Parse(Idtxt.Text), Nickname.Text));
            db.Insert(new Personne(int.Parse(Idtxt.Text), Nickname.Text));

            this.Close();
        }


        public event Action<Personne> Check;


    }
}


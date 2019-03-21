using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using WpfProject.ViewModel;

namespace WpfProject.View
{
    /// <summary>
    /// Logique d'interaction pour Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private string username;
        private string password;
        private Autentification auth = new Autentification();
        public Register()
        {
           
            InitializeComponent();
       
            this.DataContext = auth ;
           
        }

        public void register(string username,string password){
            string user = "{\"username\":\""+username+"\"," + "\"password\":\""+password+"\"}";
            HttpResponseMessage response = null;
            try
            {
                using (var client = new HttpClient())
                {
                    response = client.PostAsync(
                     " http://baobab.tokidev.fr/api/createUser",
                      new StringContent(user, Encoding.UTF8, "application/json")).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("OK");
                        this.Close();
                        LoginScreen login = new LoginScreen();
                        login.Show();



                    }
                    else
                    {
                        MessageBox.Show("NOK");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }

        }

     





    }
}

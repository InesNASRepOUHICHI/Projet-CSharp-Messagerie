using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using WpfProject.Model;
using WpfProject.Utils;

namespace WpfProject.View
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string myJson = "{\"username\": \""+txtUsername.Text+ "\",\"password\":\"" + txtPassword.Password + "\"}";
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(
                        "http://baobab.tokidev.fr/api/login",
                         new StringContent(myJson, Encoding.UTF8, "application/json"));
                    string json = await response.Content.ReadAsStringAsync();

                    JObject accessToken = JsonConvert.DeserializeObject<JObject>(json);
                    Session session = new Session();
                    session.User = new User();
                    session.User.Token = accessToken.GetValue("access_token").ToString();
                    session.User.Username = accessToken.GetValue("username").ToString();
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();

                }
            } catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Veuillez vérifier vos identifiants SVP", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

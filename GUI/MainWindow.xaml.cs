using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PartnersMatcher;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model();
        }

        private void click_Search(object sender, RoutedEventArgs e)
        {

            searchWindow search = new searchWindow(model);
            search.Show();
        }

        private void click_newUser(object sender, RoutedEventArgs e)
        {
            newUser newUser = new newUser(model);
            newUser.Show();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            if (this.email.Text == "" || this.pass.Password =="")
                MessageBox.Show("one or more of the fields is empty", "EROR");
            if(!this.email.Text.Contains("@") && !this.email.Text.Contains("."))
                MessageBox.Show("The email is invalid", "EROR");

            string email = this.email.Text;
            string pass = this.pass.Password;

            try
            {
                model.login(email, pass);
                MessageBox.Show("login seccesful!");
                this.name.Text = "Hello "+ model.emailToUser[email].lastName + " " + model.emailToUser[email].firstName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

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
using System.Windows.Shapes;
using PartnersMatcher;

namespace GUI
{
    /// <summary>
    /// Interaction logic for newUser.xaml
    /// </summary>
    public partial class newUser : Window
    {
        public bool is_male;
        public bool is_female;
        Model model;
        public newUser(Model model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // ... A List.
            List<string> data = new List<string>();

            // ... Get the ComboBox reference.
            var comboBox = sender as ComboBox;

            // ... Assign the ItemsSource to the List.
            comboBox.ItemsSource = data;

            // ... Make the first item selected.
            comboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (this.first_name.Text == "" || this.last_name.Text == "" || this.dateOfBirth.Text == "" ||
                this.email.Text == "" || this.password.Password == "" || this.city.Text == "" )
            
                MessageBox.Show("one or more of the fields is empty", "EROR");
        
                else if (this.password.Password.Length < 8)
                    MessageBox.Show("password should have at least 8 characters", "EROR");
                else
                {
                    string fname = this.first_name.Text;
                    string lname = this.last_name.Text;
                    DateTime date = Convert.ToDateTime(this.dateOfBirth.Text);
                    string email = this.email.Text;
                    string password = this.password.Password;
                    string city = this.city.Text;
                    string gender;
                    if (is_male) gender = "male";
                    else gender = "female";

                    List<string> areas = new List<string>();
                  
                    User user = new User(fname, lname, date, gender, email, password, "", city, "", areas);

                    try
                    {
                        model.SignUp(user);
                        MessageBox.Show("congratulations! you are now a user of partnerMacher");
                        newUserLevel2 next = new newUserLevel2(model, email);
                        next.Show();
                        this.Close();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            

        }

        private void male_Checked(object sender, RoutedEventArgs e)
        {
            is_male = true;
            is_female = false;
        }

        private void female_Checked(object sender, RoutedEventArgs e)
        {
            is_female = true;
            is_male = false;
        }
    }
}

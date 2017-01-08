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
    public partial class newUserLevel2 : Window
    {
        string email;     
        Model model;
        public newUserLevel2(Model model, string email)
        {
            InitializeComponent();
            this.model = model;
            this.email = email;
            this.areas.ItemsSource = model.modelAreas;
            this.areas.MaxHeight=100;
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

        private void create_Click(object sender, RoutedEventArgs e)
        {
                string religion = this.religion.Text;
                string marital = this.marital.Text;



                    List<string> areas = new List<string>();
                    foreach (string item in this.areas.SelectedItems)
                    {
                        areas.Add(item); 
                    }
                    model.emailToUser[email].religion = religion;
                    model.emailToUser[email].maritalStatus = marital;
                    model.emailToUser[email].areas = areas;
                    this.Close();


        }


    }
}

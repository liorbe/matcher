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
    /// Interaction logic for searchWindow.xaml
    /// </summary>
    public partial class searchWindow : Window
    {
        Model model;
        public searchWindow(Model model)
        {
            InitializeComponent();
            // need to fill areas here
            this.model = model;

            this.areas.ItemsSource = model.modelAreas;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if( this.city.Text == "" || this.areas.Text=="")
                MessageBox.Show("one or more of the fields is empty", "EROR");
            if( !this.city.Text.All(c=> Char.IsLetter(c)))
                MessageBox.Show("the city is invalid", "EROR");
            string city = this.city.Text;
            string area = this.areas.Text;
            List<Post> pl = new List<Post>();
            //need to call model here for search with city and areas
            pl = model.SearchParterByCityAndArea(city, area);
            System.Windows.Forms.ListView l = new System.Windows.Forms.ListView();
            l.Columns.Add("ID", 100);
            l.Columns.Add("Subject", 100);
            l.Columns.Add("Content",100);

            ListView lv = new ListView();
            GridView gridView = new GridView();
            lv.View = gridView;
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Id",
                DisplayMemberBinding = new Binding("Id")
            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Title",
                DisplayMemberBinding = new Binding("Title")
            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "/content",
                DisplayMemberBinding = new Binding("Content")
            });

            // Populate list


            foreach (Post p in pl)
            {

                lv.Items.Add(new posttoshow { Id = p.id, Title = p.title, content =p.content });

                /*
                string[] arr = new string[3];
                arr[0] = p.id.ToString();
                arr[1] = p.title;
                arr[2] = p.content;
                
                System.Windows.Forms.ListViewItem lvi = new System.Windows.Forms.ListViewItem(p.id.ToString());
                lvi.SubItems
                l.Items.Add(lvi);
                */
            }
            Posts postWin = new Posts();
            postWin.Content = lv;
            postWin.Show();
        }
    }
}

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

namespace SimpleIMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables for the MainWindow
        public ItemsEntities db = new ItemsEntities();

        public MainWindow()
        {
            InitializeComponent();
            this.dGItems.ItemsSource = (from d in db.Items select d).ToList();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            new AddItem(this).Show();
        }
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            new EditItem(this).Show();
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            //Get the currently selected Item, selects the item on index 0 by default on the Data Grid
            Item selectedItem;

            try
            {
                selectedItem = this.dGItems.SelectedItems[0] as Item;
            }
            catch (Exception) { return; }
            
            Item i = (from d in db.Items where d.Id == selectedItem.Id select d).FirstOrDefault();
            db.Items.Remove(i);
            db.SaveChanges();

            this.dGItems.ItemsSource = (from d in db.Items select d).ToList();
        }

       
    }
}

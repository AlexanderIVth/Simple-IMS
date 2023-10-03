using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace SimpleIMS
{
    /// <summary>
    /// Interaction logic for EditItem.xaml
    /// </summary>
    public partial class EditItem : Window
    {
        public ItemsEntities db = new ItemsEntities();
        public MainWindow imsWindow;
        public Item selectedItem;
        public EditItem(MainWindow mainWindow)
        {
            InitializeComponent();
            this.imsWindow = mainWindow;
            this.selectedItem = mainWindow.dGItems.SelectedItems[0] as Item;

            this.txtBoxName.Text = selectedItem.ItemName;
            this.txtBoxDescription.Text = selectedItem.ItemDescription;
            this.dPAdded.SelectedDate = selectedItem.DateAdded;
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, RoutedEventArgs e)
        {
            Item i = (from d in db.Items where d.Id == selectedItem.Id select d).SingleOrDefault();
            i.ItemName = txtBoxName.Text;
            i.ItemDescription = txtBoxDescription.Text;
            i.DateAdded = dPAdded.SelectedDate.Value;

            db.Items.AddOrUpdate(i);
            db.SaveChanges();

            this.imsWindow.dGItems.ItemsSource = (from d in db.Items select d).ToList();
        }
    }
}

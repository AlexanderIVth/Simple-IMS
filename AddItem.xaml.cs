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

namespace SimpleIMS
{
    /// <summary>
    /// Interaction logic for AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {

        public ItemsEntities db = new ItemsEntities();
        public MainWindow imsWindow;
        public AddItem(MainWindow mainWindow)
        {
            InitializeComponent();
            this.imsWindow = mainWindow;
        }

        private void buttonConfirm_Click(object sender, RoutedEventArgs e)
        {
            db.Items.Add(new Item
            {
                ItemName = txtBoxName.Text,
                ItemDescription = txtBoxDescription.Text,
                DateAdded = dPAdded.SelectedDate.Value,
            });
            db.SaveChanges();
            this.imsWindow.dGItems.ItemsSource = (from d in db.Items select d).ToList();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

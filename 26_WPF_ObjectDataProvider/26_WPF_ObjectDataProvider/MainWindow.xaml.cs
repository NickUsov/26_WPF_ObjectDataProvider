using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _26_WPF_ObjectDataProvider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CarRepository cr;
        public MainWindow()
        {
            InitializeComponent();
            cr = new CarRepository();

        }

        void OrderHelper(string propname)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(cr.GetCars());
            if ((view.SortDescriptions.Count > 0) && (view.SortDescriptions[0].PropertyName == propname) && (view.SortDescriptions[0].Direction == ListSortDirection.Ascending))
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription(propname, ListSortDirection.Descending));
                view.Refresh();
            }
            else
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription(propname, ListSortDirection.Ascending));
                view.Refresh();
            }
            listBox.ItemsSource = cr.GetCars();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            OrderHelper("Manufactured");
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            OrderHelper("Model");
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            OrderHelper("DataSell");
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            OrderHelper("Price");
        }
    }
}

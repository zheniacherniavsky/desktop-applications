using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Item> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            ShowProducts.Click += (sender, args) =>
            {
                AddingProducts.Visibility = Visibility.Collapsed;
                Products.Visibility = Visibility.Visible;
            };

            AddProducts.Click += (sender, args) =>
            {
                Products.Visibility = Visibility.Collapsed;
                AddingProducts.Visibility = Visibility.Visible;
            };

            Items = new ObservableCollection<Item>
            {
                new Item {Name = "Hello", Category = "World", Count = 23, Image = "./Images/lol.png", Price = 23, Rating = 3, ShortDescription = "Description"},
                new Item {Name = "Hello", Category = "World", Count = 23, Image = "./Images/lol.png", Price = 23, Rating = 3, ShortDescription = "Description"},
                new Item {Name = "Hello", Category = "World", Count = 23, Image = "./Images/lol.png", Price = 23, Rating = 3, ShortDescription = "Description"},
                new Item {Name = "Hello", Category = "World", Count = 23, Image = "./Images/lol.png", Price = 23, Rating = 3, ShortDescription = "Description"},
                new Item {Name = "Hello", Category = "World", Count = 23, Image = "./Images/lol.png", Price = 23, Rating = 3, ShortDescription = "Description"},
                new Item {Name = "Hello", Category = "World", Count = 23, Image = "./Images/lol.png", Price = 23, Rating = 3, ShortDescription = "Description"},
                new Item {Name = "Hello", Category = "World", Count = 23, Image = "./Images/lol.png", Price = 23, Rating = 3, ShortDescription = "Description"}
            };
            itemsList.ItemsSource = Items;
        }
        private void itemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item p = (Item)itemsList.SelectedItem;
            MessageBox.Show(p.Name);
        }
    }
}

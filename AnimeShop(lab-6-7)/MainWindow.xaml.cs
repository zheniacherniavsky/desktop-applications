using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;

namespace AnimeShop_lab_6_7_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; } // все продукты
        public ObservableCollection<Product> Cart { get; set; } // корзина

        private bool isAdmin = false;

        private Product _product; 

        public Product SelectedProduct
        {
            get { return _product; }
            set
            {
                _product = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            // UI changes
            AddNewProductButton.IsEnabled = false;
            PermissionsButton.Background = Brushes.Red;

            // меняю курсор
            this.Cursor = LoadCursor();
            
            // подгружаю продукты из файла
            LoadProducts();

            // кидаю ивент на продукты чтобы при изменении у нас было автосохранение продуктов
            Products.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler
                ((sender, e) =>
            {
                if(e.Action == NotifyCollectionChangedAction.Add ||
                   e.Action == NotifyCollectionChangedAction.Remove ||
                   e.Action == NotifyCollectionChangedAction.Replace) SaveProducts();
            });
            Cart = new ObservableCollection<Product>();

            // устанавливаю зависимости
            ProductsList.ItemsSource = Products;
            CartList.ItemsSource = Cart;
        }

        /// <summary>
        /// Когда кликаем по продуктам на основной странице
        /// </summary>
        private void productList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedProduct = (Product)(sender as ListBox).SelectedItem;
            if (SelectedProduct != null)
            {
                InfoProduct infoProductWindow = new InfoProduct(SelectedProduct, Products, Cart, isAdmin);
                infoProductWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                infoProductWindow.Show();
            }
        }

        /// <summary>
        /// Когда кликаем по продуктам в корзине
        /// </summary>
        private void cartList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedProduct = (Product)(sender as ListBox).SelectedItem;

            // Короче был баг, когда мы удаляем из корзины товар, то короче 
            // типо секция меняется, и выполняется этот ивент, который берет
            // селект итем (удаленный) и пробует создать новое окно, где я из 
            // этого селекта поля забираю, короче вот, чтобы не было добавил
            // проверку на null
            // чтобы это понять мне надо было лечь поспать
            
            if (SelectedProduct != null)
            {
                CartProduct editProductWindow = new CartProduct(SelectedProduct, Cart);
                editProductWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                editProductWindow.Show();
            }
            
        }

        private void ShowAddProductWindow(object sender, RoutedEventArgs e)
        {
            AddProduct AddProduct = new AddProduct(Products);
            AddProduct.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AddProduct.Show();
        }

        private void ToggleAdminPermissions(object sender, RoutedEventArgs e)
        {
            isAdmin = !isAdmin;
            AddNewProductButton.IsEnabled = isAdmin;
            PermissionsButton.Background = isAdmin ? Brushes.LightGreen : Brushes.Red;
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Visible;
            CartGrid.Visibility = Visibility.Collapsed;
        }

        private void CartButtonClick(object sender, RoutedEventArgs e)
        {
            CartGrid.Visibility = Visibility.Visible;
            HomeGrid.Visibility = Visibility.Collapsed;
        }

        void SaveProducts()
        {
            using (FileStream fs = new FileStream("../../products.xml", FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Product>));
                formatter.Serialize(fs, Products);
            }
        }

        void LoadProducts()
        {
            using (FileStream fs = new FileStream("../../products.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Product>));
                Products = (ObservableCollection<Product>)formatter.Deserialize(fs);
            }
        }

        private Cursor LoadCursor()
        {
            var uri = new Uri("pack://application:,,,/Resources/cursor1.ani");
            var stream = Application.GetResourceStream(uri).Stream;
            var cursor = new Cursor(stream);
            return cursor;
        }
    }
}

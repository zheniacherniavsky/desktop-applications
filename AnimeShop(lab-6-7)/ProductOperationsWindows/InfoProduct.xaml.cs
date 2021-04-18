using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace AnimeShop_lab_6_7_
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class InfoProduct : Window
    {
        private Product _product;
        private ObservableCollection<Product> _cartList;
        private ObservableCollection<Product> _productsList;
        private bool _adminPermissions;

        public static RoutedCommand AddToCart { get; set; }
        public static RoutedCommand EditProduct { get; set; }

        static InfoProduct()
        {
            AddToCart = new RoutedCommand("AddToCart", typeof(InfoProduct));
            EditProduct = new RoutedCommand("EditProduct", typeof(InfoProduct));
        }

        public void AddToCart_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _cartList.Add(_product);
            MessageBox.Show("Вы добавили в корзину " + _product.Title);
            Close();
        }

        public void EditProduct_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            EditProduct editProductWindow = new EditProduct(_productsList, _product);
            editProductWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            editProductWindow.Show(); 
            Close();
        }

        public void EditProduct_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _adminPermissions;
        }

        public InfoProduct(Product p, ObservableCollection<Product> ProductsList, ObservableCollection<Product> CartList, bool isAdmin)
        {
            InitializeComponent();
            var uri = new Uri("pack://application:,,,/Resources/cursor2.ani");
            var stream = Application.GetResourceStream(uri).Stream;
            var cursor = new Cursor(stream);
            this.Cursor = cursor;
            _product = p;
            _cartList = CartList;
            _adminPermissions = isAdmin;
            _productsList = ProductsList;

            this.Title = p.Title;
            ProductTitle.Text = p.Title;
            ProductDescription.Text = p.Description;
            ProductCategory.Text = p.Category;
            ProductPrice.Text = p.Price.ToString();
            ProductRating.Text = p.Rating.ToString();

            BitmapImage myBitmapImage = new BitmapImage(new Uri("../../../.." + p.ImagePath, UriKind.Relative));
            myBitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            ProductImage.Source = myBitmapImage;

        }
    }
}

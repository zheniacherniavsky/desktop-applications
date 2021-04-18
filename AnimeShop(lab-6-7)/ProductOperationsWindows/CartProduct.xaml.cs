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
    public partial class CartProduct : Window
    {
        private Product _product;
        private ObservableCollection<Product> _cartList;
        public static RoutedCommand RemoveFromCart { get; set; }

        static CartProduct()
        {
            RemoveFromCart = new RoutedCommand("RemoveFromCart", typeof(InfoProduct));
        }

        public void RemoveFromCart_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
            _cartList.Remove(_product);
            MessageBox.Show("Вы удалили этот товар");
        }

        public CartProduct(Product p, ObservableCollection<Product> CartList)
        {
            InitializeComponent();
            var uri = new Uri("pack://application:,,,/Resources/cursor2.ani");
            var stream = Application.GetResourceStream(uri).Stream;
            var cursor = new Cursor(stream);
            this.Cursor = cursor;
            _product = p;
            _cartList = CartList;

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

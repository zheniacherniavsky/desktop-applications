using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace AnimeShop_lab_6_7_
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        private ObservableCollection<Product> _productsList;
        private Product _product;
        public static RoutedCommand ChangeProduct { get; set; }
        public static RoutedCommand DeleteProduct { get; set; }

        static EditProduct()
        {
            ChangeProduct = new RoutedCommand("ChangeProduct", typeof(InfoProduct));
            DeleteProduct = new RoutedCommand("DeleteProduct", typeof(InfoProduct));
        }

        public void ChangeProduct_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
            double price = 0;
            int rating = 0;
            try
            {
                price = Double.Parse(ProductPrice.Text);
                rating = Int32.Parse(ProductRating.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Проверьте правильность значений рейтинг и цена");
                return;
            }

            for (int i = 0; i < _productsList.Count; i++)
            {
                if (_productsList[i] == _product)
                {
                    _productsList[i] = new Product
                    {
                        Category = ProductCategory.Text,
                        Description = ProductDescription.Text,
                        Id = _product.Id,
                        ImagePath = ImagePath.Text,
                        Price = price,
                        Rating = rating,
                        Title = ProductTitle.Text
                    };
                    break;
                }
            }
            MessageBox.Show("Изменено!");
        }
        public void DeleteProduct_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
            _productsList.Remove(_product);
            MessageBox.Show("Продукт удалён!");
            
        }
        public EditProduct(ObservableCollection<Product> ProductsList, Product p)
        {
            InitializeComponent();
            var uri = new Uri("pack://application:,,,/Resources/cursor2.ani");
            var stream = Application.GetResourceStream(uri).Stream;
            var cursor = new Cursor(stream);
            this.Cursor = cursor;
            _productsList = ProductsList;
            _product = p;

            this.Title = p.Title;
            ProductTitle.Text = p.Title;
            ProductDescription.Text = p.Description;
            ProductCategory.Text = p.Category;
            ProductPrice.Text = p.Price.ToString();
            ProductRating.Text = p.Rating.ToString();
            ImagePath.Text = p.ImagePath;
        }
    }
}

using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace AnimeShop_lab_6_7_
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        private ObservableCollection<Product> _productsList;
        public static RoutedCommand AddNewProduct { get; set; }

        static AddProduct()
        {
            AddNewProduct = new RoutedCommand("AddProduct", typeof(InfoProduct));
        }

        public void AddNewProduct_Executed(object sender, ExecutedRoutedEventArgs e)
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
            _productsList.Add(new Product
            {
                Category = ProductCategory.Text,
                Description = ProductDescription.Text,
                Id = _productsList.Count,
                ImagePath = ImagePath.Text,
                Price = price,
                Rating = rating,
                Title = ProductTitle.Text
            });
            MessageBox.Show("Добавлен!");
        }
        public AddProduct(ObservableCollection<Product> ProductsList)
        {
            InitializeComponent();
            ImagePath.Text = "/Images/";
            var uri = new Uri("pack://application:,,,/Resources/cursor2.ani");
            var stream = Application.GetResourceStream(uri).Stream;
            var cursor = new Cursor(stream);
            this.Cursor = cursor;
            _productsList = ProductsList;
        }
        
    }
}

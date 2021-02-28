using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Singleton settingSingleton = Singleton.GetInstance();
            this.BackColor = settingSingleton.Color;
            this.ForeColor = settingSingleton.ForeColor;
            InitializeComponent();
        }

        private void makeOrder(object sender, EventArgs e)
        {
            Order order = new Order();
            Product product = order.CreateProductUppercase(sender);
            Validate(product);
        }

        private void Validate(Product product)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(product);
            if (!Validator.TryValidateObject(product, context, results, true))
            {
                string text = "";
                foreach (var error in results)
                {
                    text += error.ErrorMessage + '\n';

                }
                MessageBox.Show(text, "Ошибка при добавлении товара");
            }
            else
            {
                AddProduct(product);
                MessageBox.Show("Товар успешно добавлен!");
            }
        }

        private void AddProduct(Product product)
        {
            bool newProduct = true;

            foreach(Product p in Product.ProductsList)
            {
                if(product.Number == p.Number)
                {
                    newProduct = false;
                    break;
                }
            }

            if (newProduct)
            {
                Product.ProductsList.Add(product);
                updateStateLine("Добавление");
            }
            outputBox.Text = Product.getInfo();
        }

        private void updateStateLine(string operation)
        {
            stateLine.Text = $"Строка состояния: Кол-во элементов: {Product.ProductsList.Count}. Последняя операция: {operation} [{DateTime.Now}]";
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            if(Product.ProductsList.Count != 0)
            {
                DataSerialization.Serialize(Product.ProductsList.ToArray(), "base.xml");
                updateStateLine("Сохранение");
                MessageBox.Show($"Успех. Кол-во товара: {Product.ProductsList.Count}", "Товар Сохранён");
            }
            else MessageBox.Show($"Товар не сохранён. Кол-во товара: {Product.ProductsList.Count}", "Ошибка");
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            Product[] prods = DataSerialization.Deserialize<Product>("base.xml");

            if(prods != null)
            {
                Product.ProductsList.Clear(); // clear our list before adding items

                foreach (Product prod in prods)
                {
                    Product.ProductsList.Add(prod);
                }
                outputBox.Text = Product.getInfo();
                updateStateLine("Загрузка");
                MessageBox.Show($"Товар был загружен.\nНовое количество товара: {Product.ProductsList.Count}", "Успех!");
            }
            else MessageBox.Show($"Не удалось загрузить товар. Скорее всего у вас нет файла с сохранением!");
        }

        private void aboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Жека\nВерсия: 1.0.0", "О программе");
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Show();
        }

        private void поСтранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedByCountry = from el in Product.ProductsList
                                  orderby el.producer.Country
                                  select el;

            UpdateList(sortedByCountry);
        }

        private void поДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedByDate = from el in Product.ProductsList
                               orderby DateTime.Parse(el.Date) descending
                               select el;

            UpdateList(sortedByDate);

        }

        private void поНазваниюТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedByName = from el in Product.ProductsList
                               orderby el.Name
                               select el;

            UpdateList(sortedByName);
        }

        private void поДатеотМКБToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedByDate = from el in Product.ProductsList
                               orderby DateTime.Parse(el.Date) ascending
                               select el;

            UpdateList(sortedByDate);
        }

        private void UpdateList(IOrderedEnumerable<Product> list)
        {
            List<Product> newList = new List<Product>();

            foreach (Product p in list)
            {
                newList.Add(p);
            }

            Product.ProductsList.Clear();

            Product.ProductsList = newList;
            outputBox.Text = Product.getInfo();
        }

        private void сохранитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Product.ProductsList.Count != 0)
            {
                DataSerialization.Serialize(Product.ProductsList.ToArray(), "sort.xml");
                MessageBox.Show($"Успех. Кол-во товара: {Product.ProductsList.Count}", "Товар Сохранён");
            }
            else MessageBox.Show($"Товар не сохранён. Кол-во товара: {Product.ProductsList.Count}", "Ошибка");
        }

        private void включитьПанельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip.Visible == true) toolStrip.Visible = false;
            else toolStrip.Visible = true;
        }
    }
}

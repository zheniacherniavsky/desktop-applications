using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void makeOrder(object sender, EventArgs e)
        {
            Product product = new Product();

            // Example chech with function BoxNotCorrect
            //
            //string orderNumber = String.Empty;
            //if (String.IsNullOrEmpty(productNumber.Text) || productNumber.Text == "Введите значение")
            //    BoxNotCorrect(productNumber, ref hasErrors);
            //else orderNumber = productNumber.Text;

            // but i will use attributes

            product.Name = productName.Text;
            product.Number = productNumber.Text;
            product.Size = $"{productWidth.Value}x{productLength.Value}x{productHeight.Value} (ШхДхВ)";

            if (productMaterial.SelectedItems.Count != 0)
                product.MaterialType = productMaterial.SelectedItem.ToString();
            else product.MaterialType = String.Empty;
            
            product.Date = productDate.Value.ToString();

            if (countMoreTen.Checked) product.Count = "Больше 10";
            else if (countLessTen.Checked) product.Count = "Меньше 10";
            else product.Count = "Неопределенное количество";

            product.producer.Organization = producerOrganization.Text;
            product.producer.Country = producerCountry.Text;
            product.producer.Address = producerAddress.Text;
            product.producer.PhoneNumber = producerPhone.Text;

             // product.Show(); // console debug

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
            }
            outputBox.Text = Product.getInfo();

        }

        //public void BoxNotCorrect(TextBox sender, ref bool hasErrors)
        //{
        //    sender.BackColor = Color.LightPink;
        //    sender.Text = "Введите значение";
        //    hasErrors = true;
        //    sender.Click += (obj, e) =>
        //    {
        //        sender.Text = String.Empty;
        //        sender.BackColor = Color.White;
        //    };
        //}

        //public void BoxNotCorrect(ComboBox sender, ref bool hasErrors)
        //{
        //    sender.BackColor = Color.LightPink;
        //    sender.Text = "Введите значение";
        //    hasErrors = true;
        //    sender.Click += (obj, e) =>
        //    {
        //        sender.Text = String.Empty;
        //        sender.BackColor = Color.White;
        //    };
        //}

        private void saveData_Click(object sender, EventArgs e)
        {
            if(Product.ProductsList.Count != 0)
            {
                DataSerialization.Serialize(Product.ProductsList.ToArray(), "base.xml");
                MessageBox.Show($"Успех. Кол-во товара: {Product.ProductsList.Count}", "Товар Сохранён");
            }
            else MessageBox.Show($"Товар не сохранён. Кол-во товара: {Product.ProductsList.Count}", "Ошибка");
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            Product[] prods = DataSerialization.Deserialize<Product>("base.xml");

            Product.ProductsList.Clear(); // clear our list before adding items

            foreach (Product prod in prods)
            {
                Product.ProductsList.Add(prod);
            }
            outputBox.Text = Product.getInfo();
            MessageBox.Show($"Товар был загружен.\nНовое количество товара: {Product.ProductsList.Count}", "Успех!");
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
    }
}

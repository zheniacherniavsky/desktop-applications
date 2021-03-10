using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public static class Command
    {
        public static void UpdateList(IOrderedEnumerable<Product> list)
        {
            List<Product> newList = new List<Product>();

            foreach (Product p in list)
            {
                newList.Add(p);
            }

            Product.ProductsList.Clear();

            Product.ProductsList = newList;
        }

        public static void AboutAuthor()
        {
            MessageBox.Show("Разработчик: Жека\nВерсия: 1.0.0", "О программе");
        }

        public static void ShowSearchForm()
        {
            SearchForm search = new SearchForm();
            search.Show();
        }

        public static void SaveSortResult()
        {
            if (Product.ProductsList.Count != 0)
            {
                DataSerialization.Serialize(Product.ProductsList.ToArray(), "sort.xml");
                MessageBox.Show($"Успех. Кол-во товара: {Product.ProductsList.Count}", "Товар Сохранён");
            }
            else MessageBox.Show($"Товар не сохранён. Кол-во товара: {Product.ProductsList.Count}", "Ошибка");
        }

        public static void SaveResult()
        {
            if (Product.ProductsList.Count != 0)
            {
                DataSerialization.Serialize(Product.ProductsList.ToArray(), "base.xml");
                MessageBox.Show($"Успех. Кол-во товара: {Product.ProductsList.Count}", "Товар Сохранён");
            }
            else MessageBox.Show($"Товар не сохранён. Кол-во товара: {Product.ProductsList.Count}", "Ошибка");
        }
    }
}

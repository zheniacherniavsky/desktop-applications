using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    [Serializable]
    public class Product
    {
        public static List<Product> ProductsList = new List<Product>();

        [Required(ErrorMessage = "Поле 'Название товара' обязательно!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле 'Инвентарный номер' обязательно!")]
        public string Number { get; set; }
        public string Size { get; set; }

        [Required(ErrorMessage = "Продукт должен иметь материал!")]
        public string MaterialType { get; set; }

        public string Date { get; set; }
        public string Count { get; set; }

        public Producer producer = new Producer();

        public void Show()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Number);
            Console.WriteLine(Size);
            Console.WriteLine(MaterialType);
            Console.WriteLine(Date);
            Console.WriteLine(Count);
            producer.Show();
        }

        public static string getInfo()
        {
            string text = String.Empty;

            foreach(Product p in ProductsList)
            {
                text += "================================================" + Environment.NewLine + Environment.NewLine;
                text += "\t\t\t\t\tТОВАР" + Environment.NewLine;
                text += $"НАЗВАНИЕ ТОВАРА: {p.Name}" + Environment.NewLine;
                text += $"НОМЕР ТОВАРА: {p.Number}" + Environment.NewLine;
                text += $"РАЗМЕР: {p.Size}" + Environment.NewLine;
                text += $"МАТЕРИАЛ: {p.MaterialType}" + Environment.NewLine;
                text += $"ДАТА: {p.Date}" + Environment.NewLine;
                text += $"КОЛИЧЕСТВО: {p.Count}" + Environment.NewLine;
                text += "\t\t\t\tПРОИЗВОДИТЕЛЬ" + Environment.NewLine;
                text += $"ОРГАНИЗАЦИЯ: {p.producer.Organization}" + Environment.NewLine;
                text += $"СТРАНА: {p.producer.Country}" + Environment.NewLine;
                text += $"АДРЕСС: {p.producer.Address}" + Environment.NewLine;
                text += $"НОМЕР ТЕЛЕФОНА: {p.producer.PhoneNumber}" + Environment.NewLine + Environment.NewLine;
            }

            return text;
        }
    }

    [Serializable]
    public class Producer
    {
        public string Organization { get; set; }

        [Required(ErrorMessage = "Обязательно укажите страну!")]
        public string Country { get; set; }
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^\+[2-9]{3}\s\([0-9]{2}\)\s[0-9]{3}\-[0-9]{2}\-[0-9]{2}$", ErrorMessage = "Номер телефона должен иметь формат +xxx (xx) xxx-xx-xx")]
        public string PhoneNumber { get; set; }

        public void Show()
        {
            Console.WriteLine(Organization);
            Console.WriteLine(Country);
            Console.WriteLine(Address);
            Console.WriteLine(PhoneNumber);
        }
    }

    public static class DataSerialization
    {
        public static void Serialize<T>(T[] obj, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T[]));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        public static T[] Deserialize<T>(string filename)
        {
            T[] obj;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T[]));
                obj = (T[])formatter.Deserialize(fs);
            }

            return obj;
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}

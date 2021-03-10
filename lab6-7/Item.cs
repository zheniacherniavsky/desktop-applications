using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_7
{
    [Serializable]
    public class Item
    {
        public static List<Item> list = new List<Item>();

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public static void Add(Item item)
        {
            list.Add(item);
        }

        public static void Remove(Item item)
        {
            list.Remove(item);
        }

        public static void Save(string path)
        {
            DataSerialization.Serialize(list.ToArray(), path);
        }

        public static void Load(string path)
        {
            list = DataSerialization.Deserialize<Item>(path).ToList();
        }

    }
}

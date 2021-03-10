using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
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
            T[] obj = null;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T[]));
                try
                {
                    obj = (T[])formatter.Deserialize(fs);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return obj;
        }
    }
}

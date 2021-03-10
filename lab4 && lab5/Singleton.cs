using System.Drawing;

namespace lab2
{
    class Singleton
    {
        private static Singleton _singleton;
        public Color Color { get; set; }
        public Color ForeColor { get; set; }

        private Singleton()
        {
            Color = Color.Bisque;
            ForeColor = Color.Indigo;
        }
        
        public static Singleton GetInstance()
        {
            return _singleton ?? (_singleton = new Singleton());
        }

    }
}

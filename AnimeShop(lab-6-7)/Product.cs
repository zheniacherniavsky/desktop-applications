using System;

namespace AnimeShop_lab_6_7_
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value > 5) _rating = 5;
                else if (value < 0) _rating = 0;
                else _rating = value;
            }
        }
    }
}

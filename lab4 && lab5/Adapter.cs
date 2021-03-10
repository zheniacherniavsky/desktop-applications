using System;

namespace lab2
{
    // Адаптер
    class Adapter : Product
    {
        private Adaptee adaptee = new Adaptee();
        public override void Show()
        {
            adaptee.SpecialShow();
        }
    }

    // Адаптируемый класс
    class Adaptee
    {
        private string name = "Adaptee class";
        private int year = 2020;
        public void SpecialShow()
        {
            Console.WriteLine($"{name}, {year} year");
        }
    }
}

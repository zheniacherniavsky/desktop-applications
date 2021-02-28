using System;
using System.Windows.Forms;

namespace lab2
{
    public enum Settings
    {
        None,
        Uppercase
    }

    interface IBuilder
    {
        Product BuildOrder(object where, Settings option = Settings.None);
    }
    
    class OrderBuilder : IBuilder
    {
        public Product BuildOrder(object where, Settings option = Settings.None)
        {

            MainWindow m = (MainWindow)(where as Button)?.Parent;
            Product product = new Product();

            switch(option)
            {
                case Settings.None:
                    {
                        product.Name = m.productName.Text;
                        product.Number = m.productNumber.Text;
                        product.Size = $"{m.productWidth.Value}x{m.productLength.Value}x{m.productHeight.Value} (ШхДхВ)";

                        if (m.productMaterial.SelectedItems.Count != 0)
                            product.MaterialType = m.productMaterial.SelectedItem.ToString();
                        else product.MaterialType = String.Empty;

                        product.Date = m.productDate.Value.ToString();

                        if (m.countMoreTen.Checked) product.Count = "Больше 10";
                        else if (m.countLessTen.Checked) product.Count = "Меньше 10";
                        else product.Count = "Неопределенное количество";

                        product.producer.Organization = m.producerOrganization.Text;
                        product.producer.Country = m.producerCountry.Text;
                        product.producer.Address = m.producerAddress.Text;
                        product.producer.PhoneNumber = m.producerPhone.Text;
                    }
                    break;
                case Settings.Uppercase:
                    {
                        product.Name = m.productName.Text.ToUpper();
                        product.Number = m.productNumber.Text.ToUpper();
                        product.Size = $"{m.productWidth.Value}x{m.productLength.Value}x{m.productHeight.Value} (ШхДхВ)";

                        if (m.productMaterial.SelectedItems.Count != 0)
                            product.MaterialType = m.productMaterial.SelectedItem.ToString().ToUpper();
                        else product.MaterialType = String.Empty;

                        product.Date = m.productDate.Value.ToString();

                        if (m.countMoreTen.Checked) product.Count = "Больше 10";
                        else if (m.countLessTen.Checked) product.Count = "Меньше 10";
                        else product.Count = "Неопределенное количество";

                        product.producer.Organization = m.producerOrganization.Text.ToUpper();
                        product.producer.Country = m.producerCountry.Text.ToUpper();
                        product.producer.Address = m.producerAddress.Text.ToUpper();
                        product.producer.PhoneNumber = m.producerPhone.Text.ToUpper();
                    }
                    break;
                default:
                    product = null;
                    break;
            }

            return product;
        }
    }
}

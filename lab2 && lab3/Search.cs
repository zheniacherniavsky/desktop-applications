using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchOutputBox.Text = "";
            string searchProductName = productNameSearch.Text;
            string searchMaterial = materialSearch.Text;

            if(searchProductName == String.Empty && searchMaterial == String.Empty)
            {
                searchOutputBox.Text = "Введите запрос";
                return;
            }

            if (searchProductName != String.Empty)
            {
                var firstSearchResponse = from i in Product.ProductsList
                                          where i.Name.Contains(searchProductName)
                                          select i;

                if (searchMaterial != String.Empty)
                {
                    var secondSearchResponse = from i in firstSearchResponse
                                               where i.MaterialType == searchMaterial
                                               select i;

                    foreach (Product p in secondSearchResponse)
                    {
                        searchOutputBox.Text += $"НОМЕР: {p.Number}" + Environment.NewLine;
                    }
                    return;
                }

                foreach (Product p in firstSearchResponse)
                {
                    searchOutputBox.Text += $"НОМЕР: {p.Number}" + Environment.NewLine;
                }
            }
            else searchOutputBox.Text = "Обязательно укзажите название товара в поиск!";
        }
    }
}

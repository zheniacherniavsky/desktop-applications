using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Calculator : Form
    {

        List<string> operations = new List<string>();
        List<int> numbers = new List<int>();
        string number = "";

        string memory;

        public Calculator()
        {
            InitializeComponent();
        }

        private int calculate()
        {
            int result = 0;
            if (numbers.Count != 0)
            {
                result = numbers.First(); numbers.Remove(numbers.First());
            }
            
            string operation;
            try
            {
                do
                {
                    if (result > 64000) throw new Exception("Превышен лимит");
                    operation = operations.First(); operations.Remove(operations.First());
                    switch(operation)
                    {
                        case "+":
                            result += numbers.First(); numbers.Remove(numbers.First());
                            break;
                        case "-":
                            result -= numbers.First(); numbers.Remove(numbers.First());
                            break;
                        case "/":
                            if (number.First() == 0) throw new Exception("Деление на ноль");
                            result /= numbers.First(); numbers.Remove(numbers.First());
                            break;
                        case "*":
                            result *= numbers.First(); numbers.Remove(numbers.First());
                            break;
                        case "%":
                            result = result % int.Parse(number.First().ToString()); numbers.Remove(numbers.First());
                            break;
                    }
                } while (numbers.Count != 0 && operations.Count != 0);

                answer.Text = result.ToString();
            }
            catch(Exception e)
            {
                answer.Text = "";
                operations.Clear();
                numbers.Clear();
                number = "";
                MessageBox.Show(e.Message);
            }

            return result;
        }
        
        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (answer.Text == "") return;
            answer.Text = answer.Text.Remove(answer.Text.Length - 1);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            answer.Text = "";
            numbers.Clear();
            operations.Clear();
            number = "";
        }

        // nums
        private void number_Click(object sender, EventArgs e)
        {
            answer.Text = answer.Text + (sender as Button).Text;
            number += (sender as Button).Text;
        }

        // operations
        private void plus_Click(object sender, EventArgs e)
        {
            if (number == "" || answer.Text == "") return;
            answer.Text = answer.Text + '+';
            numbers.Add(Int32.Parse(number));
            operations.Add("+");
            number = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (number == "" || answer.Text == "") return;
            if (number != "")
            {
                answer.Text = answer.Text + '-';
                numbers.Add(Int32.Parse(number));
                operations.Add("-");
                number = "";
            }
            else
            {
                answer.Text = answer.Text + '-';
                number += "-";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (answer.Text == "") return;
            if (operations.Count != 0 && operations.Last() == "%") return;
            if (operations.Count == 0 || operations.Last() != "/")
            {
                answer.Text = answer.Text + '/';
                numbers.Add(Int32.Parse(number));
                operations.Add("/");
                number = "";
            }
            else
            {
                operations.Remove(operations.Last());
                operations.Add("%");
                answer.Text = answer.Text + '/';
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (number == "" || answer.Text == "") return;
            answer.Text = answer.Text + '*';
            numbers.Add(Int32.Parse(number));
            operations.Add("*");
            number = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if(number != "")
            {
                numbers.Add(Int32.Parse(number));
                number = calculate().ToString();
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            memory = answer.Text;
            number = "";
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (memory != null)
            {
                numbers.Clear();
                operations.Clear();
                answer.Text = memory;
                number = memory;
            }
            else
            {
                MessageBox.Show("Память пуста");
            }
        }
    }
}

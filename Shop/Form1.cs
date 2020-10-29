using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        List<Gas> gas;
        List<Product> products;

        List<CheckBox> checkBoxes;
        List<TextBox> textBoxes;
        List<NumericUpDown> numericUpDowns;
        public Form1()
        {
            InitializeComponent();
            gas = new List<Gas>
            {
                new Gas{Name = "A-95", Price = 22.50M},
                new Gas{Name = "A-98", Price = 24.20M},
                new Gas{Name = "A-98 Premium", Price = 25.10M},
                new Gas{Name = "Дизель", Price = 18.53M},
                new Gas{Name = "Газ", Price = 12.50M}
            };

            products = new List<Product>
            {
                new Product{Name = "Кофе", Price = 8.00M},
                new Product{Name = "Хот-Дог", Price = 50.00M},
                new Product{Name = "Чай", Price = 8.00M},
                new Product{Name = "Булочка", Price = 10.00M},
                new Product{Name = "Пирожок", Price = 15.00M},
                new Product{Name = "Вода", Price = 10.00M},
                new Product{Name = "Лимонад", Price = 20.00M},
                new Product{Name = "Сигареты", Price = 60.00M}
            };

            foreach (var item in gas)
            {
                comboBoxGas.Items.Add(item.Name);
            }
            comboBoxGas.SelectedIndex = 0;

            radBtnAmount.Checked = true;

            checkBoxes = new List<CheckBox>(products.Count);
            textBoxes = new List<TextBox>(products.Count);
            numericUpDowns = new List<NumericUpDown>(products.Count);

            for (int i = 0; i < products.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new System.Drawing.Point(16, 14 + 30 * i);
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.Text = products[i].Name;
                checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
                panel1.Controls.Add(checkBox);
                checkBoxes.Add(checkBox);

                TextBox textBox = new TextBox();
                textBox.Size = new System.Drawing.Size(42, 20);
                textBox.Location = new System.Drawing.Point(118, 11 + 30 * i);
                textBox.Text = products[i].Price.ToString();
                textBox.TextAlign = HorizontalAlignment.Right;
                textBox.Enabled = false;
                panel1.Controls.Add(textBox);
                textBoxes.Add(textBox);

                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Size = new System.Drawing.Size(55, 20);
                numericUpDown.Location = new System.Drawing.Point(181, 11 + 30 * i);
                numericUpDown.Enabled = false;
                panel1.Controls.Add(numericUpDown);
                numericUpDowns.Add(numericUpDown);

            }

            //this.checkBox1.Location = new System.Drawing.Point(16, 14);
            //this.checkBox1.Size = new System.Drawing.Size(80, 17);

            //this.textBox4.Size = new System.Drawing.Size(42, 20);
            //this.textBox1.Location = new System.Drawing.Point(118, 11);

            //this.numericUpDown4.Size = new System.Drawing.Size(55, 20);
            //this.numericUpDown1.Location = new System.Drawing.Point(181, 11);

        }

        private void comboBoxGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            labPrice.Text = gas[comboBoxGas.SelectedIndex].Price.ToString();

            textBoxAmount.Text = "";
            textBoxSum.Text = "";
            radBtnAmount.Checked = true;
            GetTotalSum();
        }

        private void radBtnAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnAmount.Checked == true)
            {
                this.textBoxSum.TextChanged -= new System.EventHandler(this.textBoxSum_TextChanged);
                this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            }
            else
            {
                this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
                this.textBoxAmount.TextChanged -= new System.EventHandler(this.textBoxAmount_TextChanged);
            }
            textBoxAmount.Enabled = true;
            textBoxSum.Enabled = false;
            textBoxSum.Text = "";
            GetTotalSum();
        }

        private void radBtnSum_CheckedChanged(object sender, EventArgs e)
        {
            
            textBoxAmount.Enabled = false;
            textBoxSum.Enabled = true;
            textBoxAmount.Text = "";
            GetTotalSum();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxAmount.Text) && !String.IsNullOrEmpty(labPrice.Text))
                textBoxSum.Text = Math.Round(decimal.Parse(textBoxAmount.Text) *
                    decimal.Parse(labPrice.Text), 2).ToString();
            GetTotalSum();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSum.Text) && !String.IsNullOrEmpty(labPrice.Text))
                textBoxAmount.Text = Math.Round(decimal.Parse(textBoxSum.Text) /
                    decimal.Parse(labPrice.Text), 2).ToString();
            GetTotalSum();
        }

        void GetTotalSum()
        {
            labSumAZS.Text = textBoxSum.Text;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if(checkBox.Checked == true)
                numericUpDowns[checkBoxes.IndexOf(checkBox)].Enabled = true;
            else
                numericUpDowns[checkBoxes.IndexOf(checkBox)].Enabled = false;
        }
    }

    class Gas
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}

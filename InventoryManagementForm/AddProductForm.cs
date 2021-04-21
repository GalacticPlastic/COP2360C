using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementForm
{
    public partial class AddProductForm : Form
    {
        Product product = new Product();
        public AddProductForm()
        {
            InitializeComponent();

            List<Product> products = new List<Product>();

            product.Name = "Potato";
            product.ModelNumber = 1056302;
            product.Manufacturer = "Idaho";
            product.Quantity = 5;
            product.Height = 1.10;  // UOM: inches
            product.Width = 4.25;   // UOM: inches
            product.Weight = 3.9;   // UOM: ounces
            product.Price = 1.99;



            // TODO: Category array options.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

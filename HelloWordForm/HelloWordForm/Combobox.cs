using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWordForm
{
    public partial class Combobox : Form
    {
        public List<String> Brands { get; set; } = new List<string>(new string[] 
        {"Honda" , "Toyota" , "Huyndai" , "Audi" , "Kia"}
        );
        public Combobox()
        {
            InitializeComponent();
            //comboBoxBrand.DataSource = Brands;
            comboBoxBrand.SelectedIndex = -1;
            comboBoxBrand.Items.AddRange(Brands.ToArray());
            comboBoxBrand.Items.Add("Vinfast");
            comboBoxBrand.Items.Insert(1, "Meme");
        }

        private void Button_click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn hãng : " + comboBoxBrand.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxBrand.Items.Add(textBoxBrand.Text);
        }
    }
}

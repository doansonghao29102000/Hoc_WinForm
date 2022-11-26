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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
            var brands = new String[] { "App", "Samsung", "Iphone", "Xiaomi", "Nokia", "Huawei" };
            listBoxBrands.Items.AddRange(brands);
            listBoxBrands.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = "";
            var selectedItems = listBoxBrands.SelectedItems;
            foreach(var item in selectedItems)
            {
                str += item.ToString() + "\n";
            }
            MessageBox.Show(str);
        }
    }
}

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
    public partial class Formbox : Form
    {
        public Formbox()
        {
            InitializeComponent();
        }

        private void radioButtonClicked(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                MessageBox.Show("Đáp án chính xác");
            }
            else if (radioButton11.Checked)
            {
                MessageBox.Show("Đáp án không chính xác");
            }
            else if (radioButton6.Checked)
            {
                MessageBox.Show("Đáp án không chính xác");
            }
            else if (radioButton9.Checked)
            {
                MessageBox.Show("Đáp án không chính xác");
            }
        }

        private void CheckboxClicked(object sender, EventArgs e)
        {

        }
    }
}

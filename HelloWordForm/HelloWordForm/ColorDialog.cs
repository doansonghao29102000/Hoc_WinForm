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
    public partial class ColorDialog : Form
    {
        public ColorDialog()
        {
            InitializeComponent();
        }

        private void ChangeColorHandler(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            var selectedColor = colorDialog1.Color;
            this.BackColor= selectedColor;
        }
    }
}

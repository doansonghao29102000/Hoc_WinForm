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
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void DateSelectedHandler(object sender, EventArgs e)
        {
            var selectedDateTime = dateTimePicker1.Value;
            var dayOfWeek = selectedDateTime.DayOfWeek;
            MessageBox.Show("Day Of Week : " + dayOfWeek.ToString());
        }
    }
}

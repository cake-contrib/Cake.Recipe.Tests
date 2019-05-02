using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "2 + 2 = " + MathClass.Add(2, 2);
            UpdateLabelLocation();
        }

        public void UpdateLabelLocation()
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            UpdateLabelLocation();
        }
    }
}

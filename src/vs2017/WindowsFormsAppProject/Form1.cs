using System;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = $"2 + 2 = {MathClass.Add(2, 2)}";
            UpdateLabelLocation();
        }

        private void UpdateLabelLocation()
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
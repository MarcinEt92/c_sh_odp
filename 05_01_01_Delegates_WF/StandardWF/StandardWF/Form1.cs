using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogPlainEvent(object sender, EventArgs e)
        {
            textBox1.Text = "Clicked!";
        }

        private void MousePlainEvent(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Mouse Event";
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_01_Delegates_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogPlainEvent(object sender, EventArgs e)
        {
            textBox1.Text = "LogPlainEvent";
        }

        void LogKeyEvent(object sender, EventArgs e)
        {
            textBox1.Text = "LogKeyEvent";
        }

        void LogMouseEvent(object sender, EventArgs e)
        {
            textBox1.Text = "LogKeyEvent";
        }

    }
}

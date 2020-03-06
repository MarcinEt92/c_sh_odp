using System.Drawing;
using System.Windows.Forms;

namespace _05_01_01_Delegates_WF
{
    partial class Form1
    {
        

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.button1 = new Button();
            this.textBox1 = new TextBox();

            button1.Text = "Click Me";

            this.KeyPress += LogKeyEvent;
            button1.Click += LogPlainEvent;

            textBox1.Location = new Point(0, 50);

            this.Controls.Add(button1);
            this.Controls.Add(textBox1);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLL;
namespace Winform_app
{
    public partial class Form1 : Form
    {
        Class1 cipher = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cipher.PlainText = textBox1.Text;
            cipher.Encrypt();
            textBox1.Text = cipher.CipherText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cipher.CipherText = textBox2.Text;
            cipher.Decrypt();
            textBox2.Text = cipher.DecryptedText;
        }
    }
}

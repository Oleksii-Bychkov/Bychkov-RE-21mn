using System;
using System.Windows.Forms;

namespace cryptoRtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnPasswordChange(object sender, EventArgs e)
        {
            if (loginBox.Text == "login" && passBox.Text == "password")
                MessageBox.Show( "Hello World!");
            else
                MessageBox.Show("Not hello");
        }
    }
}
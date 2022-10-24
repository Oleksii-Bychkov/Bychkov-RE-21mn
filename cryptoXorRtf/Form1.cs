using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptoXorRtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool IsBinary(string val)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                return false;
            return new Regex(@"^\b[01]+\b$").IsMatch(val);
        }
        
        private void OnXorClick(object sender, EventArgs e)
        {
            if (!IsBinary(pBox.Text) || !IsBinary(keyBox.Text))
            {
                MessageBox.Show("Wrong format or value is empty");
                return;
            }

            var intP = Convert.ToInt32(pBox.Text, 2);
            var intKey = Convert.ToInt32(keyBox.Text, 2);
            var intC = intP ^ intKey;
            cBox.Text = Convert.ToString(intC, 2);
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            pBox.Text = "";
            keyBox.Text = "";
            cBox.Text = "";
        }
    }
}
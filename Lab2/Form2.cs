using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cryptoXorRtf
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OnPBoxChanged(object sender, EventArgs e)
        {
            if (!IsHex(pBox.Text))
            {
                pLabel.Text = "";
                return;
            }
            try
            {
                var intP = Convert.ToInt32(pBox.Text, 16);
                pLabel.Text = $"B:{Convert.ToString(intP, 2)}\nD: {intP}\nH: {pBox.Text}";
            }
            catch (Exception)
            {
                pLabel.Text = "";
            }
        }
        
        private void OnKeyBoxChanged(object sender, EventArgs e)
        {
            if (!IsHex(keyBox.Text))
            {
                keyLabel.Text = "";
                return;
            }
            try
            {
                var intKey = Convert.ToInt32(keyBox.Text, 16);
                keyLabel.Text = $"B:{Convert.ToString(intKey, 2)}\nD: {intKey}\nH: {keyBox.Text}";
            }
            catch (Exception)
            {
                keyLabel.Text = "";
            }
        }

        private void OnKeyReverseBoxChanged(object sender, EventArgs e)
        {
            if (!IsHex(keyReverseBox.Text))
            {
                keyReverseLabel.Text = "";
                return;
            }

            try
            {
                var intKey = Convert.ToInt32(keyReverseBox.Text, 16);
                keyReverseLabel.Text = $"B:{Convert.ToString(intKey, 2)}\nD: {intKey}\nH: {keyReverseBox.Text}";
            }
            catch (Exception)
            {
                keyReverseLabel.Text = "";
            }
        }

        private void OnCReverseBoxChanged(object sender, EventArgs e)
        {
            if (!IsHex(cReverseBox.Text))
            {
                cReverseLabel.Text = "";
                return;
            }

            try
            {
                var intC = Convert.ToInt32(cReverseBox.Text, 16);
                cReverseLabel.Text = $"B:{Convert.ToString(intC, 2)}\nD: {intC}\nH: {cReverseBox.Text}";
            }
            catch (Exception)
            {
                cReverseLabel.Text = "";
            }
        }

        private static bool IsHex(string val)
        {
            
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                return false;
            return new Regex(@"^[0-9a-fA-F]+$").IsMatch(val);
        }
        
        private void OnXorClick(object sender, EventArgs e)
        {
            if (!IsHex(pBox.Text) || !IsHex(keyBox.Text))
            {
                MessageBox.Show("Wrong format or value is empty");
                return;
            }

            int intP, intKey;
            try
            {
                intP = Convert.ToInt32(pBox.Text, 16);
                intKey = Convert.ToInt32(keyBox.Text, 16);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong format or value is too big to convert to int32");
                return;
            }
            
            long intC = intP ^ intKey;
            
            var cBoxText = Convert.ToString(intC, 16);
            cLabel.Text = $"B:{Convert.ToString(intC, 2)}\nD: {intC}\nH: {cBoxText}";
            cBox.Text = cBoxText;
            
            // reverse
            if (!IsHex(cReverseBox.Text) || !IsHex(keyReverseBox.Text))
                return;

            int intRevertC, intRevertKey;
            try
            {
                intRevertC = Convert.ToInt32(cReverseBox.Text, 16);
                intRevertKey = Convert.ToInt32(keyReverseBox.Text, 16);
            }
            catch (Exception)
            {
                return;
            }
            var intRevertP = intRevertC ^ intRevertKey;
            var pReverseBoxText = Convert.ToString(intRevertP, 16);
            
            pReverseLabel.Text = $"B:{Convert.ToString(intRevertP, 2)}\nD: {intRevertP}\nH: {pReverseBoxText}";
            pReverseBox.Text = pReverseBoxText;
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            pBox.Text = "";
            keyBox.Text = "";
            cBox.Text = "";
            cLabel.Text = "";
            
            pReverseBox.Text = "";
            pReverseLabel.Text = "";
            keyReverseBox.Text = "";
            cReverseBox.Text = "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptoRtfHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte[] myEncoding(byte[] inArr)
        {
            byte[] result = { 0 };

            if (rB_CRC32.Checked == true)
            {
                uint a = Crc.Crc32(inArr);
                return BitConverter.GetBytes(a);
            }

            if (rB_HAVAL.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(inArr);
            }

            if (rB_RIPEMD160.Checked == true)
            {
                HashAlgorithm sha = RIPEMD160.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_MD5.Checked == true)
            {
                HashAlgorithm sha = MD5.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA1.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA256.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA384.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA512.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(inArr);
            }

            return result;
        }

        private void bInFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Шлях до файлу
                    string fileINpath = openFileDialog.FileName;
                    tInFilePath.Text = fileINpath;
                    var fileInfo = new FileInfo(fileINpath);
                    inFileLabel.Text = "Вхідного файлу: " + fileInfo.Length;
                }
            }
        }

        private void bOutFile_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Шлях до файлу
                string fileOutpath = saveFileDialog.FileName;
                tOutFilePath.Text = fileOutpath;
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tInFilePath.Text)) return;
            byte[] inArr = File.ReadAllBytes(tInFilePath.Text);
            var stopwatch = new Stopwatch();
            // Begin timing.
            stopwatch.Start();
            var outArr = myEncoding(inArr);
            stopwatch.Stop();
            label_time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
            // Write result.
            File.WriteAllBytes(tOutFilePath.Text, outArr); // створюємо новий файл і записуємо у нього 
            string result = BitConverter.ToString(outArr).Replace("-", "");
            var fileInfo = new FileInfo(tOutFilePath.Text);
            outFileLabel.Text = "Вихідного файлу: " + fileInfo.Length;
            MessageBox.Show("У файлі записане число (контрольна сума вхідного файлу):\n" + result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bClean_Click(object sender, EventArgs e)
        {
            tInFilePath.Text = "";
            tOutFilePath.Text = "";
            inFileLabel.Text = "Вхідного файлу: ???";
            outFileLabel.Text = "Вихідного файлу: ???";
            rB_CRC32.Checked = false;
            rB_HAVAL.Checked = false;
            rB_RIPEMD160.Checked = false;
            rB_MD5.Checked = false;
            rB_SHA1.Checked = false;
            rB_SHA256.Checked = false;
            rB_SHA384.Checked = false;
            rB_SHA512.Checked = false;
        }

        private void authorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Oleksiy Bychkov");
        }

        private void descriptionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Example of hashing algorithms");
        }
    }
}
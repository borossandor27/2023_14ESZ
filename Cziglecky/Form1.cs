using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ForrasFajlBetoltese_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "orszagok.csv";
            openFileDialog1.Filter = "Felahsználó látja |*.csv|szövegfájl|*.txt";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {

            }
        }
    }
}

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
using MySql.Data.MySqlClient;

namespace WindowsFormsAppObjectList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //beolvasasSzovegfajlbol();
            beolvasasAdatbazisból();
        }

        private void beolvasasAdatbazisból()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "szerszamok";
            sb.CharacterSet = "utf8";
            MySqlConnection connection = new MySqlConnection(sb.ConnectionString);
            MySqlCommand command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "SELECT `szerszamId`,`megnevezes`,`egysegar`,`darabszam` FROM `szarszamok` WHERE 1 ORDER BY `megnevezes`";
                using (MySqlDataReader dr=command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Szerszam szerszam = new Szerszam(dr.GetInt32("szerszamId"), dr.GetString("megnevezes"), dr.GetDecimal("egysegar"), dr.GetDecimal("darabszam"));
                        listBox_Szerszamok.Items.Add(szerszam);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void beolvasasSzovegfajlbol()
        {
            using (StreamReader sr = new StreamReader("szerszamok.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    Szerszam szerszam = new Szerszam(int.Parse(sor[0].Trim()), sor[1], decimal.Parse(sor[2]), decimal.Parse(sor[3]));
                    listBox_Szerszamok.Items.Add(szerszam);
                }
            }
        }

        private void listBox_Szerszamok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Szerszamok.SelectedIndex<0)
            {
                return;
            }
            Szerszam kivalasztottSzerszam = (Szerszam)listBox_Szerszamok.SelectedItem;

            textBox_toolId.Text = kivalasztottSzerszam.szerszamId.ToString();
            textBox_toolName.Text = kivalasztottSzerszam.megnevezes;
            numericUpDown_egysegar.Value = kivalasztottSzerszam.egysegar;
            numericUpDown_Mennyiseg.Value = kivalasztottSzerszam.darabszam;
        }
    }
}

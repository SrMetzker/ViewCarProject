using System;
using System.IO;
using System.Windows.Forms;

namespace ProjetoCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeCarros = Directory.GetFiles(@"C:\Users\lucca\Documents\Projetos\Codificados\ProjetoCarros\ImagensCarros\");

            foreach (string img in nomeCarros)
            {
                string[] separador = img.Split('\\');
                string[] carro = separador[8].Split('.');
                if (comboBox2.Text == carro[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\lucca\Documents\Projetos\Codificados\ProjetoCarros\ImagensCarros\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            if(comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ARGO");
                comboBox2.Items.Add("MOB");
            }
            else if(comboBox1.Text == "FORD") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("KA");
                comboBox2.Items.Add("ECOSPORT");
            }
            else if (comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ONIX");
                comboBox2.Items.Add("CELTA");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatyUkol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            double minimalni = int.MaxValue;
            double prumer = 0, pocet = 0, soucet = 0, prvnipozice = 0, poslednipozice = 0, pocetciselv = 0, soucetvsech = 0;
            bool prvni = false;
            double pocetcisel = Convert.ToDouble(textBox1.Lines.Count());
            try
            {
                for (int i = 0; i < pocetcisel; i++)
                {

                    if (textBox1.Lines[i] != "")
                    {
                        pocet++;
                        double cislo = Convert.ToDouble(textBox1.Lines[i]);
                        soucet += cislo;
                        if (cislo < minimalni)
                        {
                            minimalni = cislo;
                        }
                        if (cislo == 3 && prvni == false)
                        {
                            prvnipozice = pocet;
                            prvni = true;
                        }
                        if (cislo == 3) poslednipozice = pocet;
                        if (cislo >= 5 && cislo < 30) pocetciselv++;
                    }
                }
                foreach (string prvek in textBox1.Lines)
                    if (prvek != "")
                    {
                        soucetvsech += Convert.ToDouble(prvek);
                    }
                prumer = soucet / pocet;
                prumer = Math.Round(prumer, 3);
                if (pocetcisel > 0)
                {
                    if (prumer != 0) label1.Text = Convert.ToString(prumer);
                    else label1.Text = "";
                    if (minimalni > double.MinValue) label10.Text = Convert.ToString(minimalni);
                    else label10.Text = "";
                    if (pocetciselv > 0) label11.Text = Convert.ToString(pocetciselv);
                    else label11.Text = "";
                    if (soucetvsech != 0) label14.Text = Convert.ToString(soucetvsech);
                    else label14.Text = "";
                    if (prvnipozice == 0 || pocet == 0)
                    {
                        label12.Text = "";
                        label13.Text = "";
                    }
                    else
                    {
                        label12.Text = Convert.ToString(prvnipozice);
                        label13.Text = Convert.ToString(poslednipozice);
                    }
                }
                else
                {
                    label1.Text = "";
                    label10.Text = "";
                    label11.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    label14.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Něco se nepovedlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V komponentě TextBox – víceřádkové je několik čísel. \nPomocí cyklu for - spočítejte průměr čísel, vypište minimální číslo, počet čísel v intervalu < 5, 30), pozice první a poslední 3.\nPomocí cyklu foreach spočítejte součet všech čísel v textBoxu.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    
    }
}

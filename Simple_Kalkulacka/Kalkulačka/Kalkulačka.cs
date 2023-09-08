using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulačka
{
    public partial class Kalkulačka : Form
    {
        public Kalkulačka()
        {
            InitializeComponent();
            cobOperace.SelectedIndex = 0;
        }

        private void cobOperace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVypocitej_Click(object sender, EventArgs e)
        {
            if (txtCislo1.Text=="" || txtCislo2.Text == "")
            {
                MessageBox.Show("Prosím vyplňte čísla");
            }
            else
            {
                double c1 = Convert.ToDouble(txtCislo1.Text);
                double c2 = double.Parse(txtCislo2.Text);
                double vysledek;
                switch (cobOperace.Text)
                {
                    case "+":
                        vysledek = c1 + c2;
                        lblHlaska.Text = vysledek.ToString();
                        break;
                    case "-":
                        vysledek = c1 - c2;
                        lblHlaska.Text = vysledek.ToString();
                        break;
                    case "*":
                        vysledek = c1 * c2;
                        lblHlaska.Text = vysledek.ToString();
                        break;
                    case "/":
                        if (c2 == 0)
                        {
                            lblHlaska.Text = "Nulou nelze dělit";
                        }
                        else
                        {
                            vysledek = c1 / c2;
                            lblHlaska.Text = vysledek.ToString();
                        }
                        break;
                    case "mocnina":
                        vysledek = Math.Pow(c1, c2);
                        lblHlaska.Text = vysledek.ToString();
                        break;
                    case "odmocnina":
                        if (c1 < 0)
                        {
                            lblHlaska.Text = "Nelze vypočítat odmocninu ze záporného čísla";
                        }
                        else
                        {
                            vysledek = Math.Sqrt(c1);
                            lblHlaska.Text = vysledek.ToString();
                        }
                        if (c2 < 0)
                        {
                            lblHlaska.Text += "a neleze vypočítat odmocninu ze záporného čísla";
                        }
                        else
                        {
                            vysledek = Math.Sqrt(c2);
                            lblHlaska.Text += " odmocnina z " + c2 + " = " + vysledek.ToString();
                        }
                        break;
                    default:
                        lblHlaska.Text = "Nezvolil jste žádnou operaci";
                        break;
                }
                txtCislo1.Text = "";
                txtCislo2.Text = "";
                cobOperace.SelectedIndex = 0;
            }       
        }

        private void lblHlaska_Click(object sender, EventArgs e)
        {

        }

        private void Kalkulačka_Load(object sender, EventArgs e)
        {

        }
    }
}

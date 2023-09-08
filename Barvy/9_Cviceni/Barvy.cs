using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUR_9
{
    public partial class Barvy : Form
    {
        //string pro jednotlivé barvy
        private string[] barvy = new string[8]
        {
            "Černá",
            "Červená",
            "Modrá",
            "Žlutá",
            "Oranžová",
            "Zelená",
            "Hnědá",
            "Bílá"
        };

        public Barvy()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Vypne program
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Vybranou barvu zaškrtne v listboxu
        private void btnVyberBarvy_Click(object sender, EventArgs e)
        {
            foreach (string str in this.listBoxBarva.Items)
            {
                for (int index = 0; index < this.barvy.Length; ++index)
                {
                    if (str.ToString() == this.barvy[index].ToString())
                        this.checkedListBox1.SetItemChecked(index, true);
                }
            }
        }


        //Smaže vybranou barvu
        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = this.listBoxBarva.SelectedItem.ToString();
            this.listBoxBarva.Items.Remove(this.listBoxBarva.SelectedItem);
            for (int index = 0; index < this.barvy.Length; ++index)
            {
                if (this.barvy[index].ToString() == str)
                    this.checkedListBox1.SetItemChecked(index, false);
            }
        }


        //Přidá barvu z comboboxu
        private void btnPridejBarvu_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            foreach (string str in this.listBoxBarva.Items)
            {
                if (str.ToString() == this.comboBoxBarva.Text)
                    ++num1;
            }
            if (num1 == 0)
            {
                this.listBoxBarva.Items.Add((object)this.comboBoxBarva.Text);
                this.listBoxBarva.Sorted = true;
            }
            else
            {
                int num2 = (int)MessageBox.Show("Tato barva již je přidána!");
            }
        }

        private void listBoxBarva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Doubleclick otevře nové okno
        private void listBoxBarva_DoubleClick(object sender, EventArgs e)
        {
            Okno okno = new Okno();
            switch (this.listBoxBarva.SelectedItem.ToString())
            {
                case "Bílá":
                    okno.BackColor = Color.White;
                    okno.Text += " bílé";
                    break;
                case "Hnědá":
                    okno.BackColor = Color.Brown;
                    okno.Text += " hnědé";
                    break;
                case "Modrá":
                    okno.BackColor = Color.Blue;
                    okno.Text += " modré";
                    break;
                case "Oranžová":
                    okno.BackColor = Color.Orange;
                    okno.Text += " oranžové";
                    break;
                case "Zelená":
                    okno.BackColor = Color.Green;
                    okno.Text += " zelené";
                    break;
                case "Černá":
                    okno.BackColor = Color.Black;
                    okno.Text += " černé";
                    break;
                case "Červená":
                    okno.BackColor = Color.Red;
                    okno.Text += " červené";
                    break;
                case "Žlutá":
                    okno.BackColor = Color.Yellow;
                    okno.Text += " žluté";
                    break;
            }
            int num = (int)okno.ShowDialog();
        }
    }
}

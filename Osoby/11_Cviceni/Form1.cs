using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _11_Cviceni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void souborToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVlozJmeno_Click(object sender, EventArgs e)
        {
            if (this.txtJmeno.Text != "")
            {
                this.listBoxJmena.Items.Add((object)this.txtJmeno.Text);
                this.txtJmeno.Text = "";
                this.txtJmeno.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Vyplňte prosím jméno", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVlozPrijmeni_Click(object sender, EventArgs e)
        {
            if (this.txtPrijmeni.Text != "")
            {
                this.listBoxPrijmeni.Items.Add((object)this.txtPrijmeni.Text);
                this.txtPrijmeni.Text = "";
                this.txtPrijmeni.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Vyplňte prosím příjmení", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Opravdu chcete program ukončit?", "Ukončení programu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                Application.Exit();
            }
        }

        private void jménoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textový soubor (*.txt) | *.txt";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            for (int index = 0; index < this.listBoxJmena.Items.Count; ++index)
                streamWriter.WriteLine(this.listBoxJmena.Items[index]);
            streamWriter.Close();
        }

        private void příjmeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textový soubor (*.txt) | *.txt";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            for (int index = 0; index < this.listBoxPrijmeni.Items.Count; ++index)
                streamWriter.WriteLine(this.listBoxPrijmeni.Items[index]);
            streamWriter.Close();
        }

        private void jménoPříjmeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBoxJmena.Items.Count == this.listBoxPrijmeni.Items.Count)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Textový soubor (*.txt) | *.txt";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                for (int index = 0; index < this.listBoxJmena.Items.Count; ++index)
                    streamWriter.WriteLine(this.listBoxJmena.Items[index]?.ToString() + " " + this.listBoxPrijmeni.Items[index]?.ToString());
                streamWriter.Close();
            }
            else
            {
                int num = (int)MessageBox.Show("Není stejný počet jmen (" + this.listBoxJmena.Items.Count.ToString() + ") a příjmení (" + this.listBoxPrijmeni.Items.Count.ToString() + ")", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void jménoPříjmeníToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            if (MessageBox.Show("Budou importována nová data, chcete stávající smazat?", "Import", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.listBoxJmena.Items.Clear();
                this.listBoxPrijmeni.Items.Clear();
            }
            foreach (string readAllLine in File.ReadAllLines(openFileDialog.FileName.Trim()))
            {
                char[] chArray = new char[1] { ' ' };
                string[] strArray = readAllLine.Split(chArray);
                if (strArray.Length == 2)
                {
                    this.listBoxJmena.Items.Add((object)strArray[0]);
                    this.listBoxPrijmeni.Items.Add((object)strArray[1]);
                }
                else if (strArray.Length == 1)
                    ++num1;
                else if (strArray.Length == 0)
                    ++num1;
            }
            if (num1 > 0)
            {
                int num2 = (int)MessageBox.Show("V textovém souboru bylo celkem " + num1.ToString() + " chybných řádků!");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

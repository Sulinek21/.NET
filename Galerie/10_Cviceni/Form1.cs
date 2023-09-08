using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Cviceni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //VLOŽENÍ OBRÁZKU
        private void btnVloz_Click(object sender, EventArgs e)
        {
            if (this.rbObrVloz1.Checked && this.pictureBox1.Image != null)
            {
                int num1 = (int)MessageBox.Show("PictureBox1 není volný!");
            }
            else if (this.rbObrVloz1.Checked && this.pictureBox1.Image == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Obrázky (*.jpg; *.png)|*.jpg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (this.rbObrVloz2.Checked && this.pictureBox2.Image != null)
            {
                int num2 = (int)MessageBox.Show("PictureBox2 není volný!");
            }
            else if (this.rbObrVloz2.Checked && this.pictureBox2.Image == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Obrázky (*.jpg; *.png)|*.jpg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                    this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (this.rbObrVloz3.Checked && this.pictureBox3.Image != null)
            {
                int num3 = (int)MessageBox.Show("PictureBox3 není volný!");
            }
            else
            {
                if (!this.rbObrVloz3.Checked || this.pictureBox3.Image != null)
                    return;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Obrázky (*.jpg; *.png)|*.jpg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
                    this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        //OTEVŘENÍ NOVÉHO FORM2 - DOUBLECLICK
        private static void Okno(PictureBox pic)
        {
            Form2 form2 = new Form2();
            form2.BackgroundImage = pic.Image;
            form2.BackgroundImageLayout = ImageLayout.Stretch;
            int num = (int)form2.ShowDialog();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Okno(this.pictureBox1);
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Okno(this.pictureBox2);
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            Okno(this.pictureBox3);
        }


        //MAZÁNÍ OBRÁZKŮ
        private void btnSmaz_Click(object sender, EventArgs e)
        {
            if (this.rbObrSmaz1.Checked)
                this.pictureBox1.Image = (Image)null;
            if (this.rbObrSmaz2.Checked)
                this.pictureBox2.Image = (Image)null;
            if (!this.rbObrSmaz3.Checked)
                return;
            this.pictureBox3.Image = (Image)null;
        }


        //ZAŠKRTNUTÍ RADIOBUTTONU
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.rbObrVloz1.Checked = true;
            this.rbObrSmaz1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.rbObrVloz2.Checked = true;
            this.rbObrSmaz2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.rbObrVloz3.Checked = true;
            this.rbObrSmaz3.Checked = true;
        }

        private void rbObrSmaz1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

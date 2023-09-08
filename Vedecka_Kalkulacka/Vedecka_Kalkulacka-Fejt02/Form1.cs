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

namespace CS_Scientific_Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKevin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 300;
            txtDisplay.Width = 266;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 581;
            txtDisplay.Width = 551;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            txtDisplay.Width = 266;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            this.Width = 1023;
            txtDisplay.Width = 551;
            txtConvert.Focus();

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;

            groupBox1.Location = new Point(580, 26);
            groupBox1.Width = 417;
            groupBox1.Height = 368;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1023;
            txtDisplay.Width = 551;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1023;            
            txtDisplay.Width = 551;
            txtMultiply.Focus();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            groupBox3.Location = new Point (580, 26);
            groupBox3.Width = 417;
            groupBox3.Height = 368;





        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
           if (txtDisplay.Text .Length >0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text=="")
            {
                txtDisplay.Text = "0";
            }

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);            

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
            qSin = Math.Sin(qSin);
            txtDisplay.Text = System.Convert.ToString(qSin);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double qcosh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            txtDisplay.Text = System.Convert.ToString(qcosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double qcos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
            qcos = Math.Cosh(qcos);
            txtDisplay.Text = System.Convert.ToString(qcos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtDisplay.Text = System.Convert.ToString(qTanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txtDisplay.Text = System.Convert.ToString(qTan);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);

        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void btnlnx_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void rbCelToFah_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbFahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbKevin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            rbCelToFah.Checked = false;
            rbFahToCel.Checked = false;
            rbKevin.Checked = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMultiply.Text);
            for (int i = 1; i < 13; i ++)
            {

                lstMultiply.Items.Add(i + " x" + a + " = " + a * i);

            }            
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Opravdu chcete program ukončit?", "Ukončení programu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                Application.Exit();
            }
        }

        private void btnResetM_Click(object sender, EventArgs e)
        {
            lstMultiply.Items.Clear();
            txtMultiply.Clear();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (txtDisplay .Text .Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txtDisplay.Text);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
           switch (iOperation)
            {

                case 'C':
                    //Celsius to Fahrenheit
                    iCelsius = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());

                    break;
                case 'F':
                    //Fahrenheit to Celsius
                    iFahrenheit = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;

                case 'K':
                    //Convert to Kevin
                    iKevin = float.Parse(txtConvert.Text);
                    lblConvert.Text = (((((9 * iKevin) / 5) + 32) + 273.15).ToString());

                    break;
            }
        
            
        }
    }
}

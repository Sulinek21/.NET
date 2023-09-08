
namespace Kalkulačka
{
    partial class Kalkulačka
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulačka));
            this.cobOperace = new System.Windows.Forms.ComboBox();
            this.txtCislo1 = new System.Windows.Forms.TextBox();
            this.txtCislo2 = new System.Windows.Forms.TextBox();
            this.lblHlaska = new System.Windows.Forms.Label();
            this.btnVypocitej = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cobOperace
            // 
            this.cobOperace.FormattingEnabled = true;
            this.cobOperace.Items.AddRange(new object[] {
            "Vyberte operaci",
            "+",
            "-",
            "*",
            "/",
            "mocnina",
            "odmocnina"});
            this.cobOperace.Location = new System.Drawing.Point(263, 78);
            this.cobOperace.Name = "cobOperace";
            this.cobOperace.Size = new System.Drawing.Size(121, 23);
            this.cobOperace.TabIndex = 0;
            this.cobOperace.SelectedIndexChanged += new System.EventHandler(this.cobOperace_SelectedIndexChanged);
            // 
            // txtCislo1
            // 
            this.txtCislo1.Location = new System.Drawing.Point(94, 78);
            this.txtCislo1.Name = "txtCislo1";
            this.txtCislo1.Size = new System.Drawing.Size(136, 23);
            this.txtCislo1.TabIndex = 1;
            // 
            // txtCislo2
            // 
            this.txtCislo2.Location = new System.Drawing.Point(430, 78);
            this.txtCislo2.Name = "txtCislo2";
            this.txtCislo2.Size = new System.Drawing.Size(136, 23);
            this.txtCislo2.TabIndex = 2;
            // 
            // lblHlaska
            // 
            this.lblHlaska.AutoSize = true;
            this.lblHlaska.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHlaska.ForeColor = System.Drawing.Color.Red;
            this.lblHlaska.Location = new System.Drawing.Point(263, 160);
            this.lblHlaska.Name = "lblHlaska";
            this.lblHlaska.Size = new System.Drawing.Size(192, 21);
            this.lblHlaska.TabIndex = 3;
            this.lblHlaska.Text = "Zde bude vypsán výsledek";
            this.lblHlaska.Click += new System.EventHandler(this.lblHlaska_Click);
            // 
            // btnVypocitej
            // 
            this.btnVypocitej.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVypocitej.Location = new System.Drawing.Point(94, 160);
            this.btnVypocitej.Name = "btnVypocitej";
            this.btnVypocitej.Size = new System.Drawing.Size(129, 38);
            this.btnVypocitej.TabIndex = 4;
            this.btnVypocitej.Text = "Vypočítej";
            this.btnVypocitej.UseVisualStyleBackColor = true;
            this.btnVypocitej.Click += new System.EventHandler(this.btnVypocitej_Click);
            // 
            // Kalkulačka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 321);
            this.Controls.Add(this.btnVypocitej);
            this.Controls.Add(this.lblHlaska);
            this.Controls.Add(this.txtCislo2);
            this.Controls.Add(this.txtCislo1);
            this.Controls.Add(this.cobOperace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kalkulačka";
            this.Text = "Kalkulačka";
            this.Load += new System.EventHandler(this.Kalkulačka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobOperace;
        private System.Windows.Forms.TextBox txtCislo1;
        private System.Windows.Forms.TextBox txtCislo2;
        private System.Windows.Forms.Label lblHlaska;
        private System.Windows.Forms.Button btnVypocitej;
    }
}


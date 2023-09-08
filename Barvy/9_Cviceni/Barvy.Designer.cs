
namespace NUR_9
{
    partial class Barvy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barvy));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnUkoncitProgram = new System.Windows.Forms.Button();
            this.listBoxBarva = new System.Windows.Forms.ListBox();
            this.btnVyberBarvy = new System.Windows.Forms.Button();
            this.comboBoxBarva = new System.Windows.Forms.ComboBox();
            this.btnPridejBarvu = new System.Windows.Forms.Button();
            this.btnSmazBarvu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Černá",
            "Červená",
            "Modrá",
            "Žlutá",
            "Oranžová",
            "Zelená",
            "Hnědá",
            "Bílá"});
            this.checkedListBox1.Location = new System.Drawing.Point(248, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(102, 220);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnUkoncitProgram
            // 
            this.btnUkoncitProgram.Location = new System.Drawing.Point(248, 238);
            this.btnUkoncitProgram.Name = "btnUkoncitProgram";
            this.btnUkoncitProgram.Size = new System.Drawing.Size(102, 95);
            this.btnUkoncitProgram.TabIndex = 1;
            this.btnUkoncitProgram.Text = "Ukončit program";
            this.btnUkoncitProgram.UseVisualStyleBackColor = true;
            this.btnUkoncitProgram.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxBarva
            // 
            this.listBoxBarva.FormattingEnabled = true;
            this.listBoxBarva.ItemHeight = 15;
            this.listBoxBarva.Location = new System.Drawing.Point(12, 12);
            this.listBoxBarva.Name = "listBoxBarva";
            this.listBoxBarva.Size = new System.Drawing.Size(113, 214);
            this.listBoxBarva.TabIndex = 2;
            this.listBoxBarva.SelectedIndexChanged += new System.EventHandler(this.listBoxBarva_SelectedIndexChanged);
            this.listBoxBarva.DoubleClick += new System.EventHandler(this.listBoxBarva_DoubleClick);
            // 
            // btnVyberBarvy
            // 
            this.btnVyberBarvy.Location = new System.Drawing.Point(131, 12);
            this.btnVyberBarvy.Name = "btnVyberBarvy";
            this.btnVyberBarvy.Size = new System.Drawing.Size(111, 214);
            this.btnVyberBarvy.TabIndex = 3;
            this.btnVyberBarvy.Text = "Vyber dané barvy";
            this.btnVyberBarvy.UseVisualStyleBackColor = true;
            this.btnVyberBarvy.Click += new System.EventHandler(this.btnVyberBarvy_Click);
            // 
            // comboBoxBarva
            // 
            this.comboBoxBarva.FormattingEnabled = true;
            this.comboBoxBarva.Items.AddRange(new object[] {
            "Černa",
            "Červená",
            "Modrá",
            "Žlutá",
            "Oranžová",
            "Zelená",
            "Hnědá",
            "Bílá"});
            this.comboBoxBarva.Location = new System.Drawing.Point(12, 236);
            this.comboBoxBarva.Name = "comboBoxBarva";
            this.comboBoxBarva.Size = new System.Drawing.Size(112, 23);
            this.comboBoxBarva.TabIndex = 4;
            // 
            // btnPridejBarvu
            // 
            this.btnPridejBarvu.Location = new System.Drawing.Point(12, 266);
            this.btnPridejBarvu.Name = "btnPridejBarvu";
            this.btnPridejBarvu.Size = new System.Drawing.Size(111, 26);
            this.btnPridejBarvu.TabIndex = 5;
            this.btnPridejBarvu.Text = "Přidej barvu";
            this.btnPridejBarvu.UseVisualStyleBackColor = true;
            this.btnPridejBarvu.Click += new System.EventHandler(this.btnPridejBarvu_Click);
            // 
            // btnSmazBarvu
            // 
            this.btnSmazBarvu.Location = new System.Drawing.Point(12, 298);
            this.btnSmazBarvu.Name = "btnSmazBarvu";
            this.btnSmazBarvu.Size = new System.Drawing.Size(108, 40);
            this.btnSmazBarvu.TabIndex = 6;
            this.btnSmazBarvu.Text = "Smaž vybranou barvu";
            this.btnSmazBarvu.UseVisualStyleBackColor = true;
            this.btnSmazBarvu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Barvy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 348);
            this.Controls.Add(this.btnSmazBarvu);
            this.Controls.Add(this.btnPridejBarvu);
            this.Controls.Add(this.comboBoxBarva);
            this.Controls.Add(this.btnVyberBarvy);
            this.Controls.Add(this.listBoxBarva);
            this.Controls.Add(this.btnUkoncitProgram);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barvy";
            this.Text = "Barvy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnUkoncitProgram;
        private System.Windows.Forms.ListBox listBoxBarva;
        private System.Windows.Forms.Button btnVyberBarvy;
        private System.Windows.Forms.ComboBox comboBoxBarva;
        private System.Windows.Forms.Button btnPridejBarvu;
        private System.Windows.Forms.Button btnSmazBarvu;
    }
}


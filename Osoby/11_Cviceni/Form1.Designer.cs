
namespace _11_Cviceni
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.příjmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoPříjmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoPříjmeníToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxJmena = new System.Windows.Forms.ListBox();
            this.listBoxPrijmeni = new System.Windows.Forms.ListBox();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.txtPrijmeni = new System.Windows.Forms.TextBox();
            this.btnVlozJmeno = new System.Windows.Forms.Button();
            this.btnVlozPrijmeni = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripMenuItem1,
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "&Soubor";
            this.souborToolStripMenuItem.Click += new System.EventHandler(this.souborToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jménoToolStripMenuItem,
            this.příjmeníToolStripMenuItem,
            this.jménoPříjmeníToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // jménoToolStripMenuItem
            // 
            this.jménoToolStripMenuItem.Name = "jménoToolStripMenuItem";
            this.jménoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jménoToolStripMenuItem.Text = "Jméno";
            this.jménoToolStripMenuItem.Click += new System.EventHandler(this.jménoToolStripMenuItem_Click);
            // 
            // příjmeníToolStripMenuItem
            // 
            this.příjmeníToolStripMenuItem.Name = "příjmeníToolStripMenuItem";
            this.příjmeníToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.příjmeníToolStripMenuItem.Text = "Příjmení";
            this.příjmeníToolStripMenuItem.Click += new System.EventHandler(this.příjmeníToolStripMenuItem_Click);
            // 
            // jménoPříjmeníToolStripMenuItem
            // 
            this.jménoPříjmeníToolStripMenuItem.Name = "jménoPříjmeníToolStripMenuItem";
            this.jménoPříjmeníToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jménoPříjmeníToolStripMenuItem.Text = "Jméno + Příjmení";
            this.jménoPříjmeníToolStripMenuItem.Click += new System.EventHandler(this.jménoPříjmeníToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jménoPříjmeníToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // jménoPříjmeníToolStripMenuItem1
            // 
            this.jménoPříjmeníToolStripMenuItem1.Name = "jménoPříjmeníToolStripMenuItem1";
            this.jménoPříjmeníToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.jménoPříjmeníToolStripMenuItem1.Text = "Jméno + Příjmení";
            this.jménoPříjmeníToolStripMenuItem1.Click += new System.EventHandler(this.jménoPříjmeníToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(143, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Příjmení";
            // 
            // listBoxJmena
            // 
            this.listBoxJmena.FormattingEnabled = true;
            this.listBoxJmena.Location = new System.Drawing.Point(12, 56);
            this.listBoxJmena.Name = "listBoxJmena";
            this.listBoxJmena.Size = new System.Drawing.Size(129, 186);
            this.listBoxJmena.TabIndex = 3;
            // 
            // listBoxPrijmeni
            // 
            this.listBoxPrijmeni.FormattingEnabled = true;
            this.listBoxPrijmeni.Location = new System.Drawing.Point(147, 56);
            this.listBoxPrijmeni.Name = "listBoxPrijmeni";
            this.listBoxPrijmeni.Size = new System.Drawing.Size(130, 186);
            this.listBoxPrijmeni.TabIndex = 4;
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(12, 248);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(129, 20);
            this.txtJmeno.TabIndex = 5;
            // 
            // txtPrijmeni
            // 
            this.txtPrijmeni.Location = new System.Drawing.Point(146, 248);
            this.txtPrijmeni.Name = "txtPrijmeni";
            this.txtPrijmeni.Size = new System.Drawing.Size(130, 20);
            this.txtPrijmeni.TabIndex = 6;
            // 
            // btnVlozJmeno
            // 
            this.btnVlozJmeno.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVlozJmeno.Location = new System.Drawing.Point(12, 274);
            this.btnVlozJmeno.Name = "btnVlozJmeno";
            this.btnVlozJmeno.Size = new System.Drawing.Size(129, 33);
            this.btnVlozJmeno.TabIndex = 7;
            this.btnVlozJmeno.Text = "Vložit jméno";
            this.btnVlozJmeno.UseVisualStyleBackColor = true;
            this.btnVlozJmeno.Click += new System.EventHandler(this.btnVlozJmeno_Click);
            // 
            // btnVlozPrijmeni
            // 
            this.btnVlozPrijmeni.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVlozPrijmeni.Location = new System.Drawing.Point(148, 274);
            this.btnVlozPrijmeni.Name = "btnVlozPrijmeni";
            this.btnVlozPrijmeni.Size = new System.Drawing.Size(129, 33);
            this.btnVlozPrijmeni.TabIndex = 8;
            this.btnVlozPrijmeni.Text = "Vložit příjmení";
            this.btnVlozPrijmeni.UseVisualStyleBackColor = true;
            this.btnVlozPrijmeni.Click += new System.EventHandler(this.btnVlozPrijmeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.btnVlozPrijmeni);
            this.Controls.Add(this.btnVlozJmeno);
            this.Controls.Add(this.txtPrijmeni);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.listBoxPrijmeni);
            this.Controls.Add(this.listBoxJmena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Osoby";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem příjmeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoPříjmeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoPříjmeníToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxJmena;
        private System.Windows.Forms.ListBox listBoxPrijmeni;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.TextBox txtPrijmeni;
        private System.Windows.Forms.Button btnVlozJmeno;
        private System.Windows.Forms.Button btnVlozPrijmeni;
    }
}


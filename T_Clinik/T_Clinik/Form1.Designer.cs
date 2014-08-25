namespace T_Clinik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAdresa = new System.Windows.Forms.TextBox();
            this.dTpBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnZ = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijagnozeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poseteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime pacijenta";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(108, 24);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(189, 20);
            this.txbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prezime pacijenta";
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(108, 51);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(189, 20);
            this.txbSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum rodjenja";
            // 
            // txbAdresa
            // 
            this.txbAdresa.Location = new System.Drawing.Point(108, 182);
            this.txbAdresa.Name = "txbAdresa";
            this.txbAdresa.Size = new System.Drawing.Size(189, 20);
            this.txbAdresa.TabIndex = 5;
            // 
            // dTpBirth
            // 
            this.dTpBirth.Location = new System.Drawing.Point(108, 89);
            this.dTpBirth.Name = "dTpBirth";
            this.dTpBirth.Size = new System.Drawing.Size(200, 20);
            this.dTpBirth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pol";
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(6, 19);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(34, 17);
            this.rbtnM.TabIndex = 8;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnZ
            // 
            this.rbtnZ.AutoSize = true;
            this.rbtnZ.Checked = true;
            this.rbtnZ.Location = new System.Drawing.Point(68, 19);
            this.rbtnZ.Name = "rbtnZ";
            this.rbtnZ.Size = new System.Drawing.Size(32, 17);
            this.rbtnZ.TabIndex = 9;
            this.rbtnZ.TabStop = true;
            this.rbtnZ.Text = "Z";
            this.rbtnZ.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnM);
            this.groupBox1.Controls.Add(this.rbtnZ);
            this.groupBox1.Location = new System.Drawing.Point(108, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Broj telefona";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(108, 235);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(189, 20);
            this.telefon.TabIndex = 15;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(144, 304);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktoriToolStripMenuItem,
            this.dijagnozeToolStripMenuItem,
            this.poseteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // doktoriToolStripMenuItem
            // 
            this.doktoriToolStripMenuItem.Name = "doktoriToolStripMenuItem";
            this.doktoriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doktoriToolStripMenuItem.Text = "doktori";
            this.doktoriToolStripMenuItem.Click += new System.EventHandler(this.doktoriToolStripMenuItem_Click);
            // 
            // dijagnozeToolStripMenuItem
            // 
            this.dijagnozeToolStripMenuItem.Name = "dijagnozeToolStripMenuItem";
            this.dijagnozeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dijagnozeToolStripMenuItem.Text = "dijagnoze";
            // 
            // poseteToolStripMenuItem
            // 
            this.poseteToolStripMenuItem.Name = "poseteToolStripMenuItem";
            this.poseteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.poseteToolStripMenuItem.Text = "posete";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 534);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTpBirth);
            this.Controls.Add(this.txbAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAdresa;
        private System.Windows.Forms.DateTimePicker dTpBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijagnozeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poseteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


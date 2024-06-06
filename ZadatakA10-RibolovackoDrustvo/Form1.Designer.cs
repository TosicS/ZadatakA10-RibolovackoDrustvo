namespace ZadatakA10_RibolovackoDrustvo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIzmena = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnaliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOAplikaciji = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIzlaz = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGrad = new System.Windows.Forms.ComboBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelLB = new System.Windows.Forms.Label();
            this.labelPrikaziLV = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIzmena,
            this.toolStripButtonAnaliza,
            this.toolStripButtonOAplikaciji,
            this.toolStripButtonIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1010, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonIzmena
            // 
            this.toolStripButtonIzmena.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzmena.Image")));
            this.toolStripButtonIzmena.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzmena.Name = "toolStripButtonIzmena";
            this.toolStripButtonIzmena.Size = new System.Drawing.Size(49, 59);
            this.toolStripButtonIzmena.Text = "Izmena";
            this.toolStripButtonIzmena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzmena.Click += new System.EventHandler(this.toolStripButtonIzmena_Click);
            // 
            // toolStripButtonAnaliza
            // 
            this.toolStripButtonAnaliza.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnaliza.Image")));
            this.toolStripButtonAnaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnaliza.Name = "toolStripButtonAnaliza";
            this.toolStripButtonAnaliza.Size = new System.Drawing.Size(49, 59);
            this.toolStripButtonAnaliza.Text = "Analiza";
            this.toolStripButtonAnaliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAnaliza.Click += new System.EventHandler(this.toolStripButtonAnaliza_Click);
            // 
            // toolStripButtonOAplikaciji
            // 
            this.toolStripButtonOAplikaciji.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOAplikaciji.Image")));
            this.toolStripButtonOAplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOAplikaciji.Name = "toolStripButtonOAplikaciji";
            this.toolStripButtonOAplikaciji.Size = new System.Drawing.Size(69, 59);
            this.toolStripButtonOAplikaciji.Text = "O aplikaciji";
            this.toolStripButtonOAplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOAplikaciji.Click += new System.EventHandler(this.toolStripButtonOAplikaciji_Click);
            // 
            // toolStripButtonIzlaz
            // 
            this.toolStripButtonIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzlaz.Image")));
            this.toolStripButtonIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzlaz.Name = "toolStripButtonIzlaz";
            this.toolStripButtonIzlaz.Size = new System.Drawing.Size(44, 59);
            this.toolStripButtonIzlaz.Text = "Izlaz";
            this.toolStripButtonIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzlaz.Click += new System.EventHandler(this.toolStripButtonIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifra";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(114, 101);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.ReadOnly = true;
            this.textBoxSifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifra.TabIndex = 2;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(114, 144);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(138, 20);
            this.textBoxIme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(114, 189);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(138, 20);
            this.textBoxPrezime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime";
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(114, 229);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(157, 20);
            this.textBoxAdresa.TabIndex = 8;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(47, 232);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(40, 13);
            this.labelAdresa.TabIndex = 7;
            this.labelAdresa.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grad";
            // 
            // comboBoxGrad
            // 
            this.comboBoxGrad.FormattingEnabled = true;
            this.comboBoxGrad.Location = new System.Drawing.Point(114, 273);
            this.comboBoxGrad.Name = "comboBoxGrad";
            this.comboBoxGrad.Size = new System.Drawing.Size(138, 21);
            this.comboBoxGrad.TabIndex = 10;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(114, 319);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(117, 20);
            this.textBoxTelefon.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(299, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(684, 298);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelLB
            // 
            this.labelLB.AutoSize = true;
            this.labelLB.Location = new System.Drawing.Point(296, 75);
            this.labelLB.Name = "labelLB";
            this.labelLB.Size = new System.Drawing.Size(0, 13);
            this.labelLB.TabIndex = 14;
            // 
            // labelPrikaziLV
            // 
            this.labelPrikaziLV.AutoSize = true;
            this.labelPrikaziLV.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrikaziLV.Location = new System.Drawing.Point(296, 75);
            this.labelPrikaziLV.Name = "labelPrikaziLV";
            this.labelPrikaziLV.Size = new System.Drawing.Size(42, 14);
            this.labelPrikaziLV.TabIndex = 15;
            this.labelPrikaziLV.Text = "Sifra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.labelPrikaziLV);
            this.Controls.Add(this.labelLB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzmena;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnaliza;
        private System.Windows.Forms.ToolStripButton toolStripButtonOAplikaciji;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGrad;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelLB;
        private System.Windows.Forms.Label labelPrikaziLV;
    }
}


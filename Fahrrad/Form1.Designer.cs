namespace Fahrrad
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.RwCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BenoetigtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vhdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFahrradBestellen = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.libLager = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbLagerbestand = new System.Windows.Forms.TextBox();
            this.cbRwLager = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.RwNrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RwBezeichnungCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RwPreisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FwRwFwNrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FwRwBezeichnungCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FwRwMengeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gesamtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFwSpeichern = new System.Windows.Forms.Button();
            this.tbFwPreis = new System.Windows.Forms.TextBox();
            this.tbFwModell = new System.Windows.Forms.TextBox();
            this.tbFwNr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fwNrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModellCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fertigwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fertigwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cbFahrradBestellen);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1065, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bestellungen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RwCol,
            this.BenoetigtCol,
            this.vhdCol});
            this.dataGridView4.Location = new System.Drawing.Point(167, 211);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(725, 261);
            this.dataGridView4.TabIndex = 2;
            // 
            // RwCol
            // 
            this.RwCol.HeaderText = "Bestandteil";
            this.RwCol.Name = "RwCol";
            this.RwCol.ReadOnly = true;
            // 
            // BenoetigtCol
            // 
            this.BenoetigtCol.HeaderText = "Benötigt";
            this.BenoetigtCol.Name = "BenoetigtCol";
            this.BenoetigtCol.ReadOnly = true;
            // 
            // vhdCol
            // 
            this.vhdCol.HeaderText = "An Lager";
            this.vhdCol.Name = "vhdCol";
            this.vhdCol.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fahrrad:";
            // 
            // cbFahrradBestellen
            // 
            this.cbFahrradBestellen.FormattingEnabled = true;
            this.cbFahrradBestellen.Location = new System.Drawing.Point(164, 98);
            this.cbFahrradBestellen.Name = "cbFahrradBestellen";
            this.cbFahrradBestellen.Size = new System.Drawing.Size(126, 21);
            this.cbFahrradBestellen.TabIndex = 0;
            this.cbFahrradBestellen.SelectedIndexChanged += new System.EventHandler(this.cbFahrradBestellen_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.libLager);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.tbLagerbestand);
            this.tabPage2.Controls.Add(this.cbRwLager);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rohware";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 528);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rohware";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lagerbestand";
            // 
            // libLager
            // 
            this.libLager.FormattingEnabled = true;
            this.libLager.Location = new System.Drawing.Point(784, 291);
            this.libLager.Name = "libLager";
            this.libLager.Size = new System.Drawing.Size(228, 199);
            this.libLager.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(785, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Speichern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbLagerbestand
            // 
            this.tbLagerbestand.Location = new System.Drawing.Point(784, 162);
            this.tbLagerbestand.Name = "tbLagerbestand";
            this.tbLagerbestand.Size = new System.Drawing.Size(104, 20);
            this.tbLagerbestand.TabIndex = 3;
            // 
            // cbRwLager
            // 
            this.cbRwLager.FormattingEnabled = true;
            this.cbRwLager.Location = new System.Drawing.Point(785, 120);
            this.cbRwLager.Name = "cbRwLager";
            this.cbRwLager.Size = new System.Drawing.Size(227, 21);
            this.cbRwLager.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(407, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(42, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RwNrCol,
            this.RwBezeichnungCol,
            this.RwPreisCol});
            this.dataGridView3.Location = new System.Drawing.Point(86, 120);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(255, 370);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.DataGridView3_SelectionChanged);
            // 
            // RwNrCol
            // 
            this.RwNrCol.HeaderText = "RwNr";
            this.RwNrCol.Name = "RwNrCol";
            this.RwNrCol.ReadOnly = true;
            this.RwNrCol.Visible = false;
            // 
            // RwBezeichnungCol
            // 
            this.RwBezeichnungCol.HeaderText = "Bezeichnung";
            this.RwBezeichnungCol.Name = "RwBezeichnungCol";
            this.RwBezeichnungCol.ReadOnly = true;
            // 
            // RwPreisCol
            // 
            this.RwPreisCol.HeaderText = "Preis";
            this.RwPreisCol.Name = "RwPreisCol";
            this.RwPreisCol.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnFwSpeichern);
            this.tabPage1.Controls.Add(this.tbFwPreis);
            this.tabPage1.Controls.Add(this.tbFwModell);
            this.tabPage1.Controls.Add(this.tbFwNr);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fertigware";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(420, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FwRwFwNrCol,
            this.FwRwBezeichnungCol,
            this.FwRwMengeCol,
            this.gesamtCol});
            this.dataGridView2.Location = new System.Drawing.Point(649, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(381, 255);
            this.dataGridView2.TabIndex = 9;
            // 
            // FwRwFwNrCol
            // 
            this.FwRwFwNrCol.HeaderText = "FWNr";
            this.FwRwFwNrCol.Name = "FwRwFwNrCol";
            this.FwRwFwNrCol.ReadOnly = true;
            this.FwRwFwNrCol.Visible = false;
            // 
            // FwRwBezeichnungCol
            // 
            this.FwRwBezeichnungCol.HeaderText = "Bezeichnung";
            this.FwRwBezeichnungCol.Name = "FwRwBezeichnungCol";
            this.FwRwBezeichnungCol.ReadOnly = true;
            // 
            // FwRwMengeCol
            // 
            this.FwRwMengeCol.HeaderText = "Menge";
            this.FwRwMengeCol.Name = "FwRwMengeCol";
            this.FwRwMengeCol.ReadOnly = true;
            // 
            // gesamtCol
            // 
            this.gesamtCol.HeaderText = "GesamtKosten";
            this.gesamtCol.Name = "gesamtCol";
            this.gesamtCol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(677, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zuordnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnFwSpeichern
            // 
            this.btnFwSpeichern.Location = new System.Drawing.Point(432, 391);
            this.btnFwSpeichern.Name = "btnFwSpeichern";
            this.btnFwSpeichern.Size = new System.Drawing.Size(142, 26);
            this.btnFwSpeichern.TabIndex = 4;
            this.btnFwSpeichern.Text = "Speichern";
            this.btnFwSpeichern.UseVisualStyleBackColor = true;
            this.btnFwSpeichern.Click += new System.EventHandler(this.BtnFwSpeichern_Click);
            // 
            // tbFwPreis
            // 
            this.tbFwPreis.Location = new System.Drawing.Point(428, 301);
            this.tbFwPreis.Name = "tbFwPreis";
            this.tbFwPreis.Size = new System.Drawing.Size(147, 20);
            this.tbFwPreis.TabIndex = 3;
            // 
            // tbFwModell
            // 
            this.tbFwModell.Location = new System.Drawing.Point(428, 261);
            this.tbFwModell.Name = "tbFwModell";
            this.tbFwModell.Size = new System.Drawing.Size(147, 20);
            this.tbFwModell.TabIndex = 2;
            // 
            // tbFwNr
            // 
            this.tbFwNr.Location = new System.Drawing.Point(427, 222);
            this.tbFwNr.Name = "tbFwNr";
            this.tbFwNr.ReadOnly = true;
            this.tbFwNr.Size = new System.Drawing.Size(147, 20);
            this.tbFwNr.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fwNrCol,
            this.ModellCol,
            this.PreisCol});
            this.dataGridView1.Location = new System.Drawing.Point(36, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(369, 479);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // fwNrCol
            // 
            this.fwNrCol.HeaderText = "fwNr";
            this.fwNrCol.Name = "fwNrCol";
            this.fwNrCol.ReadOnly = true;
            this.fwNrCol.Visible = false;
            // 
            // ModellCol
            // 
            this.ModellCol.HeaderText = "Modell";
            this.ModellCol.Name = "ModellCol";
            this.ModellCol.ReadOnly = true;
            // 
            // PreisCol
            // 
            this.PreisCol.HeaderText = "Preis";
            this.PreisCol.Name = "PreisCol";
            this.PreisCol.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(45, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // fertigwareBindingSource
            // 
            this.fertigwareBindingSource.DataSource = typeof(Fahrrad.Fertigware);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 713);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fertigwareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fertigwareBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RwCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BenoetigtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vhdCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFahrradBestellen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox libLager;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbLagerbestand;
        private System.Windows.Forms.ComboBox cbRwLager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RwNrCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RwBezeichnungCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RwPreisCol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FwRwFwNrCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FwRwBezeichnungCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FwRwMengeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesamtCol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFwSpeichern;
        private System.Windows.Forms.TextBox tbFwPreis;
        private System.Windows.Forms.TextBox tbFwModell;
        private System.Windows.Forms.TextBox tbFwNr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fwNrCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModellCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreisCol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button4;
    }
}


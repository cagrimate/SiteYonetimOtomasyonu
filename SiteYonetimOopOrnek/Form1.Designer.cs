
namespace SiteYonetimOopOrnek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBloklar = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbDaire = new System.Windows.Forms.RadioButton();
            this.rdbDukkan = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMulkSahibi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmdMetreKareBilgisi = new System.Windows.Forms.NumericUpDown();
            this.chkKiraci = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdMetreKareBilgisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blok Seçimi :";
            // 
            // cmbBloklar
            // 
            this.cmbBloklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBloklar.FormattingEnabled = true;
            this.cmbBloklar.Location = new System.Drawing.Point(217, 44);
            this.cmbBloklar.Name = "cmbBloklar";
            this.cmbBloklar.Size = new System.Drawing.Size(121, 24);
            this.cmbBloklar.TabIndex = 1;
            this.cmbBloklar.SelectedIndexChanged += new System.EventHandler(this.nmdMetreKareBilgisi_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 74);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rdbDaire
            // 
            this.rdbDaire.AutoSize = true;
            this.rdbDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDaire.Location = new System.Drawing.Point(50, 241);
            this.rdbDaire.Name = "rdbDaire";
            this.rdbDaire.Size = new System.Drawing.Size(65, 21);
            this.rdbDaire.TabIndex = 3;
            this.rdbDaire.TabStop = true;
            this.rdbDaire.Text = "Daire";
            this.rdbDaire.UseVisualStyleBackColor = true;
            // 
            // rdbDukkan
            // 
            this.rdbDukkan.AutoSize = true;
            this.rdbDukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDukkan.Location = new System.Drawing.Point(227, 241);
            this.rdbDukkan.Name = "rdbDukkan";
            this.rdbDukkan.Size = new System.Drawing.Size(80, 21);
            this.rdbDukkan.TabIndex = 3;
            this.rdbDukkan.TabStop = true;
            this.rdbDukkan.Text = "Dükkan";
            this.rdbDukkan.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(227, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 65);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mülk Sahibi :";
            // 
            // txtMulkSahibi
            // 
            this.txtMulkSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMulkSahibi.Location = new System.Drawing.Point(158, 96);
            this.txtMulkSahibi.Name = "txtMulkSahibi";
            this.txtMulkSahibi.Size = new System.Drawing.Size(217, 23);
            this.txtMulkSahibi.TabIndex = 4;
            this.txtMulkSahibi.TextChanged += new System.EventHandler(this.nmdMetreKareBilgisi_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Metre Kare :";
            // 
            // nmdMetreKareBilgisi
            // 
            this.nmdMetreKareBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmdMetreKareBilgisi.Location = new System.Drawing.Point(158, 132);
            this.nmdMetreKareBilgisi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmdMetreKareBilgisi.Name = "nmdMetreKareBilgisi";
            this.nmdMetreKareBilgisi.Size = new System.Drawing.Size(98, 23);
            this.nmdMetreKareBilgisi.TabIndex = 5;
            this.nmdMetreKareBilgisi.ValueChanged += new System.EventHandler(this.nmdMetreKareBilgisi_ValueChanged);
            // 
            // chkKiraci
            // 
            this.chkKiraci.AutoSize = true;
            this.chkKiraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkKiraci.Location = new System.Drawing.Point(277, 134);
            this.chkKiraci.Name = "chkKiraci";
            this.chkKiraci.Size = new System.Drawing.Size(105, 24);
            this.chkKiraci.TabIndex = 6;
            this.chkKiraci.Text = "Kiracı Var";
            this.chkKiraci.UseVisualStyleBackColor = true;
            this.chkKiraci.CheckedChanged += new System.EventHandler(this.nmdMetreKareBilgisi_ValueChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Location = new System.Drawing.Point(146, 286);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(64, 68);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYIT";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 291);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1238, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkKiraci);
            this.Controls.Add(this.nmdMetreKareBilgisi);
            this.Controls.Add(this.txtMulkSahibi);
            this.Controls.Add(this.rdbDukkan);
            this.Controls.Add(this.rdbDaire);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbBloklar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdMetreKareBilgisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBloklar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbDaire;
        private System.Windows.Forms.RadioButton rdbDukkan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMulkSahibi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmdMetreKareBilgisi;
        private System.Windows.Forms.CheckBox chkKiraci;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


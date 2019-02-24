namespace PoliklinikBilgiSistemi.Forms
{
    partial class frmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor));
            this.dgRapor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAraAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAraSoy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nmAraTc = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAraTc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRapor
            // 
            this.dgRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRapor.Location = new System.Drawing.Point(18, 164);
            this.dgRapor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgRapor.Name = "dgRapor";
            this.dgRapor.Size = new System.Drawing.Size(1300, 428);
            this.dgRapor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Adı";
            // 
            // txtAraAd
            // 
            this.txtAraAd.Location = new System.Drawing.Point(115, 47);
            this.txtAraAd.Name = "txtAraAd";
            this.txtAraAd.Size = new System.Drawing.Size(143, 32);
            this.txtAraAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Soyadı";
            // 
            // txtAraSoy
            // 
            this.txtAraSoy.Location = new System.Drawing.Point(407, 47);
            this.txtAraSoy.Name = "txtAraSoy";
            this.txtAraSoy.Size = new System.Drawing.Size(143, 32);
            this.txtAraSoy.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasta T.C. Numarası";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(1152, 108);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(127, 47);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTemizle.Location = new System.Drawing.Point(995, 108);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(127, 47);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1079, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(956, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Muayene Tarihi";
            // 
            // nmAraTc
            // 
            this.nmAraTc.Location = new System.Drawing.Point(748, 47);
            this.nmAraTc.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmAraTc.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmAraTc.Name = "nmAraTc";
            this.nmAraTc.Size = new System.Drawing.Size(155, 32);
            this.nmAraTc.TabIndex = 3;
            this.nmAraTc.Value = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1225, 601);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 33);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmRapor
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTemizle;
            this.ClientSize = new System.Drawing.Size(1334, 681);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nmAraTc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAraSoy);
            this.Controls.Add(this.txtAraAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRapor);
            this.Font = new System.Drawing.Font("Andalus", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasta Arama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAraTc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAraAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAraSoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmAraTc;
        private System.Windows.Forms.Button btnKaydet;
    }
}
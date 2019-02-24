namespace PoliklinikBilgiSistemi.Forms
{
    partial class Dogrulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dogrulama));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnDogrulama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen T.C. Numaranızı giriniz!";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(120, 101);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(236, 32);
            this.txtTc.TabIndex = 1;
            // 
            // btnDogrulama
            // 
            this.btnDogrulama.Location = new System.Drawing.Point(191, 161);
            this.btnDogrulama.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDogrulama.Name = "btnDogrulama";
            this.btnDogrulama.Size = new System.Drawing.Size(98, 38);
            this.btnDogrulama.TabIndex = 2;
            this.btnDogrulama.Text = "Giriş";
            this.btnDogrulama.UseVisualStyleBackColor = true;
            this.btnDogrulama.Click += new System.EventHandler(this.btnDogrulama_Click);
            // 
            // Dogrulama
            // 
            this.AcceptButton = this.btnDogrulama;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 266);
            this.Controls.Add(this.btnDogrulama);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Dogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogrulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnDogrulama;
    }
}
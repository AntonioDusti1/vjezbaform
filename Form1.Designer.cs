namespace ProsjekOcjena
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
            this.txtUnosOcjene = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtProsjek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojOcjene = new System.Windows.Forms.TextBox();
            this.txtZbroj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUnosOcjene
            // 
            this.txtUnosOcjene.Location = new System.Drawing.Point(112, 45);
            this.txtUnosOcjene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnosOcjene.Name = "txtUnosOcjene";
            this.txtUnosOcjene.Size = new System.Drawing.Size(76, 20);
            this.txtUnosOcjene.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unos ocjene:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(29, 78);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(158, 43);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "&Unesi ocjenu";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // txtProsjek
            // 
            this.txtProsjek.Location = new System.Drawing.Point(112, 141);
            this.txtProsjek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProsjek.Name = "txtProsjek";
            this.txtProsjek.Size = new System.Drawing.Size(76, 20);
            this.txtProsjek.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prosjek ocjena:";
            // 
            // txtBrojOcjene
            // 
            this.txtBrojOcjene.Location = new System.Drawing.Point(280, 58);
            this.txtBrojOcjene.Name = "txtBrojOcjene";
            this.txtBrojOcjene.Size = new System.Drawing.Size(100, 20);
            this.txtBrojOcjene.TabIndex = 5;
            // 
            // txtZbroj
            // 
            this.txtZbroj.Location = new System.Drawing.Point(280, 140);
            this.txtZbroj.Name = "txtZbroj";
            this.txtZbroj.Size = new System.Drawing.Size(100, 20);
            this.txtZbroj.TabIndex = 6;
            this.txtZbroj.TextChanged += new System.EventHandler(this.txtZbroj_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 331);
            this.Controls.Add(this.txtZbroj);
            this.Controls.Add(this.txtBrojOcjene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProsjek);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnosOcjene);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Prosjek ocjena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosOcjene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtProsjek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojOcjene;
        private System.Windows.Forms.TextBox txtZbroj;
    }
}


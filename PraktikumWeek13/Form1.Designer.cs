namespace PraktikumWeek13
{
    partial class FormPengaturanNama
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
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(24, 46);
            this.labelData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(82, 17);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Input Data :";
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Location = new System.Drawing.Point(25, 67);
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.Size = new System.Drawing.Size(217, 26);
            this.textBoxPesan.TabIndex = 1;
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(25, 118);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(88, 26);
            this.buttonProses.TabIndex = 2;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // labelEmpty
            // 
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpty.Location = new System.Drawing.Point(19, 179);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(111, 33);
            this.labelEmpty.TabIndex = 3;
            this.labelEmpty.Text = "[EMPTY]";
            // 
            // FormPengaturanNama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 562);
            this.Controls.Add(this.labelEmpty);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.textBoxPesan);
            this.Controls.Add(this.labelData);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPengaturanNama";
            this.Text = "Form Pengaturan Nama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxPesan;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label labelEmpty;
    }
}


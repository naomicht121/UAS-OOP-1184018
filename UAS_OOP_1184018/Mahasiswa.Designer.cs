namespace UAS_OOP_1184018
{
    partial class Mahasiswa
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txtNamaProdi = new System.Windows.Forms.TextBox();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.Singkatan = new System.Windows.Forms.Label();
            this.NamaProdi = new System.Windows.Forms.Label();
            this.KodeProdi = new System.Windows.Forms.Label();
            this.JudulForm = new System.Windows.Forms.Label();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(412, 335);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(108, 33);
            this.btn_Clear.TabIndex = 24;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(211, 335);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 33);
            this.btn_Submit.TabIndex = 23;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.Location = new System.Drawing.Point(301, 211);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.Size = new System.Drawing.Size(311, 22);
            this.txtNamaProdi.TabIndex = 20;
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(301, 171);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(311, 22);
            this.txtKodeProdi.TabIndex = 19;
            // 
            // Singkatan
            // 
            this.Singkatan.AutoSize = true;
            this.Singkatan.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singkatan.Location = new System.Drawing.Point(141, 249);
            this.Singkatan.Name = "Singkatan";
            this.Singkatan.Size = new System.Drawing.Size(127, 23);
            this.Singkatan.TabIndex = 17;
            this.Singkatan.Text = "Program Studi :";
            // 
            // NamaProdi
            // 
            this.NamaProdi.AutoSize = true;
            this.NamaProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaProdi.Location = new System.Drawing.Point(141, 210);
            this.NamaProdi.Name = "NamaProdi";
            this.NamaProdi.Size = new System.Drawing.Size(64, 23);
            this.NamaProdi.TabIndex = 16;
            this.NamaProdi.Text = "Nama :";
            // 
            // KodeProdi
            // 
            this.KodeProdi.AutoSize = true;
            this.KodeProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeProdi.Location = new System.Drawing.Point(141, 171);
            this.KodeProdi.Name = "KodeProdi";
            this.KodeProdi.Size = new System.Drawing.Size(48, 23);
            this.KodeProdi.TabIndex = 15;
            this.KodeProdi.Text = "NPM:";
            // 
            // JudulForm
            // 
            this.JudulForm.AutoSize = true;
            this.JudulForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulForm.Location = new System.Drawing.Point(247, 74);
            this.JudulForm.Name = "JudulForm";
            this.JudulForm.Size = new System.Drawing.Size(323, 29);
            this.JudulForm.TabIndex = 14;
            this.JudulForm.Text = "INPUT DATA MAHASISWA";
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Location = new System.Drawing.Point(301, 250);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(311, 24);
            this.cbProdi.TabIndex = 25;
            // 
            // Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 420);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtNamaProdi);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.Singkatan);
            this.Controls.Add(this.NamaProdi);
            this.Controls.Add(this.KodeProdi);
            this.Controls.Add(this.JudulForm);
            this.Name = "Mahasiswa";
            this.Text = "Mahasiswa";
            this.Load += new System.EventHandler(this.Mahasiswa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txtNamaProdi;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.Label Singkatan;
        private System.Windows.Forms.Label NamaProdi;
        private System.Windows.Forms.Label KodeProdi;
        private System.Windows.Forms.Label JudulForm;
        private System.Windows.Forms.ComboBox cbProdi;

        public Home MdiHome { get; internal set; }
    }
}
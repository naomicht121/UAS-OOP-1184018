namespace UAS_OOP_1184018
{
    partial class Mahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Home MdiHome { get; internal set; }

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
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.Singkatan = new System.Windows.Forms.Label();
            this.NamaProdi = new System.Windows.Forms.Label();
            this.KodeProdi = new System.Windows.Forms.Label();
            this.JudulForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Location = new System.Drawing.Point(379, 303);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(311, 24);
            this.cbProdi.TabIndex = 34;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(490, 388);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(108, 33);
            this.btn_Clear.TabIndex = 33;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(289, 388);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 33);
            this.btn_Submit.TabIndex = 32;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(379, 264);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(311, 22);
            this.txtNama.TabIndex = 31;
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(379, 224);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(311, 22);
            this.txtNPM.TabIndex = 30;
            // 
            // Singkatan
            // 
            this.Singkatan.AutoSize = true;
            this.Singkatan.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singkatan.Location = new System.Drawing.Point(219, 302);
            this.Singkatan.Name = "Singkatan";
            this.Singkatan.Size = new System.Drawing.Size(127, 23);
            this.Singkatan.TabIndex = 29;
            this.Singkatan.Text = "Program Studi :";
            // 
            // NamaProdi
            // 
            this.NamaProdi.AutoSize = true;
            this.NamaProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaProdi.Location = new System.Drawing.Point(219, 263);
            this.NamaProdi.Name = "NamaProdi";
            this.NamaProdi.Size = new System.Drawing.Size(64, 23);
            this.NamaProdi.TabIndex = 28;
            this.NamaProdi.Text = "Nama :";
            // 
            // KodeProdi
            // 
            this.KodeProdi.AutoSize = true;
            this.KodeProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeProdi.Location = new System.Drawing.Point(219, 224);
            this.KodeProdi.Name = "KodeProdi";
            this.KodeProdi.Size = new System.Drawing.Size(48, 23);
            this.KodeProdi.TabIndex = 27;
            this.KodeProdi.Text = "NPM:";
            // 
            // JudulForm
            // 
            this.JudulForm.AutoSize = true;
            this.JudulForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulForm.Location = new System.Drawing.Point(299, 127);
            this.JudulForm.Name = "JudulForm";
            this.JudulForm.Size = new System.Drawing.Size(323, 29);
            this.JudulForm.TabIndex = 26;
            this.JudulForm.Text = "INPUT DATA MAHASISWA";
            // 
            // Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 534);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNPM);
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

        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.Label Singkatan;
        private System.Windows.Forms.Label NamaProdi;
        private System.Windows.Forms.Label KodeProdi;
        private System.Windows.Forms.Label JudulForm;
    }
}
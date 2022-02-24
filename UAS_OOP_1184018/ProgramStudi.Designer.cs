namespace UAS_OOP_1184018
{
    partial class Program_Studi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program_Studi));
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.JudulForm = new System.Windows.Forms.Label();
            this.KodeProdi = new System.Windows.Forms.Label();
            this.NamaProdi = new System.Windows.Forms.Label();
            this.Singkatan = new System.Windows.Forms.Label();
            this.BiayaKuliah = new System.Windows.Forms.Label();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.txtNamaProdi = new System.Windows.Forms.TextBox();
            this.txtSingkatan = new System.Windows.Forms.TextBox();
            this.txtBiayaKuliah = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // JudulForm
            // 
            this.JudulForm.AutoSize = true;
            this.JudulForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulForm.Location = new System.Drawing.Point(196, 61);
            this.JudulForm.Name = "JudulForm";
            this.JudulForm.Size = new System.Drawing.Size(311, 29);
            this.JudulForm.TabIndex = 1;
            this.JudulForm.Text = "INPUT PROGRAM STUDI";
            // 
            // KodeProdi
            // 
            this.KodeProdi.AutoSize = true;
            this.KodeProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeProdi.Location = new System.Drawing.Point(90, 158);
            this.KodeProdi.Name = "KodeProdi";
            this.KodeProdi.Size = new System.Drawing.Size(100, 23);
            this.KodeProdi.TabIndex = 4;
            this.KodeProdi.Text = "Kode Prodi :";
            // 
            // NamaProdi
            // 
            this.NamaProdi.AutoSize = true;
            this.NamaProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaProdi.Location = new System.Drawing.Point(90, 197);
            this.NamaProdi.Name = "NamaProdi";
            this.NamaProdi.Size = new System.Drawing.Size(107, 23);
            this.NamaProdi.TabIndex = 5;
            this.NamaProdi.Text = "Nama Prodi :";
            // 
            // Singkatan
            // 
            this.Singkatan.AutoSize = true;
            this.Singkatan.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singkatan.Location = new System.Drawing.Point(90, 236);
            this.Singkatan.Name = "Singkatan";
            this.Singkatan.Size = new System.Drawing.Size(95, 23);
            this.Singkatan.TabIndex = 6;
            this.Singkatan.Text = "Singkatan :";
            // 
            // BiayaKuliah
            // 
            this.BiayaKuliah.AutoSize = true;
            this.BiayaKuliah.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiayaKuliah.Location = new System.Drawing.Point(90, 273);
            this.BiayaKuliah.Name = "BiayaKuliah";
            this.BiayaKuliah.Size = new System.Drawing.Size(113, 23);
            this.BiayaKuliah.TabIndex = 7;
            this.BiayaKuliah.Text = "Biaya Kuliah :";
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(250, 158);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(311, 22);
            this.txtKodeProdi.TabIndex = 8;
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.Location = new System.Drawing.Point(250, 198);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.Size = new System.Drawing.Size(311, 22);
            this.txtNamaProdi.TabIndex = 9;
            this.txtNamaProdi.Leave += new System.EventHandler(this.txtNamaProdi_Leave);
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.Location = new System.Drawing.Point(250, 237);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.Size = new System.Drawing.Size(311, 22);
            this.txtSingkatan.TabIndex = 10;
            // 
            // txtBiayaKuliah
            // 
            this.txtBiayaKuliah.Location = new System.Drawing.Point(250, 274);
            this.txtBiayaKuliah.Name = "txtBiayaKuliah";
            this.txtBiayaKuliah.Size = new System.Drawing.Size(311, 22);
            this.txtBiayaKuliah.TabIndex = 11;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(181, 388);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 33);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(384, 388);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(108, 33);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Program_Studi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 548);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtBiayaKuliah);
            this.Controls.Add(this.txtSingkatan);
            this.Controls.Add(this.txtNamaProdi);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.BiayaKuliah);
            this.Controls.Add(this.Singkatan);
            this.Controls.Add(this.NamaProdi);
            this.Controls.Add(this.KodeProdi);
            this.Controls.Add(this.JudulForm);
            this.Name = "Program_Studi";
            this.Text = "Program_Studi";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txtBiayaKuliah;
        private System.Windows.Forms.TextBox txtSingkatan;
        private System.Windows.Forms.TextBox txtNamaProdi;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.Label BiayaKuliah;
        private System.Windows.Forms.Label Singkatan;
        private System.Windows.Forms.Label NamaProdi;
        private System.Windows.Forms.Label KodeProdi;
        private System.Windows.Forms.Label JudulForm;
    }
}
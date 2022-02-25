namespace UAS_OOP_1184018
{
    partial class ProgramStudi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramStudi));
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txtBiayaKuliah = new System.Windows.Forms.TextBox();
            this.txtSingkatan = new System.Windows.Forms.TextBox();
            this.txtNamaProdi = new System.Windows.Forms.TextBox();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.BiayaKuliah = new System.Windows.Forms.Label();
            this.Singkatan = new System.Windows.Forms.Label();
            this.NamaProdi = new System.Windows.Forms.Label();
            this.KodeProdi = new System.Windows.Forms.Label();
            this.JudulForm = new System.Windows.Forms.Label();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(503, 419);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(108, 33);
            this.btn_Clear.TabIndex = 24;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(300, 419);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 33);
            this.btn_Submit.TabIndex = 23;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txtBiayaKuliah
            // 
            this.txtBiayaKuliah.Location = new System.Drawing.Point(369, 305);
            this.txtBiayaKuliah.Name = "txtBiayaKuliah";
            this.txtBiayaKuliah.Size = new System.Drawing.Size(311, 22);
            this.txtBiayaKuliah.TabIndex = 22;
            this.txtBiayaKuliah.Leave += new System.EventHandler(this.txtBiayaKuliah_Leave);
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.Location = new System.Drawing.Point(369, 268);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.Size = new System.Drawing.Size(311, 22);
            this.txtSingkatan.TabIndex = 21;
            this.txtSingkatan.Leave += new System.EventHandler(this.txtSingkatan_Leave);
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.Location = new System.Drawing.Point(369, 229);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.Size = new System.Drawing.Size(311, 22);
            this.txtNamaProdi.TabIndex = 20;
            this.txtNamaProdi.Leave += new System.EventHandler(this.txtNamaProdi_Leave);
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(369, 189);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(311, 22);
            this.txtKodeProdi.TabIndex = 19;
            this.txtKodeProdi.Leave += new System.EventHandler(this.txtKodeProdi_Leave);
            // 
            // BiayaKuliah
            // 
            this.BiayaKuliah.AutoSize = true;
            this.BiayaKuliah.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiayaKuliah.Location = new System.Drawing.Point(209, 304);
            this.BiayaKuliah.Name = "BiayaKuliah";
            this.BiayaKuliah.Size = new System.Drawing.Size(113, 23);
            this.BiayaKuliah.TabIndex = 18;
            this.BiayaKuliah.Text = "Biaya Kuliah :";
            // 
            // Singkatan
            // 
            this.Singkatan.AutoSize = true;
            this.Singkatan.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singkatan.Location = new System.Drawing.Point(209, 267);
            this.Singkatan.Name = "Singkatan";
            this.Singkatan.Size = new System.Drawing.Size(95, 23);
            this.Singkatan.TabIndex = 17;
            this.Singkatan.Text = "Singkatan :";
            // 
            // NamaProdi
            // 
            this.NamaProdi.AutoSize = true;
            this.NamaProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaProdi.Location = new System.Drawing.Point(209, 228);
            this.NamaProdi.Name = "NamaProdi";
            this.NamaProdi.Size = new System.Drawing.Size(107, 23);
            this.NamaProdi.TabIndex = 16;
            this.NamaProdi.Text = "Nama Prodi :";
            // 
            // KodeProdi
            // 
            this.KodeProdi.AutoSize = true;
            this.KodeProdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeProdi.Location = new System.Drawing.Point(209, 189);
            this.KodeProdi.Name = "KodeProdi";
            this.KodeProdi.Size = new System.Drawing.Size(100, 23);
            this.KodeProdi.TabIndex = 15;
            this.KodeProdi.Text = "Kode Prodi :";
            // 
            // JudulForm
            // 
            this.JudulForm.AutoSize = true;
            this.JudulForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulForm.Location = new System.Drawing.Point(315, 92);
            this.JudulForm.Name = "JudulForm";
            this.JudulForm.Size = new System.Drawing.Size(311, 29);
            this.JudulForm.TabIndex = 14;
            this.JudulForm.Text = "INPUT PROGRAM STUDI";
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
            // ProgramStudi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 511);
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
            this.Name = "ProgramStudi";
            this.Text = "ProgramStudi";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
    }
}
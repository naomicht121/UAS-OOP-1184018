namespace UAS_OOP_1184018
{
    partial class ViewMahasiswa
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgMahasiswa = new System.Windows.Forms.DataGridView();
            this.JudulForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(413, 478);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgMahasiswa
            // 
            this.dgMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMahasiswa.Location = new System.Drawing.Point(60, 94);
            this.dgMahasiswa.Margin = new System.Windows.Forms.Padding(4);
            this.dgMahasiswa.Name = "dgMahasiswa";
            this.dgMahasiswa.Size = new System.Drawing.Size(864, 355);
            this.dgMahasiswa.TabIndex = 31;
            // 
            // JudulForm
            // 
            this.JudulForm.AutoSize = true;
            this.JudulForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulForm.Location = new System.Drawing.Point(348, 36);
            this.JudulForm.Name = "JudulForm";
            this.JudulForm.Size = new System.Drawing.Size(238, 29);
            this.JudulForm.TabIndex = 30;
            this.JudulForm.Text = "DATA MAHASISWA";
            // 
            // ViewMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 542);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgMahasiswa);
            this.Controls.Add(this.JudulForm);
            this.Name = "ViewMahasiswa";
            this.Text = "ViewMahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dgMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgMahasiswa;
        private System.Windows.Forms.Label JudulForm;
    }
}
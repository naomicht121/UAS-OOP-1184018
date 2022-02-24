namespace UAS_OOP_1184018
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInput = new System.Windows.Forms.ToolStripDropDownButton();
            this.InputMhsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputProdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView = new System.Windows.Forms.ToolStripDropDownButton();
            this.ViewMhsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewProdiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTransaksi = new System.Windows.Forms.ToolStripLabel();
            this.tsUpdate = new System.Windows.Forms.ToolStripDropDownButton();
            this.mahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInput,
            this.tsView,
            this.tsUpdate,
            this.tsTransaksi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(713, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsInput
            // 
            this.tsInput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputMhsMenuItem,
            this.InputProdiToolStripMenuItem});
            this.tsInput.Name = "tsInput";
            this.tsInput.Size = new System.Drawing.Size(57, 24);
            this.tsInput.Text = "I&nput";
            // 
            // InputMhsMenuItem
            // 
            this.InputMhsMenuItem.Name = "InputMhsMenuItem";
            this.InputMhsMenuItem.Size = new System.Drawing.Size(181, 26);
            this.InputMhsMenuItem.Text = "Mahasiswa";
            this.InputMhsMenuItem.Click += new System.EventHandler(this.InputMhsMenuItem_Click);
            // 
            // InputProdiToolStripMenuItem
            // 
            this.InputProdiToolStripMenuItem.Name = "InputProdiToolStripMenuItem";
            this.InputProdiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.InputProdiToolStripMenuItem.Text = "Prodi";
            this.InputProdiToolStripMenuItem.Click += new System.EventHandler(this.InputProdiToolStripMenuItem_Click);
            // 
            // tsView
            // 
            this.tsView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMhsToolStripMenuItem,
            this.ViewProdiToolStripMenuItem1});
            this.tsView.Image = ((System.Drawing.Image)(resources.GetObject("tsView.Image")));
            this.tsView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(55, 24);
            this.tsView.Text = "&View";
            this.tsView.Click += new System.EventHandler(this.tsView_Click);
            // 
            // ViewMhsToolStripMenuItem
            // 
            this.ViewMhsToolStripMenuItem.Name = "ViewMhsToolStripMenuItem";
            this.ViewMhsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ViewMhsToolStripMenuItem.Text = "Mahasiswa";
            this.ViewMhsToolStripMenuItem.Click += new System.EventHandler(this.ViewMhsToolStripMenuItem_Click);
            // 
            // ViewProdiToolStripMenuItem1
            // 
            this.ViewProdiToolStripMenuItem1.Name = "ViewProdiToolStripMenuItem1";
            this.ViewProdiToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.ViewProdiToolStripMenuItem1.Text = "Prodi";
            this.ViewProdiToolStripMenuItem1.Click += new System.EventHandler(this.ViewProdiToolStripMenuItem1_Click);
            // 
            // tsTransaksi
            // 
            this.tsTransaksi.Name = "tsTransaksi";
            this.tsTransaksi.Size = new System.Drawing.Size(68, 24);
            this.tsTransaksi.Text = "&Transaksi";
            // 
            // tsUpdate
            // 
            this.tsUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mahasiswaToolStripMenuItem,
            this.prodiToolStripMenuItem});
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(72, 24);
            this.tsUpdate.Text = "&Update";
            // 
            // mahasiswaToolStripMenuItem
            // 
            this.mahasiswaToolStripMenuItem.Name = "mahasiswaToolStripMenuItem";
            this.mahasiswaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.mahasiswaToolStripMenuItem.Text = "Mahasiswa";
            // 
            // prodiToolStripMenuItem
            // 
            this.prodiToolStripMenuItem.Name = "prodiToolStripMenuItem";
            this.prodiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.prodiToolStripMenuItem.Text = "Prodi";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 468);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsInput;
        private System.Windows.Forms.ToolStripMenuItem InputMhsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InputProdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tsTransaksi;
        private System.Windows.Forms.ToolStripDropDownButton tsView;
        private System.Windows.Forms.ToolStripMenuItem ViewMhsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewProdiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton tsUpdate;
        private System.Windows.Forms.ToolStripMenuItem mahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodiToolStripMenuItem;
    }
}
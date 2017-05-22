namespace QLTV
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_sach = new System.Windows.Forms.ToolStripMenuItem();
            this.item_docgia = new System.Windows.Forms.ToolStripMenuItem();
            this.item_muontra = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thôngTinMượnTrảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.AutoSize = false;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(150, 31);
            this.quảnLýToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // thôngTinMượnTrảToolStripMenuItem
            // 
            this.thôngTinMượnTrảToolStripMenuItem.AutoSize = false;
            this.thôngTinMượnTrảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_sach,
            this.item_docgia,
            this.item_muontra});
            this.thôngTinMượnTrảToolStripMenuItem.Name = "thôngTinMượnTrảToolStripMenuItem";
            this.thôngTinMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(110, 31);
            this.thôngTinMượnTrảToolStripMenuItem.Text = "Quản lý";
            // 
            // item_sach
            // 
            this.item_sach.Name = "item_sach";
            this.item_sach.Size = new System.Drawing.Size(186, 22);
            this.item_sach.Text = "Sách";
            this.item_sach.Click += new System.EventHandler(this.item_sach_Click);
            // 
            // item_docgia
            // 
            this.item_docgia.Name = "item_docgia";
            this.item_docgia.Size = new System.Drawing.Size(186, 22);
            this.item_docgia.Text = "Độc giả";
            this.item_docgia.Click += new System.EventHandler(this.item_docgia_Click);
            // 
            // item_muontra
            // 
            this.item_muontra.Name = "item_muontra";
            this.item_muontra.Size = new System.Drawing.Size(186, 22);
            this.item_muontra.Text = "Thông tin mượn - trả";
            this.item_muontra.Click += new System.EventHandler(this.item_muontra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::QLTV.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(350, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 107);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Thư Viện";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTV.Properties.Resources.background_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 541);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(829, 541);
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_sach;
        private System.Windows.Forms.ToolStripMenuItem item_docgia;
        private System.Windows.Forms.ToolStripMenuItem item_muontra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
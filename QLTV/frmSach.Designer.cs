namespace QLTV
{
    partial class frmSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txtb_tim = new System.Windows.Forms.TextBox();
            this.cb_tim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.txtb_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_tacgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_theloai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_nxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_soluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.Transparent;
            this.grb1.Controls.Add(this.btn_xoa);
            this.grb1.Controls.Add(this.btn_sua);
            this.grb1.Controls.Add(this.btn_them);
            this.grb1.Controls.Add(this.txtb_tim);
            this.grb1.Controls.Add(this.cb_tim);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb1.Location = new System.Drawing.Point(0, 0);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(813, 50);
            this.grb1.TabIndex = 1;
            this.grb1.TabStop = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(688, 16);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(595, 16);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(499, 16);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txtb_tim
            // 
            this.txtb_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_tim.Location = new System.Drawing.Point(214, 18);
            this.txtb_tim.Name = "txtb_tim";
            this.txtb_tim.Size = new System.Drawing.Size(235, 21);
            this.txtb_tim.TabIndex = 2;
            this.txtb_tim.TextChanged += new System.EventHandler(this.txtb_tim_TextChanged);
            // 
            // cb_tim
            // 
            this.cb_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tim.ForeColor = System.Drawing.Color.Black;
            this.cb_tim.FormattingEnabled = true;
            this.cb_tim.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tác Giả"});
            this.cb_tim.Location = new System.Drawing.Point(86, 17);
            this.cb_tim.Name = "cb_tim";
            this.cb_tim.Size = new System.Drawing.Size(121, 23);
            this.cb_tim.TabIndex = 1;
            this.cb_tim.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sách";
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(147, 95);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(231, 20);
            this.txtb_id.TabIndex = 3;
            // 
            // txtb_ten
            // 
            this.txtb_ten.Location = new System.Drawing.Point(147, 140);
            this.txtb_ten.Name = "txtb_ten";
            this.txtb_ten.Size = new System.Drawing.Size(231, 20);
            this.txtb_ten.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(74, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Sách";
            // 
            // txtb_tacgia
            // 
            this.txtb_tacgia.Location = new System.Drawing.Point(147, 186);
            this.txtb_tacgia.Name = "txtb_tacgia";
            this.txtb_tacgia.Size = new System.Drawing.Size(231, 20);
            this.txtb_tacgia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(74, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tác Giả";
            // 
            // txtb_theloai
            // 
            this.txtb_theloai.Location = new System.Drawing.Point(507, 96);
            this.txtb_theloai.Name = "txtb_theloai";
            this.txtb_theloai.Size = new System.Drawing.Size(229, 20);
            this.txtb_theloai.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(434, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thể Loại";
            // 
            // txtb_nxb
            // 
            this.txtb_nxb.Location = new System.Drawing.Point(507, 141);
            this.txtb_nxb.Name = "txtb_nxb";
            this.txtb_nxb.Size = new System.Drawing.Size(229, 20);
            this.txtb_nxb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(434, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "NXB";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_soluong
            // 
            this.txtb_soluong.Location = new System.Drawing.Point(507, 187);
            this.txtb_soluong.Name = "txtb_soluong";
            this.txtb_soluong.Size = new System.Drawing.Size(229, 20);
            this.txtb_soluong.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label7.Location = new System.Drawing.Point(434, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label8.Location = new System.Drawing.Point(280, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Danh sách đầu sách";
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::QLTV.Properties.Resources.background_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 503);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtb_soluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_nxb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_theloai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_tacgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 541);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(829, 541);
            this.Name = "frmSach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txtb_tim;
        private System.Windows.Forms.ComboBox cb_tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.TextBox txtb_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_tacgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_theloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_nxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_soluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
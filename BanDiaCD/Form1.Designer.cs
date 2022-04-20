namespace BanDiaCD
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkKM = new System.Windows.Forms.CheckBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.btnnewkhach = new System.Windows.Forms.Button();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formChữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnxemthongke = new System.Windows.Forms.Button();
            this.lblavg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbltongsoluong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 550);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkKM);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btntinhtien);
            this.groupBox2.Controls.Add(this.btnnewkhach);
            this.groupBox2.Controls.Add(this.lblthanhtien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtmakh);
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 320);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // chkKM
            // 
            this.chkKM.AutoSize = true;
            this.chkKM.Location = new System.Drawing.Point(284, 242);
            this.chkKM.Name = "chkKM";
            this.chkKM.Size = new System.Drawing.Size(162, 20);
            this.chkKM.TabIndex = 15;
            this.chkKM.Text = "(Giảm 3% Thành Tiền)";
            this.chkKM.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(547, 224);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(125, 50);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "&Thoát";
            this.toolTip1.SetToolTip(this.btnthoat, "Nhấn để thoát");
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(547, 148);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(125, 50);
            this.btntinhtien.TabIndex = 13;
            this.btntinhtien.Text = "&Tính Thuê";
            this.toolTip1.SetToolTip(this.btntinhtien, "Nhấn để tính giá thuê");
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // btnnewkhach
            // 
            this.btnnewkhach.Location = new System.Drawing.Point(547, 71);
            this.btnnewkhach.Name = "btnnewkhach";
            this.btnnewkhach.Size = new System.Drawing.Size(125, 50);
            this.btnnewkhach.TabIndex = 13;
            this.btnnewkhach.Text = "&Khách Mới";
            this.toolTip1.SetToolTip(this.btnnewkhach, "Nhấn để Thêm khách mới");
            this.btnnewkhach.UseVisualStyleBackColor = true;
            this.btnnewkhach.Click += new System.EventHandler(this.btnnewkhach_Click);
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblthanhtien.Location = new System.Drawing.Point(284, 279);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(177, 30);
            this.lblthanhtien.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thành Tiền :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trả Đúng Hạn :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đơn Giá :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số Lượng :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ vs Tên KH:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã KH:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(284, 190);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(177, 22);
            this.txtdongia.TabIndex = 2;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(284, 148);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(177, 22);
            this.txtsoluong.TabIndex = 3;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(284, 103);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(177, 22);
            this.txtname.TabIndex = 4;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(284, 58);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(177, 22);
            this.txtmakh.TabIndex = 5;
            this.txtmakh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmakh_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.tùyChọnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhThuêToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // tínhThuêToolStripMenuItem
            // 
            this.tínhThuêToolStripMenuItem.Name = "tínhThuêToolStripMenuItem";
            this.tínhThuêToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.tínhThuêToolStripMenuItem.Text = "Tính Thuê";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.màuToolStripMenuItem,
            this.formChữToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.tùyChọnToolStripMenuItem.Text = "Tùy Chọn";
            // 
            // màuToolStripMenuItem
            // 
            this.màuToolStripMenuItem.Name = "màuToolStripMenuItem";
            this.màuToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.màuToolStripMenuItem.Text = "Màu";
            // 
            // formChữToolStripMenuItem
            // 
            this.formChữToolStripMenuItem.Name = "formChữToolStripMenuItem";
            this.formChữToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.formChữToolStripMenuItem.Text = "Form Chữ";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // abToolStripMenuItem
            // 
            this.abToolStripMenuItem.Name = "abToolStripMenuItem";
            this.abToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.abToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnxemthongke);
            this.groupBox1.Controls.Add(this.lblavg);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbltongsoluong);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbltongtien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(589, 119);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(150, 50);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btnclear, "Nhấn để xóa dữ liệu hiện tại");
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnxemthongke
            // 
            this.btnxemthongke.Location = new System.Drawing.Point(589, 31);
            this.btnxemthongke.Name = "btnxemthongke";
            this.btnxemthongke.Size = new System.Drawing.Size(150, 50);
            this.btnxemthongke.TabIndex = 13;
            this.btnxemthongke.Text = "Xem Thống kê";
            this.toolTip1.SetToolTip(this.btnxemthongke, "Nhấn để xem tổng doanh thu");
            this.btnxemthongke.UseVisualStyleBackColor = true;
            this.btnxemthongke.Click += new System.EventHandler(this.btnxemthongke_Click);
            // 
            // lblavg
            // 
            this.lblavg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblavg.Location = new System.Drawing.Point(284, 136);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(180, 30);
            this.lblavg.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Trung Bình / Lần Bán";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbltongsoluong
            // 
            this.lbltongsoluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbltongsoluong.Location = new System.Drawing.Point(284, 90);
            this.lbltongsoluong.Name = "lbltongsoluong";
            this.lbltongsoluong.Size = new System.Drawing.Size(180, 30);
            this.lbltongsoluong.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tổng Số Lượng CD";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbltongtien
            // 
            this.lbltongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbltongtien.Location = new System.Drawing.Point(284, 48);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(180, 30);
            this.lbltongtien.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng Tiền";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Bán CD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.Button btnnewkhach;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxemthongke;
        private System.Windows.Forms.Label lblavg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltongsoluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem tínhThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formChữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkKM;
        private System.Windows.Forms.Button btnclear;
    }
}


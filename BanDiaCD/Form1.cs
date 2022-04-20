using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BanDiaCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long ttien = 0;
        int dem = 0;
        long tsluong = 0;

        long dongia = 0;
        int soluong = 0;
        long tinhtien = 0;

        // tạo ra quy tất chỉ cho nhập số
        Regex regSo = new Regex(@"[^0-9]");
        //tạo ra quy tất chỉ cho nhập ký tự có khoản cách
        Regex regNeme = new Regex(@"[^a-zA-Z\s]");
        //tạo ra quy tất chỉ cho nhập ký tự có khoản cách với được nhập số
        Regex regMakh = new Regex(@"[^a-zA-Z0-9]");

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn thoát chứ ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
        private void txtmakh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra không cho nhập vào ký tự đặt biệt với khoản cách
            if (regMakh.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra không cho nhập vào ký tự đặt biệt, không được nhập số
            if (regNeme.IsMatch(e.KeyChar.ToString())&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra không cho nhập vào ký tự đặt biệt với khoản cách. được nhập số
            if (regSo.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra không cho nhập vào ký tự đặt biệt với khoản cách. được nhập số
            if (regSo.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkKM.Checked == false)
                {
                    // tính tiền khi không có kuyến mãi
                    soluong = int.Parse(txtsoluong.Text);
                    dongia = int .Parse(txtdongia.Text);
                    tinhtien = soluong * dongia;

                }
                else
                {
                    // tính tiền khi có kuyến mãi
                    soluong = int.Parse(txtsoluong.Text);
                    dongia = int.Parse(txtdongia.Text);
                    //ép kiểu dữ liệu
                    tinhtien = (long)(0.97 * soluong * dongia);

                }
                //vô hiệu hóa không cho nhập khách hàng mới. khi chưa click vào "Khách Mới"
                txtmakh.Enabled = false;
                txtname.Enabled = false;

                
                lblthanhtien.Text = tinhtien.ToString();

                //Tính tổng doanh thu đã thu được lưa vào bộ nhớ
                dem++;
                ttien += tinhtien;
                tsluong += soluong;
            }
            catch (Exception err)
            {
                //thực hiện khi có lỗi sải khi, vd: người đùng chưa nhập giá trị
                MessageBox.Show("Bạn chưa nhập đủ giá trị !!!");
            }
        }

        private void btnnewkhach_Click(object sender, EventArgs e)
        {
            //bật tính năng nhâp thông tin khách hàng lại
            txtmakh.Enabled = true;
            txtname.Enabled = true;
            //xóa thông tin người khách hàng củ
            txtmakh.Clear();
            txtname.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
            chkKM.Checked = false;
            lblthanhtien.Text = "";
        }

        private void btnxemthongke_Click(object sender, EventArgs e)
        {
            //hiển thị thông tinh doanh thu tổng số
            lbltongtien.Text = ttien.ToString();
            lbltongsoluong.Text = tsluong.ToString();
            lblavg.Text = (ttien / tsluong).ToString();
            //vô hiệu hóa nút "xem thống kê"
            btnxemthongke.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //xóa thông tin dang hiển thi
            txtmakh.Clear();
            txtname.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
            chkKM.Checked = false;
            lblthanhtien.Text = "";
            lbltongtien.Text = "";
            lbltongsoluong.Text = "";
            lblavg.Text = "";
            //xóa bỏ vô hiệu hóa nút "xem thống kê"
            btnxemthongke.Enabled = true;
        }
    }

    // chưa xong
}

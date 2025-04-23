using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TTCS
{
    public partial class home : Form
    {
        SqlConnection ketnoi = new SqlConnection(KetNoiSQL.sql);
        SqlCommand cmd;
        string sql;
        DataTable dt;
        SqlDataAdapter da;
        public home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = ID.getid();
            string MaK, TenK, SDT, CMND, DiaChi;
            if (s == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập.");
            }
            else
            {
                if (s == "admin")
                {
                    KhachHang form = new KhachHang();
                    form.ShowDialog();
                }
                else
                {
                    ketnoi.Open();
                    sql = "select* from KhachHang where MaK in (select MaK from TaiKhoan where TK='" + s + "')";
                    cmd = new SqlCommand(sql, ketnoi);
                    SqlDataReader docdulieu;
                    docdulieu = cmd.ExecuteReader();
                    if (docdulieu.Read())
                    {
                        MaK = docdulieu[0].ToString();
                        TenK = docdulieu[1].ToString();
                        SDT = docdulieu[2].ToString();
                        CMND = docdulieu[3].ToString();
                        DiaChi = docdulieu[4].ToString();

                        MessageBox.Show("Mã Khách Hàng: " + MaK + "\nTên: " + TenK + "\nSDT : " + SDT + "\nSố CMND : " + CMND + "\nĐịa chỉ: " + DiaChi, "Thông tin khách hàng.");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu Khách hàng.");
                    }
                    ketnoi.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phong form = new Phong();
            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void home_Load(object sender, EventArgs e)
        {
            string tk = ID.getid();
            if (tk == null)
            {
                label7.Text = "[KHÁCH]";
                btDangxuat.Visible = false;
                btDangNhap.Visible = true;
            }
            else
            {
                label7.Text ="Xin chào: [ "+tk+" ]";
                btDangNhap.Visible = false;
                btDangxuat.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
            
        }

        private void btDangxuat_Click(object sender, EventArgs e)
        {
            ID.setid(null);
            home_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = ID.getid();
            string MaHD, MaK, MaP, NgayBD, NgayKT;
            if (s == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập.");
            }
            else
            {
                if (s == "admin")
                {
                    HopDong form = new HopDong();
                    form.Show();
                }
                else
                {
                    ketnoi.Open();
                    sql = "select* from HopDong where MaK in (select MaK from TaiKhoan where TK='" + s + "')";
                    cmd = new SqlCommand(sql, ketnoi);
                    SqlDataReader docdulieu;
                    docdulieu = cmd.ExecuteReader();
                    if (docdulieu.Read())
                    {
                        MaHD = docdulieu[0].ToString();
                        MaK = docdulieu[1].ToString();
                        MaP = docdulieu[2].ToString();
                        NgayBD = docdulieu[3].ToString();
                        NgayKT = docdulieu[4].ToString();

                        MessageBox.Show("Mã HĐ: " + MaHD + "\nMã khách: " + MaK + "\nMaP : " + MaP + "\nNgày bắt đầu : " + NgayBD + "\nNgày hết hạn : " + NgayKT, "Thông tin hợp đồng.");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu hợp đồng.");
                    }
                    ketnoi.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = ID.getid();
            if (s == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập.");
            }
            else
            {
                HoaDon frm = new HoaDon();
                frm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ID.getid() == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập.");
            }
            else
            {
                Ac frm = new Ac();
                frm.ShowDialog();
            }
        }
    }
}

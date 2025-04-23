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
    public partial class Ac : Form
    {
        SqlConnection ketnoi = new SqlConnection(KetNoiSQL.sql);
        SqlCommand cmd;
        string sql;
        DataTable dt;
        SqlDataAdapter da;
        
        public Ac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plDoiMK.Visible = true;
            plTao.Visible = false;
            plCLMK.Visible = false;
            plXTK.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plDoiMK.Visible = false;
            plTao.Visible = false;
            plCLMK.Visible = false;
            plXTK.Visible = false;
        }
        private void loadcbbtk(ComboBox cb)
        {
            ketnoi.Open();
            sql = "select * from KhachHang";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cb.DisplayMember = "MaK";
            cb.DataSource = dt;
            ketnoi.Close();
        }
        private void loadcbbtk2(ComboBox cb)
        {
            ketnoi.Open();
            sql = "select * from TaiKhoan";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cb.DisplayMember = "TK";
            cb.DataSource = dt;
            ketnoi.Close();
        }

        private void btOKDoiMK_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string tk = ID.getid();
            string mk = ID.getmk();
            if (txtDMKC.Text != mk)
            {
                MessageBox.Show("Mật khẩu cũ không đúng, vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                if (txtDMkMoi.Text == txtDMkMoi2.Text)
                {
                    sql = "update TaiKhoan set MK='" + txtDMkMoi2.Text + "'  where TK='" + tk + "'and MK='" + mk + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mật khẩu của bạn đã được thay đổi thành công.","Thông báo");
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới bạn nhập không trùng nhau\nvui lòng kiểm tra lại.", "Thông báo");
                }    
            }
            ketnoi.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tk = ID.getid();
            if (tk == "admin")
            {
                plDoiMK.Visible = false;
                plTao.Visible = true;
                plCLMK.Visible = false;
                plXTK.Visible = false;
                loadcbbtk(cbbDSKH);
            }
            else
                MessageBox.Show("Chỉ admin mới có quyền tạo tài khoản\nLiên hệ Admin để được hỗ trợ.","Thông báo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
                try
            {
               
                sql = " insert into TaiKhoan values ('" + txtTTK.Text + "',N'" + txtTMK.Text + "','" + cbbDSKH.Text + "')";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Tạo tài khoản thành công.");
            }
            catch
            {
                MessageBox.Show("Tên TK trùng hoặc có lỗi khi nhập dữ liệu\nTạo không thành công.", "Lỗi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tk = ID.getid();
            if (tk == "admin")
            {
                plDoiMK.Visible = false;
                plTao.Visible = false;
                plCLMK.Visible = true;
                plXTK.Visible = false;
                loadcbbtk2(cbbDTK);
            }
            else
                MessageBox.Show("Chỉ admin mới có quyền cấp lại MK\nLiên hệ Admin để được hỗ trợ.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = "update TaiKhoan set MK='" + txtCMK.Text + "' where TK='" + cbbDTK.Text + "'";
            cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã cập nhật lại mật khẩu thành công.");
            ketnoi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tk = ID.getid();
            if (tk == "admin")
            {
                plDoiMK.Visible = false;
                plTao.Visible = false;
                plCLMK.Visible = false;
                plXTK.Visible = true;
                loadcbbtk2(cbbXTK);
            }
            else
                MessageBox.Show("Chỉ admin mới có quyền xóa tài khoản\nLiên hệ Admin để được hỗ trợ.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            if (cbbXTK.Text == "admin")
            {
                MessageBox.Show("Không thể xóa tk admin.");
            }
            else
            {
                sql = "delete from TaiKhoan where TK='" + cbbXTK.Text + "'";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa tài khoản Thành công.");
                ketnoi.Close();
            }
        }
    }
    }


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
    public partial class KhachHang : Form
    {
        SqlConnection ketnoi = new SqlConnection(KetNoiSQL.sql);
        SqlCommand cmd;
        string sql;
        DataTable dt;
        SqlDataAdapter da;
        public KhachHang()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plThem.Visible = true;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTK.Visible = false;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTK.Visible = false;
            hienthi();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            plThem.Visible = false;
            plSua.Visible = true;
            plXoa.Visible = false;
            plTK.Visible = false;
            loadcbb(cbbSMa);
        }
        private void loadcbb(ComboBox cb)
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
        private void button3_Click(object sender, EventArgs e)
        {
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = true;
            plTK.Visible = false;
            loadcbb(cbbXMa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTK.Visible = true;
        }
        private void hienthi()
        {
            sql = "select* from KhachHang";
            cmd = new SqlCommand(sql, ketnoi);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btOkTk_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                if (cbbTk.Text == "Tên Khách")
                {
                    sql = "select * from KhachHang where TenK=N'" + txtNDTK.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    ketnoi.Close();
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp.");
                    }
                }
                if (cbbTk.Text == "SDT")
                {
                    sql = "select * from KhachHang where SDT='" + txtNDTK.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    ketnoi.Close();
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp.");
                    }
                }
                if (cbbTk.Text == "Số CMND")
                {
                    sql = "select * from KhachHang where CMND='" + txtNDTK.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    ketnoi.Close();
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp.");
                    }
                }
                if (cbbTk.Text == "Địa Chỉ")
                {
                    sql = "select * from KhachHang where DiaChi=N'" + txtNDTK.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    ketnoi.Close();
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp.");
                    }
                }
                if (cbbTk.Text == "Mã Khách")
                {
                    sql = "select * from KhachHang where MaK='" + txtNDTK.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    ketnoi.Close();
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu.");
            }
            ketnoi.Close();
           
        }

        private void btOKXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = "delete from KhachHang where MaK='" +cbbXMa.Text + "'";
            cmd = new SqlCommand(sql, ketnoi);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu.");
            }
            ketnoi.Close();
            hienthi();
        }

        private void btOkSua_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                if (cbbChons.Text == "Tên Khách")
                {
                    sql = "update KhachHang set TenK=N'" + txtNds.Text + "' where MaK='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
                if (cbbChons.Text == "SDT")
                {
                    sql = "update KhachHang set SDT='" + txtNds.Text + "' where MaK='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
                if (cbbChons.Text == "Số CMND")
                {
                    sql = "update KhachHang set CMND='" + txtNds.Text + "' where MaK='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
                if (cbbChons.Text == "Địa Chỉ")
                {
                    sql = "update KhachHang set DiaChi=N'" + txtNds.Text + "' where MaK='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu.");
            }
            ketnoi.Close();
            hienthi();
        }

        private void btOkThem_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                sql = " insert into KhachHang values ('" + txtTMaKhach.Text + "',N'" + txtTTenKhach.Text + "','" + txtTSDT.Text + "','" + txtTCMND.Text + "',N'" + textBox1.Text + "')";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu.");
            }
            ketnoi.Close();
            hienthi();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KhachHang_Load(sender, e);
        }
    }
}

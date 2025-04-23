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
    public partial class HopDong : Form
    {
        SqlConnection ketnoi = new SqlConnection(KetNoiSQL.sql);
        SqlCommand cmd;
        string sql;
        DataTable dt;
        SqlDataAdapter da;

        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            hienthi();
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTK.Visible = false;
            plGiaHan.Visible = false;
        }
        private void hienthi()
        {
            sql = "select* from HopDong";
            cmd = new SqlCommand(sql, ketnoi);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plThem.Visible = true;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTK.Visible = false;
            plGiaHan.Visible = false;

        }

        private void btOkThem_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                sql = " insert into HopDong values ('" +txtTMaHD.Text + "',N'" + txtTMK.Text + "','" + txtTMP.Text + "','" + dtBD.Text + "','" + dtKT.Text + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
           
            plThem.Visible = false;
            plSua.Visible = true;
            plXoa.Visible = false;
            plTK.Visible = false;
            plGiaHan.Visible = false;
            loadcbb(cbbSMa);
            dtSdate.Visible = false;

        }

        private void btOkSua_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                if (cbbChonS.Text == "Mã Khách")
                {
                    sql = "update HopDong set MaK=N'" + txtNds.Text + "' where MaHD='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
                if (cbbChonS.Text == "Mã Phòng")
                {
                    sql = "update HopDong set MaP=N'" + txtNds.Text + "' where MaHD='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
                if (cbbChonS.Text == "Ngày Bắt Đầu")
                {
                    sql = "update HopDong set NgayBD=N'" + dtSdate.Text + "' where MaHD='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
                if (cbbChonS.Text == "Ngày Kết Thúc")
                {
                    sql = "update HopDong set NgayKT=N'" + dtSdate.Text + "' where MaHD='" + cbbSMa.Text + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Sửa thành công.");
            }
            catch
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu.");
            }
            ketnoi.Close();
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = true;
            plTK.Visible = false;
            plGiaHan.Visible = false;
            loadcbb(cbbXMa);
        }

        private void btOKXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = "delete from HopDong where MaHD='" + cbbXMa.Text + "'";
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

        private void btOkTk_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                if (cbbTk.Text == "Mã Hợp Đồng")
                {
                    sql = "select * from HopDong where MaHD='" + txtNDTK.Text + "'";
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
                    sql = "select * from HopDong where MaK='" + txtNDTK.Text + "'";
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
                if (cbbTk.Text == "Mã Phòng")
                {
                    sql = "select * from HopDong where MaP='" + txtNDTK.Text + "'";
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
                if (cbbTk.Text == "Sắp Hết Hạn")
                {
                    sql = "select * from HopDong where  DATEDIFF(DAY,GETDATE(),NgayKT)<"+txtNDTK.Text+"";
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

        private void button4_Click(object sender, EventArgs e)
        {
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTK.Visible = true;
            plGiaHan.Visible = false;
        }

        private void cbbTk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTk.Text == "Sắp Hết Hạn")
                _ = MessageBox.Show("Nhập nội dung là số ngày còn lại.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOkGH_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                sql = "update HopDong set NgayKT = DATEADD(month," + lsThang.Text + ", NgayKT)where MaHD = '" + cbbGhMa.Text + "' ";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã gia hạn thành công,\nMã HĐ" + cbbGhMa.Text + " số tháng cộng thêm: " + lsThang.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn số tháng.");
            }
            ketnoi.Close();
            hienthi();
        }
        private void loadcbb(ComboBox cb)
        {
            ketnoi.Open();
            sql = "select * from HopDong";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cb.DisplayMember = "MaHD";
            cb.DataSource = dt;
            ketnoi.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTK.Visible = false;
            plGiaHan.Visible = true;
            loadcbb(cbbGhMa);
        }

        private void cbbChonS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbChonS.Text== "Ngày Bắt Đầu" || cbbChonS.Text== "Ngày Kết Thúc")
            {
                dtSdate.Visible = true;
                txtNds.Visible = false;
                label5.Text = "     Ngày :";
                
            }
            else
            {
                dtSdate.Visible = false;
                txtNds.Visible = true;
                label5.Text = "Nội dung :";
            }

        }

        private void dtSdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HopDong_Load(sender, e);
        }
    }
}

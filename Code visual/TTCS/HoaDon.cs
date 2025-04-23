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
using System.Data.Common;

namespace TTCS
{
    public partial class HoaDon : Form
    {
        SqlConnection ketnoi = new SqlConnection(KetNoiSQL.sql);
        SqlCommand cmd;
        string sql;
        DataTable dt;
        SqlDataAdapter da;
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            string s = ID.getid();
            if (s == "admin")
            {
                LoadCombobox();
                LoadCombobox2();
                LoadCombobox3();
                LoadCombobox5();
                plTao.Visible = false;
                plSua.Visible = false;
                plXoa.Visible = false;
                plTT.Visible = false;
            }
            else
            {
                LoadCombobox2(s);
                btTao.Visible = false;
                btSua.Visible = false;
                btXoa.Visible = false;
                btTT.Visible = false;
                plTao.Visible = false;
                plSua.Visible = false;
                plXoa.Visible = false;
                plTT.Visible = false;
            }    
           
        }
        private void LoadCombobox3()
        {
            ketnoi.Open();
            sql = "select MaP from Phong";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaP4.DisplayMember = "MaP";
            cbbMaP4.DataSource = dt;
            
          
            ketnoi.Close();
        }

        private void LoadCombobox5()
        {
            ketnoi.Open();
            sql = "select MaP from Phong";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaP5.DisplayMember = "MaP";
            cbbMaP5.DataSource = dt;

            ketnoi.Close();
        }
        private void LoadCombobox()
        {
            ketnoi.Open();
            sql = "select MaP from Phong";
            cmd = new SqlCommand(sql, ketnoi);
            var dr= cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaP1.DisplayMember = "MaP";
            cbbMaP3.DisplayMember = "MaP";
           
            cbbMaP1.DataSource = dt;
            cbbMaP3.DataSource = dt;
           
            ketnoi.Close();
        }
        private void LoadCombobox2()
        {
            ketnoi.Open();
            sql = "select MaP from Phong where MaP in(select MaP from HopDong)";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaP2.DisplayMember = "MaP";
            cbbMaP2.DataSource = dt;
            ketnoi.Close();
        }
        private void LoadCombobox2(string tk)
        {
            ketnoi.Open();
            sql = "select MaP from HopDong where MaK in (select MaK from TaiKhoan where TK= '"+tk+"')";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaP2.DisplayMember = "MaP";
            cbbMaP2.DataSource = dt;
            ketnoi.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbbMaP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbbMaP2.Text;
            hienthi(ma);
                
        }
       
        private void hienthi(string ma)
        {
            
            sql = "select* from HoaDon where MaP='"+ma+"' ";
            cmd = new SqlCommand(sql, ketnoi);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cbbMaP2.Text = ma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plTao.Visible = true;
            plSua.Visible = false;
            plXoa.Visible = false;
            plTT.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dien, nuoc;
            dien = (int.Parse(txtDienMoi.Text)) - (int.Parse(txtDienCu.Text));
            nuoc = (int.Parse(txtNuocMoi.Text)) - (int.Parse(txtNuocCu.Text));
            dien = dien * 2500;
            nuoc = nuoc * 8000;
            string s = "NULL";


            sql = "insert into HoaDon values ('" + cbbMaP1.Text + "',N'" + txtThangNam.Text + "',"+dien+"," +nuoc+","+s+@")";
            ketnoi.Open();
            try
            {
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã tạo Hóa đơn thành công.");
                hienthi(cbbMaP1.Text);
                cbbMaP2.Text = cbbMaP1.Text;
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tạo, vui lòng kiểm tra lại");
            }
            ketnoi.Close();

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            plSua.Visible = true;
            plTao.Visible = false;
            plXoa.Visible = false;
            plTT.Visible = false;
            grbDien.Visible = false;
            grbNuoc.Visible = false;
           
        }

        private void btOkSua_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
           if(comboBox2.Text=="Điện")
            {
                int dien;
                dien = (int.Parse(txtsd2.Text)) - (int.Parse(txtsd1.Text));
                dien = dien * 2500;
                sql = "update HoaDon set Dien=" + dien + " where MaP='" + cbbMaP3.Text + "' and ThangNam='" + cbbSTN.Text + "'";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa chỉ số điện phòng " + cbbMaP3.Text + " Thành công.");
            }
            if (comboBox2.Text == "Nước")
            {
                int nuoc;
                nuoc = (int.Parse(txtsn2.Text)) - (int.Parse(txtsn1.Text));
                nuoc = nuoc * 2500;
                sql = "update HoaDon set Nuoc=" + nuoc + " where MaP='" + cbbMaP3.Text + "' and ThangNam='" + cbbSTN.Text + "'";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa chỉ số nước phòng " + cbbMaP3.Text + " Thành công.");
            }
            ketnoi.Close();
            hienthi(cbbMaP3.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Điện")
            {
                grbDien.Visible = true;
                grbNuoc.Visible = false;
            }
            if (comboBox2.Text == "Nước")
            {
                grbDien.Visible = false;
                grbNuoc.Visible = true;
            }
        }

        private void btOkXoa_Click(object sender, EventArgs e)
        {

            ketnoi.Open();
            try
            {
                sql = "delete from HoaDon where MaP='" + cbbMaP4.Text + "' and ThangNam='" + cbbXTN.Text + "'";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi nhập, Xóa không thành công.");
            }
            ketnoi.Close();
            hienthi(cbbMaP4.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            plSua.Visible = false;
            plTao.Visible = false;
            plXoa.Visible = true;
            plTT.Visible = false;
        }

        private void btTT_Click(object sender, EventArgs e)
        {

            
            plSua.Visible = false;
            plTao.Visible = false;
            plXoa.Visible = false;
            plTT.Visible = true;
            
        }

        private void btOkTT_Click(object sender, EventArgs e)
        {

            ThanhToan(cbbMaP5.Text, cbbTTTN.Text);
        }
        
   
        private void loadcbb(ComboBox cb,string s)
        {
           
            ketnoi.Close();
            ketnoi.Open();
            sql = "select * from HoaDon where MaP='" + s + "'";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cb.DisplayMember = "ThangNam";
            cb.DataSource = dt;
            ketnoi.Close();
        }
        private void cbbMaP5_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbb(cbbTTTN, cbbMaP5.Text);
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dien, nuoc;
            string date;
            int i = dataGridView1.CurrentCell.RowIndex;
            dien = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            nuoc= int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            date = dataGridView1.Rows[i].Cells[4].Value.ToString();
            if (date != "")
            {
                MessageBox.Show("Hóa đơn này đã thanh toán.");
            }
            else
            {
                MessageBox.Show("Tổng tiền phải thanh toán là : " + (dien + nuoc));
            }
        }
        private void ThanhToan(string ma,string tg)
        {
            ketnoi.Open();
            int dien, nuoc;
            string tt;
            sql = "select Dien,Nuoc,NgayNop from HoaDon where MaP='" + ma+ "' and ThangNam='" + tg + "'";
            cmd = new SqlCommand(sql, ketnoi);
            SqlDataReader docdulieu;
            docdulieu = cmd.ExecuteReader();
            if (docdulieu.Read())
            {
                dien = Int32.Parse(docdulieu[0].ToString());
                nuoc = Int32.Parse(docdulieu[1].ToString());
                tt = docdulieu[2].ToString();
                if (tt != "")
                {
                    MessageBox.Show("Hóa đơn này đã thanh toán.");
                }
                else
                {
                    MessageBox.Show("Tổng số tiền của phòng " + ma + " tháng " + tg + " là : " + (dien + nuoc), "Thông báo");
                    ketnoi.Close();
                    ketnoi.Open();
                    sql = "update HoaDon set NgayNop = GETDATE() where MaP = '" + ma + "' and ThangNam = '" + tg + "'";
                    cmd = new SqlCommand(sql, ketnoi);
                    DialogResult f = MessageBox.Show("Xác nhận thanh toán.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (f == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thanh toán thành công.");

                    }
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin hóa đơn.");
            }

            ketnoi.Close();
            hienthi(ma);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HoaDon_Load(sender, e);
        }

        private void cbbTTTN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaP4_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbb(cbbXTN, cbbMaP4.Text);
        }

        private void cbbMaP3_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbb(cbbSTN, cbbMaP3.Text);
        }
    }
}

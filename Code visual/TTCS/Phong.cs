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
    public partial class Phong : Form
    {
        SqlConnection ketnoi = new SqlConnection(KetNoiSQL.sql);
        SqlCommand cmd;
        string sql;
        DataTable dt;
        SqlDataAdapter da;
        
        public Phong()
        {
            InitializeComponent();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            
            plThem.Visible = false;
            plSua.Visible = false;
            plXoa.Visible = false;
            setPhong();
            hienthi();
            if(ID.getid()=="admin")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }    
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }    
        }
        private void setPhong()
        {
            ketnoi.Open();
            sql = "update Phong set TT = N'Có Khách'where MaP in (select MaP from HopDong where DATEDIFF(day,GETDATE(),NgayKT)>0)";
            cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            ketnoi.Close();
        }
        private void hienthi()
        {
            sql = "select* from Phong";
            cmd = new SqlCommand(sql, ketnoi);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plThem.Visible = true;
            plSua.Visible = false;
            plXoa.Visible = false;
           
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            if (cbbChon.Text == "Tên phòng")
            {
                sql = "update Phong set TenP=N'" + txtNd.Text + "' where MaP='" + cbbSMa.Text + "'";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
            }
            if (cbbChon.Text == "Giá")
            {
                sql = "update Phong set Gia='" + txtNd.Text + "' where MaP='" + cbbSMa.Text + "'";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
            }
            if (cbbChon.Text == "Trạng thái")
            {
                sql = "update Phong set TT=N'" + txtNd.Text + "' where MaP='" + cbbSMa.Text + "'";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
            }
            ketnoi.Close();
            hienthi();
        }
        private void loadcbb(ComboBox cb)
        {
            ketnoi.Open();
            sql = "select * from Phong";
            cmd = new SqlCommand(sql, ketnoi);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cb.DisplayMember = "MaP";
            cb.DataSource = dt;
            ketnoi.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            plSua.Visible = true;
            plThem.Visible = false;
            plXoa.Visible = false;
            loadcbb(cbbSMa);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = "delete from Phong where MaP='" + cbbXMa.Text + "'";
            cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plXoa.Visible = true;
            plThem.Visible = false;
            plSua.Visible = false;
            loadcbb(cbbXMa);
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
                ketnoi.Open();
                sql = " insert into Phong values ('" + txtTMa.Text + "',N'" + txtTTen.Text + "','" + txtTGia.Text + "',N'Trống')";
                cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                ketnoi.Close();
                hienthi();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = "select * from Phong where TT=N'Trống' ";
            cmd = new SqlCommand(sql, ketnoi);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}

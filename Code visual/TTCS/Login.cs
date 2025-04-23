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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(KetNoiSQL.sql);
        SqlCommand cmd;
        string sql;
        DataTable dt;
        SqlDataAdapter da;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            home frm = new home();
            frm.Show();
            this.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = "select * from TaiKhoan where TK = N'" + txtTK.Text + "' and MK=N'" + txtMK.Text + "' ";
            da = new SqlDataAdapter(sql, ketnoi);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ID.setid(txtTK.Text);
                ID.setmk(txtMK.Text);
                home frm = new home();
                frm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.");
            }
            ketnoi.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Vui lòng liên hệ admin\nđể được cấp lại mật khẩu. ", "Thông báo");
        }
    }
}

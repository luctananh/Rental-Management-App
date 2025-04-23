
namespace TTCS
{
    partial class Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phong));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTTen = new System.Windows.Forms.TextBox();
            this.txtTGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btOkThem = new System.Windows.Forms.Button();
            this.plThem = new System.Windows.Forms.Panel();
            this.plSua = new System.Windows.Forms.Panel();
            this.cbbSMa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbChon = new System.Windows.Forms.ComboBox();
            this.btOkSua = new System.Windows.Forms.Button();
            this.txtNd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.plXoa = new System.Windows.Forms.Panel();
            this.cbbXMa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btOKXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.plThem.SuspendLayout();
            this.plSua.SuspendLayout();
            this.plXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaP";
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenP";
            this.Column2.HeaderText = "Tên Phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gia";
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TT";
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(151, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(151, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Location = new System.Drawing.Point(151, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(151, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Phòng trống";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên phòng :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTMa
            // 
            this.txtTMa.Location = new System.Drawing.Point(93, 2);
            this.txtTMa.Name = "txtTMa";
            this.txtTMa.Size = new System.Drawing.Size(100, 20);
            this.txtTMa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Phòng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTTen
            // 
            this.txtTTen.Location = new System.Drawing.Point(93, 31);
            this.txtTTen.Name = "txtTTen";
            this.txtTTen.Size = new System.Drawing.Size(100, 20);
            this.txtTTen.TabIndex = 11;
            // 
            // txtTGia
            // 
            this.txtTGia.Location = new System.Drawing.Point(93, 60);
            this.txtTGia.Name = "txtTGia";
            this.txtTGia.Size = new System.Drawing.Size(100, 20);
            this.txtTGia.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giá :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btOkThem
            // 
            this.btOkThem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btOkThem.Location = new System.Drawing.Point(93, 87);
            this.btOkThem.Name = "btOkThem";
            this.btOkThem.Size = new System.Drawing.Size(75, 23);
            this.btOkThem.TabIndex = 15;
            this.btOkThem.Text = "OK";
            this.btOkThem.UseVisualStyleBackColor = false;
            this.btOkThem.Click += new System.EventHandler(this.button5_Click);
            // 
            // plThem
            // 
            this.plThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plThem.BackgroundImage")));
            this.plThem.Controls.Add(this.btOkThem);
            this.plThem.Controls.Add(this.label3);
            this.plThem.Controls.Add(this.txtTGia);
            this.plThem.Controls.Add(this.label2);
            this.plThem.Controls.Add(this.txtTTen);
            this.plThem.Controls.Add(this.label1);
            this.plThem.Controls.Add(this.txtTMa);
            this.plThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plThem.Location = new System.Drawing.Point(232, 12);
            this.plThem.Name = "plThem";
            this.plThem.Size = new System.Drawing.Size(229, 110);
            this.plThem.TabIndex = 16;
            // 
            // plSua
            // 
            this.plSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plSua.BackgroundImage")));
            this.plSua.Controls.Add(this.cbbSMa);
            this.plSua.Controls.Add(this.label5);
            this.plSua.Controls.Add(this.label4);
            this.plSua.Controls.Add(this.cbbChon);
            this.plSua.Controls.Add(this.btOkSua);
            this.plSua.Controls.Add(this.txtNd);
            this.plSua.Controls.Add(this.label6);
            this.plSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plSua.Location = new System.Drawing.Point(232, 12);
            this.plSua.Name = "plSua";
            this.plSua.Size = new System.Drawing.Size(229, 110);
            this.plSua.TabIndex = 17;
            // 
            // cbbSMa
            // 
            this.cbbSMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSMa.FormattingEnabled = true;
            this.cbbSMa.Location = new System.Drawing.Point(89, 2);
            this.cbbSMa.Name = "cbbSMa";
            this.cbbSMa.Size = new System.Drawing.Size(100, 21);
            this.cbbSMa.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nội dung :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Chọn :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbChon
            // 
            this.cbbChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChon.FormattingEnabled = true;
            this.cbbChon.Items.AddRange(new object[] {
            "Tên phòng",
            "Giá",
            "Trạng thái"});
            this.cbbChon.Location = new System.Drawing.Point(89, 31);
            this.cbbChon.Name = "cbbChon";
            this.cbbChon.Size = new System.Drawing.Size(100, 21);
            this.cbbChon.TabIndex = 16;
            // 
            // btOkSua
            // 
            this.btOkSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btOkSua.Location = new System.Drawing.Point(89, 87);
            this.btOkSua.Name = "btOkSua";
            this.btOkSua.Size = new System.Drawing.Size(75, 23);
            this.btOkSua.TabIndex = 15;
            this.btOkSua.Text = "OK";
            this.btOkSua.UseVisualStyleBackColor = false;
            this.btOkSua.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtNd
            // 
            this.txtNd.Location = new System.Drawing.Point(89, 60);
            this.txtNd.Name = "txtNd";
            this.txtNd.Size = new System.Drawing.Size(100, 20);
            this.txtNd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Phòng :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plXoa
            // 
            this.plXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plXoa.BackgroundImage")));
            this.plXoa.Controls.Add(this.cbbXMa);
            this.plXoa.Controls.Add(this.label7);
            this.plXoa.Controls.Add(this.btOKXoa);
            this.plXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plXoa.Location = new System.Drawing.Point(232, 12);
            this.plXoa.Name = "plXoa";
            this.plXoa.Size = new System.Drawing.Size(229, 110);
            this.plXoa.TabIndex = 18;
            // 
            // cbbXMa
            // 
            this.cbbXMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbXMa.FormattingEnabled = true;
            this.cbbXMa.Location = new System.Drawing.Point(93, 58);
            this.cbbXMa.Name = "cbbXMa";
            this.cbbXMa.Size = new System.Drawing.Size(100, 21);
            this.cbbXMa.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã Phòng :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btOKXoa
            // 
            this.btOKXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btOKXoa.Location = new System.Drawing.Point(93, 88);
            this.btOKXoa.Name = "btOKXoa";
            this.btOKXoa.Size = new System.Drawing.Size(75, 23);
            this.btOKXoa.TabIndex = 15;
            this.btOKXoa.Text = "OK";
            this.btOKXoa.UseVisualStyleBackColor = false;
            this.btOKXoa.Click += new System.EventHandler(this.button7_Click);
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 395);
            this.Controls.Add(this.plXoa);
            this.Controls.Add(this.plSua);
            this.Controls.Add(this.plThem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.plThem.ResumeLayout(false);
            this.plThem.PerformLayout();
            this.plSua.ResumeLayout(false);
            this.plSua.PerformLayout();
            this.plXoa.ResumeLayout(false);
            this.plXoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTTen;
        private System.Windows.Forms.TextBox txtTGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOkThem;
        private System.Windows.Forms.Panel plThem;
        private System.Windows.Forms.Panel plSua;
        private System.Windows.Forms.Button btOkSua;
        private System.Windows.Forms.TextBox txtNd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbChon;
        private System.Windows.Forms.Panel plXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOKXoa;
        private System.Windows.Forms.ComboBox cbbSMa;
        private System.Windows.Forms.ComboBox cbbXMa;
    }
}
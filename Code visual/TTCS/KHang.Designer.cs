
namespace TTCS
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plXoa = new System.Windows.Forms.Panel();
            this.cbbXMa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btOKXoa = new System.Windows.Forms.Button();
            this.plSua = new System.Windows.Forms.Panel();
            this.cbbSMa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbChons = new System.Windows.Forms.ComboBox();
            this.btOkSua = new System.Windows.Forms.Button();
            this.txtNds = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.plThem = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btOkThem = new System.Windows.Forms.Button();
            this.txtTCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTTenKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTMaKhach = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plTK = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbTk = new System.Windows.Forms.ComboBox();
            this.btOkTk = new System.Windows.Forms.Button();
            this.txtNDTK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plXoa.SuspendLayout();
            this.plSua.SuspendLayout();
            this.plThem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.plTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 109);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // plXoa
            // 
            this.plXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plXoa.BackgroundImage")));
            this.plXoa.Controls.Add(this.cbbXMa);
            this.plXoa.Controls.Add(this.label7);
            this.plXoa.Controls.Add(this.btOKXoa);
            this.plXoa.Location = new System.Drawing.Point(258, 8);
            this.plXoa.Name = "plXoa";
            this.plXoa.Size = new System.Drawing.Size(229, 137);
            this.plXoa.TabIndex = 26;
            // 
            // cbbXMa
            // 
            this.cbbXMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbXMa.FormattingEnabled = true;
            this.cbbXMa.Items.AddRange(new object[] {
            "Mã Khách",
            "Tên Khách",
            "SDT",
            "Số CMND",
            "Địa Chỉ"});
            this.cbbXMa.Location = new System.Drawing.Point(93, 58);
            this.cbbXMa.Name = "cbbXMa";
            this.cbbXMa.Size = new System.Drawing.Size(100, 21);
            this.cbbXMa.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã Khách :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btOKXoa
            // 
            this.btOKXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btOKXoa.Location = new System.Drawing.Point(93, 87);
            this.btOKXoa.Name = "btOKXoa";
            this.btOKXoa.Size = new System.Drawing.Size(75, 23);
            this.btOKXoa.TabIndex = 15;
            this.btOKXoa.Text = "OK";
            this.btOKXoa.UseVisualStyleBackColor = false;
            this.btOKXoa.Click += new System.EventHandler(this.btOKXoa_Click);
            // 
            // plSua
            // 
            this.plSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plSua.BackgroundImage")));
            this.plSua.Controls.Add(this.cbbSMa);
            this.plSua.Controls.Add(this.label5);
            this.plSua.Controls.Add(this.label4);
            this.plSua.Controls.Add(this.cbbChons);
            this.plSua.Controls.Add(this.btOkSua);
            this.plSua.Controls.Add(this.txtNds);
            this.plSua.Controls.Add(this.label6);
            this.plSua.Location = new System.Drawing.Point(258, 8);
            this.plSua.Name = "plSua";
            this.plSua.Size = new System.Drawing.Size(229, 137);
            this.plSua.TabIndex = 25;
            // 
            // cbbSMa
            // 
            this.cbbSMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSMa.FormattingEnabled = true;
            this.cbbSMa.Items.AddRange(new object[] {
            "Mã Khách",
            "Tên Khách",
            "SDT",
            "Số CMND",
            "Địa Chỉ"});
            this.cbbSMa.Location = new System.Drawing.Point(89, 4);
            this.cbbSMa.Name = "cbbSMa";
            this.cbbSMa.Size = new System.Drawing.Size(100, 21);
            this.cbbSMa.TabIndex = 20;
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
            // cbbChons
            // 
            this.cbbChons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChons.FormattingEnabled = true;
            this.cbbChons.Items.AddRange(new object[] {
            "Tên Khách",
            "SDT",
            "Số CMND",
            "Địa Chỉ"});
            this.cbbChons.Location = new System.Drawing.Point(89, 32);
            this.cbbChons.Name = "cbbChons";
            this.cbbChons.Size = new System.Drawing.Size(100, 21);
            this.cbbChons.TabIndex = 16;
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
            this.btOkSua.Click += new System.EventHandler(this.btOkSua_Click);
            // 
            // txtNds
            // 
            this.txtNds.Location = new System.Drawing.Point(89, 59);
            this.txtNds.Name = "txtNds";
            this.txtNds.Size = new System.Drawing.Size(100, 20);
            this.txtNds.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Khách :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plThem
            // 
            this.plThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plThem.BackgroundImage")));
            this.plThem.Controls.Add(this.label11);
            this.plThem.Controls.Add(this.textBox1);
            this.plThem.Controls.Add(this.label8);
            this.plThem.Controls.Add(this.btOkThem);
            this.plThem.Controls.Add(this.txtTCMND);
            this.plThem.Controls.Add(this.label3);
            this.plThem.Controls.Add(this.txtTSDT);
            this.plThem.Controls.Add(this.label2);
            this.plThem.Controls.Add(this.txtTTenKhach);
            this.plThem.Controls.Add(this.label1);
            this.plThem.Controls.Add(this.txtTMaKhach);
            this.plThem.Location = new System.Drawing.Point(258, 8);
            this.plThem.Name = "plThem";
            this.plThem.Size = new System.Drawing.Size(247, 139);
            this.plThem.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Địa chỉ :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "CMND :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btOkThem
            // 
            this.btOkThem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btOkThem.Location = new System.Drawing.Point(201, 112);
            this.btOkThem.Name = "btOkThem";
            this.btOkThem.Size = new System.Drawing.Size(42, 21);
            this.btOkThem.TabIndex = 15;
            this.btOkThem.Text = "OK";
            this.btOkThem.UseVisualStyleBackColor = false;
            this.btOkThem.Click += new System.EventHandler(this.btOkThem_Click);
            // 
            // txtTCMND
            // 
            this.txtTCMND.Location = new System.Drawing.Point(93, 87);
            this.txtTCMND.Name = "txtTCMND";
            this.txtTCMND.Size = new System.Drawing.Size(100, 20);
            this.txtTCMND.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "SDT :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTSDT
            // 
            this.txtTSDT.Location = new System.Drawing.Point(93, 60);
            this.txtTSDT.Name = "txtTSDT";
            this.txtTSDT.Size = new System.Drawing.Size(100, 20);
            this.txtTSDT.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Khách :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTTenKhach
            // 
            this.txtTTenKhach.Location = new System.Drawing.Point(93, 31);
            this.txtTTenKhach.Name = "txtTTenKhach";
            this.txtTTenKhach.Size = new System.Drawing.Size(100, 20);
            this.txtTTenKhach.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Khách:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTMaKhach
            // 
            this.txtTMaKhach.Location = new System.Drawing.Point(93, 2);
            this.txtTMaKhach.Name = "txtTMaKhach";
            this.txtTMaKhach.Size = new System.Drawing.Size(100, 20);
            this.txtTMaKhach.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(144, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Location = new System.Drawing.Point(144, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(144, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(144, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(11, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 225);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 203);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaK";
            this.Column1.HeaderText = "Mã Khách";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenK";
            this.Column2.HeaderText = "Tên Khách";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "SDT";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CMND";
            this.Column4.HeaderText = "Số CMND";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.Name = "Column5";
            // 
            // plTK
            // 
            this.plTK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plTK.BackgroundImage")));
            this.plTK.Controls.Add(this.label9);
            this.plTK.Controls.Add(this.label10);
            this.plTK.Controls.Add(this.cbbTk);
            this.plTK.Controls.Add(this.btOkTk);
            this.plTK.Controls.Add(this.txtNDTK);
            this.plTK.Location = new System.Drawing.Point(258, 8);
            this.plTK.Name = "plTK";
            this.plTK.Size = new System.Drawing.Size(231, 139);
            this.plTK.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nội dung :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tìm kiếm :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbTk
            // 
            this.cbbTk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTk.FormattingEnabled = true;
            this.cbbTk.Items.AddRange(new object[] {
            "Mã Khách",
            "Tên Khách",
            "SDT",
            "Số CMND",
            "Địa Chỉ"});
            this.cbbTk.Location = new System.Drawing.Point(89, 29);
            this.cbbTk.Name = "cbbTk";
            this.cbbTk.Size = new System.Drawing.Size(100, 21);
            this.cbbTk.TabIndex = 16;
            // 
            // btOkTk
            // 
            this.btOkTk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btOkTk.Location = new System.Drawing.Point(89, 86);
            this.btOkTk.Name = "btOkTk";
            this.btOkTk.Size = new System.Drawing.Size(75, 23);
            this.btOkTk.TabIndex = 15;
            this.btOkTk.Text = "OK";
            this.btOkTk.UseVisualStyleBackColor = false;
            this.btOkTk.Click += new System.EventHandler(this.btOkTk_Click);
            // 
            // txtNDTK
            // 
            this.txtNDTK.Location = new System.Drawing.Point(89, 58);
            this.txtNDTK.Name = "txtNDTK";
            this.txtNDTK.Size = new System.Drawing.Size(100, 20);
            this.txtNDTK.TabIndex = 11;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(528, 385);
            this.Controls.Add(this.plTK);
            this.Controls.Add(this.plXoa);
            this.Controls.Add(this.plSua);
            this.Controls.Add(this.plThem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plXoa.ResumeLayout(false);
            this.plXoa.PerformLayout();
            this.plSua.ResumeLayout(false);
            this.plSua.PerformLayout();
            this.plThem.ResumeLayout(false);
            this.plThem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.plTK.ResumeLayout(false);
            this.plTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOKXoa;
        private System.Windows.Forms.Panel plSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbChons;
        private System.Windows.Forms.Button btOkSua;
        private System.Windows.Forms.TextBox txtNds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel plThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btOkThem;
        private System.Windows.Forms.TextBox txtTCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTTenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTMaKhach;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel plTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbTk;
        private System.Windows.Forms.Button btOkTk;
        private System.Windows.Forms.TextBox txtNDTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbXMa;
        private System.Windows.Forms.ComboBox cbbSMa;
    }
}
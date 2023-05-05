namespace iniProjectSebenarnya
{
    partial class FormRetur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblsd = new System.Windows.Forms.Label();
            this.dtpakir = new System.Windows.Forms.DateTimePicker();
            this.dtpawal = new System.Windows.Forms.DateTimePicker();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtKontak = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomorPembelian = new System.Windows.Forms.TextBox();
            this.txtNomorRetur = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDretur = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHretur = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnKec = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDretur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHretur)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsd
            // 
            this.lblsd.AutoSize = true;
            this.lblsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsd.ForeColor = System.Drawing.Color.White;
            this.lblsd.Location = new System.Drawing.Point(384, 85);
            this.lblsd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(30, 20);
            this.lblsd.TabIndex = 67;
            this.lblsd.Text = "s/d";
            // 
            // dtpakir
            // 
            this.dtpakir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpakir.Location = new System.Drawing.Point(418, 80);
            this.dtpakir.Margin = new System.Windows.Forms.Padding(2);
            this.dtpakir.Name = "dtpakir";
            this.dtpakir.Size = new System.Drawing.Size(107, 29);
            this.dtpakir.TabIndex = 66;
            // 
            // dtpawal
            // 
            this.dtpawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpawal.Location = new System.Drawing.Point(273, 81);
            this.dtpawal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpawal.Name = "dtpawal";
            this.dtpawal.Size = new System.Drawing.Size(107, 29);
            this.dtpawal.TabIndex = 65;
            // 
            // cmbkategori
            // 
            this.cmbkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Items.AddRange(new object[] {
            "Nama",
            "Nomor Retur",
            "Nomor Nota"});
            this.cmbkategori.Location = new System.Drawing.Point(19, 81);
            this.cmbkategori.Margin = new System.Windows.Forms.Padding(2);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(245, 28);
            this.cmbkategori.TabIndex = 64;
            this.cmbkategori.SelectedIndexChanged += new System.EventHandler(this.cmbkategori_SelectedIndexChanged);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.White;
            this.lblNama.Location = new System.Drawing.Point(166, 13);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(104, 37);
            this.lblNama.TabIndex = 63;
            this.lblNama.Text = "Nama";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(155, 484);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(406, 26);
            this.txtAlamat.TabIndex = 60;
            // 
            // txtKontak
            // 
            this.txtKontak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontak.Location = new System.Drawing.Point(155, 451);
            this.txtKontak.Name = "txtKontak";
            this.txtKontak.Size = new System.Drawing.Size(406, 26);
            this.txtKontak.TabIndex = 61;
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(155, 418);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(406, 26);
            this.txtNama.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(87, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Nama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Alamat : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(78, 454);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 57;
            this.label18.Text = "Kontak : ";
            // 
            // txtNomorPembelian
            // 
            this.txtNomorPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomorPembelian.Location = new System.Drawing.Point(155, 352);
            this.txtNomorPembelian.Name = "txtNomorPembelian";
            this.txtNomorPembelian.ReadOnly = true;
            this.txtNomorPembelian.Size = new System.Drawing.Size(406, 26);
            this.txtNomorPembelian.TabIndex = 55;
            // 
            // txtNomorRetur
            // 
            this.txtNomorRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomorRetur.Location = new System.Drawing.Point(155, 319);
            this.txtNomorRetur.Name = "txtNomorRetur";
            this.txtNomorRetur.ReadOnly = true;
            this.txtNomorRetur.Size = new System.Drawing.Size(406, 26);
            this.txtNomorRetur.TabIndex = 56;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(155, 385);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(406, 26);
            this.dtpTanggal.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tanggal :  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Nota Pembelian : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nomor Retur : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Detail : ";
            // 
            // dgvDretur
            // 
            this.dgvDretur.AllowUserToAddRows = false;
            this.dgvDretur.AllowUserToDeleteRows = false;
            this.dgvDretur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDretur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDretur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDretur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDretur.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDretur.Location = new System.Drawing.Point(22, 542);
            this.dgvDretur.Name = "dgvDretur";
            this.dgvDretur.ReadOnly = true;
            this.dgvDretur.RowHeadersWidth = 51;
            this.dgvDretur.Size = new System.Drawing.Size(542, 191);
            this.dgvDretur.TabIndex = 49;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(273, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 29);
            this.txtSearch.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 37);
            this.label11.TabIndex = 45;
            this.label11.Text = "Welcome, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Semua Retur";
            // 
            // dgvHretur
            // 
            this.dgvHretur.AllowUserToAddRows = false;
            this.dgvHretur.AllowUserToDeleteRows = false;
            this.dgvHretur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHretur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHretur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHretur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHretur.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHretur.Location = new System.Drawing.Point(19, 113);
            this.dgvHretur.Name = "dgvHretur";
            this.dgvHretur.ReadOnly = true;
            this.dgvHretur.RowHeadersWidth = 51;
            this.dgvHretur.Size = new System.Drawing.Size(542, 191);
            this.dgvHretur.TabIndex = 42;
            this.dgvHretur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHretur_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnKec);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 47);
            this.panel1.TabIndex = 68;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(53)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::iniProjectSebenarnya.Properties.Resources.search1;
            this.btnSearch.Location = new System.Drawing.Point(521, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 28);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = global::iniProjectSebenarnya.Properties.Resources.fullscreen;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(547, 15);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(18, 18);
            this.btnMax.TabIndex = 10;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnKec
            // 
            this.btnKec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKec.BackgroundImage = global::iniProjectSebenarnya.Properties.Resources.minimize;
            this.btnKec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKec.FlatAppearance.BorderSize = 0;
            this.btnKec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKec.Location = new System.Drawing.Point(547, 15);
            this.btnKec.Name = "btnKec";
            this.btnKec.Size = new System.Drawing.Size(18, 18);
            this.btnKec.TabIndex = 9;
            this.btnKec.UseVisualStyleBackColor = true;
            this.btnKec.Click += new System.EventHandler(this.btnKec_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::iniProjectSebenarnya.Properties.Resources.minus;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(523, 14);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(18, 20);
            this.btnMin.TabIndex = 6;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::iniProjectSebenarnya.Properties.Resources.log_out;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(571, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 20);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(53)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::iniProjectSebenarnya.Properties.Resources.insert_W;
            this.button1.Location = new System.Drawing.Point(22, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 64);
            this.button1.TabIndex = 44;
            this.button1.Text = "Insert ReturRR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dgvHretur);
            this.panel2.Controls.Add(this.dtpawal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpakir);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblsd);
            this.panel2.Controls.Add(this.dgvDretur);
            this.panel2.Controls.Add(this.cmbkategori);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNama);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAlamat);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtKontak);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtNama);
            this.panel2.Controls.Add(this.dtpTanggal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNomorRetur);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNomorPembelian);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 808);
            this.panel2.TabIndex = 69;
            // 
            // FormRetur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(600, 866);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRetur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRetur";
            this.Load += new System.EventHandler(this.FormRetur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDretur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHretur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsd;
        private System.Windows.Forms.DateTimePicker dtpakir;
        private System.Windows.Forms.DateTimePicker dtpawal;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtKontak;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNomorPembelian;
        private System.Windows.Forms.TextBox txtNomorRetur;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDretur;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHretur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnKec;
        private System.Windows.Forms.Panel panel2;
    }
}
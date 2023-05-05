namespace iniProjectSebenarnya
{
    partial class FormPembayaran
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dgvHead = new System.Windows.Forms.DataGridView();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNota = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalHutang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnKec = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBayarSemua = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(7, 51);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(284, 28);
            this.cmbSupplier.TabIndex = 5;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // dgvHead
            // 
            this.dgvHead.AllowUserToAddRows = false;
            this.dgvHead.AllowUserToDeleteRows = false;
            this.dgvHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHead.Location = new System.Drawing.Point(8, 86);
            this.dgvHead.Name = "dgvHead";
            this.dgvHead.ReadOnly = true;
            this.dgvHead.Size = new System.Drawing.Size(725, 215);
            this.dgvHead.TabIndex = 4;
            this.dgvHead.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHead_CellDoubleClick);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(8, 416);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(725, 203);
            this.dgvDetail.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 37);
            this.label11.TabIndex = 16;
            this.label11.Text = "Welcome, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nomor Nota :";
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNota.ForeColor = System.Drawing.Color.White;
            this.lbNota.Location = new System.Drawing.Point(146, 339);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(14, 20);
            this.lbNota.TabIndex = 18;
            this.lbNota.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tanggal Pembelian :";
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTanggal.ForeColor = System.Drawing.Color.White;
            this.lbTanggal.Location = new System.Drawing.Point(424, 307);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(14, 20);
            this.lbTanggal.TabIndex = 20;
            this.lbTanggal.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nama Supplier :";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplier.ForeColor = System.Drawing.Color.White;
            this.lbSupplier.Location = new System.Drawing.Point(146, 368);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(14, 20);
            this.lbSupplier.TabIndex = 22;
            this.lbSupplier.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(365, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(424, 335);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(14, 20);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "-";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total :";
            // 
            // lbTotalHutang
            // 
            this.lbTotalHutang.AutoSize = true;
            this.lbTotalHutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalHutang.ForeColor = System.Drawing.Color.White;
            this.lbTotalHutang.Location = new System.Drawing.Point(397, 46);
            this.lbTotalHutang.Name = "lbTotalHutang";
            this.lbTotalHutang.Size = new System.Drawing.Size(21, 29);
            this.lbTotalHutang.TabIndex = 28;
            this.lbTotalHutang.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID Pembayaran :";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(146, 307);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(14, 20);
            this.lbID.TabIndex = 30;
            this.lbID.Text = "-";
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
            this.panel1.Size = new System.Drawing.Size(770, 47);
            this.panel1.TabIndex = 69;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = global::iniProjectSebenarnya.Properties.Resources.fullscreen;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(716, 14);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(18, 18);
            this.btnMax.TabIndex = 14;
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
            this.btnKec.Location = new System.Drawing.Point(716, 15);
            this.btnKec.Name = "btnKec";
            this.btnKec.Size = new System.Drawing.Size(18, 18);
            this.btnKec.TabIndex = 13;
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
            this.btnMin.Location = new System.Drawing.Point(692, 14);
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
            this.btnClose.Location = new System.Drawing.Point(740, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 20);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBayarSemua
            // 
            this.btnBayarSemua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(53)))));
            this.btnBayarSemua.FlatAppearance.BorderSize = 0;
            this.btnBayarSemua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayarSemua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayarSemua.ForeColor = System.Drawing.Color.White;
            this.btnBayarSemua.Image = global::iniProjectSebenarnya.Properties.Resources._5611562;
            this.btnBayarSemua.Location = new System.Drawing.Point(611, 307);
            this.btnBayarSemua.Name = "btnBayarSemua";
            this.btnBayarSemua.Size = new System.Drawing.Size(122, 48);
            this.btnBayarSemua.TabIndex = 26;
            this.btnBayarSemua.Text = "Bayar Semua";
            this.btnBayarSemua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBayarSemua.UseVisualStyleBackColor = false;
            this.btnBayarSemua.Click += new System.EventHandler(this.btnBayarSemua_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(53)))));
            this.btnBayar.FlatAppearance.BorderSize = 0;
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Image = global::iniProjectSebenarnya.Properties.Resources._4825412;
            this.btnBayar.Location = new System.Drawing.Point(610, 625);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(122, 48);
            this.btnBayar.TabIndex = 25;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dgvHead);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.cmbSupplier);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvDetail);
            this.panel2.Controls.Add(this.lbTotalHutang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbNota);
            this.panel2.Controls.Add(this.btnBayarSemua);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBayar);
            this.panel2.Controls.Add(this.lbTanggal);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbSupplier);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 684);
            this.panel2.TabIndex = 70;
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(770, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPembayaran";
            this.Load += new System.EventHandler(this.FormPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DataGridView dgvHead;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBayarSemua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalHutang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnKec;
        private System.Windows.Forms.Panel panel2;
    }
}
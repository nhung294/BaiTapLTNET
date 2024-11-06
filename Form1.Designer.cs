namespace bt6th11
{
    partial class Form1
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.lblKhachHangTitle = new System.Windows.Forms.Label();
            this.lblDichVuTitle = new System.Windows.Forms.Label();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.lblChonKhachHang = new System.Windows.Forms.Label();
            this.clbDichVu = new System.Windows.Forms.CheckedListBox();
            this.lblChonDichVu = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.btnChinhSuaKhachHang = new System.Windows.Forms.Button();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(13, 56);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(713, 210);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(792, 56);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(579, 210);
            this.dgvDichVu.TabIndex = 1;
            // 
            // lblKhachHangTitle
            // 
            this.lblKhachHangTitle.AutoSize = true;
            this.lblKhachHangTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangTitle.Location = new System.Drawing.Point(179, 21);
            this.lblKhachHangTitle.Name = "lblKhachHangTitle";
            this.lblKhachHangTitle.Size = new System.Drawing.Size(249, 20);
            this.lblKhachHangTitle.TabIndex = 2;
            this.lblKhachHangTitle.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // lblDichVuTitle
            // 
            this.lblDichVuTitle.AutoSize = true;
            this.lblDichVuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVuTitle.Location = new System.Drawing.Point(986, 21);
            this.lblDichVuTitle.Name = "lblDichVuTitle";
            this.lblDichVuTitle.Size = new System.Drawing.Size(202, 20);
            this.lblDichVuTitle.TabIndex = 3;
            this.lblDichVuTitle.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(13, 342);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(280, 24);
            this.cbKhachHang.TabIndex = 4;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
            // 
            // lblChonKhachHang
            // 
            this.lblChonKhachHang.AutoSize = true;
            this.lblChonKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKhachHang.Location = new System.Drawing.Point(62, 294);
            this.lblChonKhachHang.Name = "lblChonKhachHang";
            this.lblChonKhachHang.Size = new System.Drawing.Size(193, 20);
            this.lblChonKhachHang.TabIndex = 5;
            this.lblChonKhachHang.Text = "CHỌN KHÁCH HÀNG";
            // 
            // clbDichVu
            // 
            this.clbDichVu.FormattingEnabled = true;
            this.clbDichVu.Location = new System.Drawing.Point(382, 342);
            this.clbDichVu.Name = "clbDichVu";
            this.clbDichVu.Size = new System.Drawing.Size(344, 174);
            this.clbDichVu.TabIndex = 6;
            this.clbDichVu.SelectedIndexChanged += new System.EventHandler(this.clbDichVu_SelectedIndexChanged);
            // 
            // lblChonDichVu
            // 
            this.lblChonDichVu.AutoSize = true;
            this.lblChonDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonDichVu.Location = new System.Drawing.Point(502, 294);
            this.lblChonDichVu.Name = "lblChonDichVu";
            this.lblChonDichVu.Size = new System.Drawing.Size(146, 20);
            this.lblChonDichVu.TabIndex = 7;
            this.lblChonDichVu.Text = "CHỌN DỊCH VỤ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(868, 360);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(154, 20);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền: 0 VND";
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.Color.Cyan;
            this.btnThemKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemKhachHang.Location = new System.Drawing.Point(48, 559);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(96, 23);
            this.btnThemKhachHang.TabIndex = 9;
            this.btnThemKhachHang.Text = "THÊM KH";
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // btnChinhSuaKhachHang
            // 
            this.btnChinhSuaKhachHang.BackColor = System.Drawing.Color.Cyan;
            this.btnChinhSuaKhachHang.Location = new System.Drawing.Point(203, 559);
            this.btnChinhSuaKhachHang.Name = "btnChinhSuaKhachHang";
            this.btnChinhSuaKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSuaKhachHang.TabIndex = 10;
            this.btnChinhSuaKhachHang.Text = "SỬA KH";
            this.btnChinhSuaKhachHang.UseVisualStyleBackColor = false;
            this.btnChinhSuaKhachHang.Click += new System.EventHandler(this.btnChinhSuaKhachHang_Click);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.BackColor = System.Drawing.Color.Cyan;
            this.btnXoaKhachHang.Location = new System.Drawing.Point(506, 559);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKhachHang.TabIndex = 11;
            this.btnXoaKhachHang.Text = "XÓA KH";
            this.btnXoaKhachHang.UseVisualStyleBackColor = false;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.BackColor = System.Drawing.Color.Cyan;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(353, 559);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnTaoHoaDon.TabIndex = 12;
            this.btnTaoHoaDon.Text = "TẠO HĐ";
            this.btnTaoHoaDon.UseVisualStyleBackColor = false;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 706);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.btnXoaKhachHang);
            this.Controls.Add(this.btnChinhSuaKhachHang);
            this.Controls.Add(this.btnThemKhachHang);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblChonDichVu);
            this.Controls.Add(this.clbDichVu);
            this.Controls.Add(this.lblChonKhachHang);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.lblDichVuTitle);
            this.Controls.Add(this.lblKhachHangTitle);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label lblKhachHangTitle;
        private System.Windows.Forms.Label lblDichVuTitle;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label lblChonKhachHang;
        private System.Windows.Forms.CheckedListBox clbDichVu;
        private System.Windows.Forms.Label lblChonDichVu;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Button btnChinhSuaKhachHang;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.Button btnTaoHoaDon;
    }
}


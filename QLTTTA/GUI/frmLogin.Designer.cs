namespace QLTTTA.GUI
{
   partial class frmLogin
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
         this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
         this.rdbNV = new System.Windows.Forms.RadioButton();
         this.rdbGV = new System.Windows.Forms.RadioButton();
         this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
         this.edtMatKhau = new DevExpress.XtraEditors.TextEdit();
         this.edtMail = new DevExpress.XtraEditors.TextEdit();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
         this.groupControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.edtMatKhau.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMail.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // groupControl1
         // 
         this.groupControl1.Controls.Add(this.rdbNV);
         this.groupControl1.Controls.Add(this.rdbGV);
         this.groupControl1.Controls.Add(this.btnDangNhap);
         this.groupControl1.Controls.Add(this.edtMatKhau);
         this.groupControl1.Controls.Add(this.edtMail);
         this.groupControl1.Controls.Add(this.labelControl2);
         this.groupControl1.Controls.Add(this.labelControl1);
         this.groupControl1.Location = new System.Drawing.Point(2, 2);
         this.groupControl1.Name = "groupControl1";
         this.groupControl1.Size = new System.Drawing.Size(338, 224);
         this.groupControl1.TabIndex = 0;
         this.groupControl1.Text = "Thông tin đăng nhập";
         // 
         // rdbNV
         // 
         this.rdbNV.AutoSize = true;
         this.rdbNV.Location = new System.Drawing.Point(190, 135);
         this.rdbNV.Name = "rdbNV";
         this.rdbNV.Size = new System.Drawing.Size(111, 17);
         this.rdbNV.TabIndex = 4;
         this.rdbNV.Text = "Nhân viên quản lý";
         this.rdbNV.UseVisualStyleBackColor = true;
         // 
         // rdbGV
         // 
         this.rdbGV.AutoSize = true;
         this.rdbGV.Checked = true;
         this.rdbGV.Location = new System.Drawing.Point(63, 135);
         this.rdbGV.Name = "rdbGV";
         this.rdbGV.Size = new System.Drawing.Size(75, 17);
         this.rdbGV.TabIndex = 4;
         this.rdbGV.TabStop = true;
         this.rdbGV.Text = "Giảng viên";
         this.rdbGV.UseVisualStyleBackColor = true;
         // 
         // btnDangNhap
         // 
         this.btnDangNhap.Location = new System.Drawing.Point(207, 176);
         this.btnDangNhap.Name = "btnDangNhap";
         this.btnDangNhap.Size = new System.Drawing.Size(95, 23);
         this.btnDangNhap.TabIndex = 3;
         this.btnDangNhap.Text = "Đăng nhập";
         this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
         // 
         // edtMatKhau
         // 
         this.edtMatKhau.Location = new System.Drawing.Point(147, 88);
         this.edtMatKhau.Name = "edtMatKhau";
         this.edtMatKhau.Properties.PasswordChar = '*';
         this.edtMatKhau.Size = new System.Drawing.Size(155, 20);
         this.edtMatKhau.TabIndex = 1;
         // 
         // edtMail
         // 
         this.edtMail.Location = new System.Drawing.Point(147, 44);
         this.edtMail.Name = "edtMail";
         this.edtMail.Size = new System.Drawing.Size(155, 20);
         this.edtMail.TabIndex = 1;
         // 
         // labelControl2
         // 
         this.labelControl2.Location = new System.Drawing.Point(34, 91);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(44, 13);
         this.labelControl2.TabIndex = 0;
         this.labelControl2.Text = "Mật khẩu";
         // 
         // labelControl1
         // 
         this.labelControl1.Location = new System.Drawing.Point(34, 47);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(18, 13);
         this.labelControl1.TabIndex = 0;
         this.labelControl1.Text = "Mail";
         // 
         // frmLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(343, 228);
         this.Controls.Add(this.groupControl1);
         this.Name = "frmLogin";
         this.Text = "Đăng nhập";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
         this.groupControl1.ResumeLayout(false);
         this.groupControl1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.edtMatKhau.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.edtMail.Properties)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraEditors.GroupControl groupControl1;
      private DevExpress.XtraEditors.SimpleButton btnDangNhap;
      private DevExpress.XtraEditors.TextEdit edtMatKhau;
      private DevExpress.XtraEditors.TextEdit edtMail;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.RadioButton rdbNV;
      private System.Windows.Forms.RadioButton rdbGV;
   }
}
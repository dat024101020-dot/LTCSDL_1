namespace LTCSDL_1
{
    partial class frm_BangDiem
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
            this.dgBangdiem = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDiemCSDL = new System.Windows.Forms.TextBox();
            this.txtDiemLT = new System.Windows.Forms.TextBox();
            this.txtDiemCTDL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBangdiem
            // 
            this.dgBangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBangdiem.Location = new System.Drawing.Point(52, 202);
            this.dgBangdiem.Name = "dgBangdiem";
            this.dgBangdiem.Size = new System.Drawing.Size(580, 197);
            this.dgBangdiem.TabIndex = 0;
            this.dgBangdiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBangdiem_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(144, 107);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 31);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(283, 107);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(96, 31);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(427, 107);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 31);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtDiemCSDL
            // 
            this.txtDiemCSDL.Enabled = false;
            this.txtDiemCSDL.Location = new System.Drawing.Point(616, 13);
            this.txtDiemCSDL.Name = "txtDiemCSDL";
            this.txtDiemCSDL.Size = new System.Drawing.Size(182, 20);
            this.txtDiemCSDL.TabIndex = 3;
            // 
            // txtDiemLT
            // 
            this.txtDiemLT.Enabled = false;
            this.txtDiemLT.Location = new System.Drawing.Point(616, 51);
            this.txtDiemLT.Name = "txtDiemLT";
            this.txtDiemLT.Size = new System.Drawing.Size(182, 20);
            this.txtDiemLT.TabIndex = 3;
            // 
            // txtDiemCTDL
            // 
            this.txtDiemCTDL.Enabled = false;
            this.txtDiemCTDL.Location = new System.Drawing.Point(616, 91);
            this.txtDiemCTDL.Name = "txtDiemCTDL";
            this.txtDiemCTDL.Size = new System.Drawing.Size(182, 20);
            this.txtDiemCTDL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DiemCSDL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DiemLT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DiemCTDL";
            // 
            // frm_BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiemCTDL);
            this.Controls.Add(this.txtDiemLT);
            this.Controls.Add(this.txtDiemCSDL);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgBangdiem);
            this.Name = "frm_BangDiem";
            this.Text = "frm_BangDiem";
            this.Load += new System.EventHandler(this.frm_BangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBangdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBangdiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDiemCSDL;
        private System.Windows.Forms.TextBox txtDiemLT;
        private System.Windows.Forms.TextBox txtDiemCTDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
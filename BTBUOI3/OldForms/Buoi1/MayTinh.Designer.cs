namespace DOANCANHAN
{
    partial class MayTinh
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
            txtST1 = new TextBox();
            txtST2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKQ = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtST1
            // 
            txtST1.Location = new Point(117, 56);
            txtST1.Name = "txtST1";
            txtST1.Size = new Size(213, 27);
            txtST1.TabIndex = 0;
            txtST1.TextChanged += txtST1_TextChanged;
            txtST1.KeyPress += txtChiNhapSo_KeyPress;
            // 
            // txtST2
            // 
            txtST2.Location = new Point(117, 101);
            txtST2.Name = "txtST2";
            txtST2.Size = new Size(213, 27);
            txtST2.TabIndex = 1;
            txtST2.TextChanged += txtST2_TextChanged;
            txtST2.KeyPress += txtChiNhapSo_KeyPress;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(36, 152);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(33, 29);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(90, 152);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(33, 29);
            btnTru.TabIndex = 4;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(145, 152);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(33, 29);
            btnNhan.TabIndex = 5;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(198, 152);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(33, 29);
            btnChia.TabIndex = 6;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(259, 152);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(71, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Del";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 8;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Số thứ hai";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(117, 215);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(213, 27);
            txtKQ.TabIndex = 10;
            txtKQ.TextChanged += txtKQ_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 218);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 11;
            label3.Text = "Kết quả";
            // 
            // MayTinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 265);
            Controls.Add(label3);
            Controls.Add(txtKQ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtST2);
            Controls.Add(txtST1);
            Name = "MayTinh";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtST1;
        private TextBox txtST2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Label label1;
        private Label label2;
        private TextBox txtKQ;
        private Label label3;
    }
}
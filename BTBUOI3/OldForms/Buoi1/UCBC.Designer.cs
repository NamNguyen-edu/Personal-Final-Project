namespace DOANCANHAN
{
    partial class UCBC
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
            txtA = new TextBox();
            txtB = new TextBox();
            rdoUSCLN = new RadioButton();
            rdoBSCNN = new RadioButton();
            txtKetQua = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            btnBoQua = new Button();
            btnTim = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(88, 26);
            txtA.Name = "txtA";
            txtA.Size = new Size(214, 27);
            txtA.TabIndex = 0;
            txtA.KeyPress += txtKtra_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(88, 71);
            txtB.Name = "txtB";
            txtB.Size = new Size(214, 27);
            txtB.TabIndex = 1;
            txtB.KeyPress += txtKtra_KeyPress;
            // 
            // rdoUSCLN
            // 
            rdoUSCLN.AutoSize = true;
            rdoUSCLN.Location = new Point(18, 37);
            rdoUSCLN.Name = "rdoUSCLN";
            rdoUSCLN.Size = new Size(75, 24);
            rdoUSCLN.TabIndex = 2;
            rdoUSCLN.TabStop = true;
            rdoUSCLN.Text = "USCLN";
            rdoUSCLN.UseVisualStyleBackColor = true;
            // 
            // rdoBSCNN
            // 
            rdoBSCNN.AutoSize = true;
            rdoBSCNN.Location = new Point(18, 67);
            rdoBSCNN.Name = "rdoBSCNN";
            rdoBSCNN.Size = new Size(78, 24);
            rdoBSCNN.TabIndex = 3;
            rdoBSCNN.TabStop = true;
            rdoBSCNN.Text = "BSCNN";
            rdoBSCNN.UseVisualStyleBackColor = true;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(88, 26);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(331, 27);
            txtKetQua.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 8;
            label1.Text = "A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 9;
            label2.Text = "B:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(txtB);
            groupBox1.Location = new Point(44, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 110);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoUSCLN);
            groupBox2.Controls.Add(rdoBSCNN);
            groupBox2.Location = new Point(369, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(147, 110);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnBoQua);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtKetQua);
            groupBox3.Location = new Point(44, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(472, 125);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(325, 80);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(208, 80);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 29);
            btnBoQua.TabIndex = 12;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(88, 80);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 11;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // UCBC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 280);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "UCBC";
            Text = "UCBC";
            Load += UCBC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private RadioButton rdoUSCLN;
        private RadioButton rdoBSCNN;
        private TextBox txtKetQua;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Button btnThoat;
        private Button btnBoQua;
        private Button btnTim;
    }
}
namespace DOANCANHAN
{
    partial class CheckHienThi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer 

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHienThi = new Button();
            txtNoiDung = new TextBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(280, 239);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(125, 29);
            btnHienThi.TabIndex = 0;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(280, 167);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(295, 27);
            txtNoiDung.TabIndex = 1;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(450, 239);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(btnThoat);
            Controls.Add(txtNoiDung);
            Controls.Add(btnHienThi);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnHienThi;
        private TextBox txtNoiDung;
        private Button btnThoat;
    }
}

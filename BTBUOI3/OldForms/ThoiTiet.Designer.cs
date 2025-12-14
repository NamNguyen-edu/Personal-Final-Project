namespace TDashMiniStore.OldForms
{
    partial class ThoiTiet
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
            label1 = new Label();
            cbCity = new ComboBox();
            btnUpdate = new Button();
            picIcon = new PictureBox();
            label3 = new Label();
            txtLon = new TextBox();
            txtLat = new TextBox();
            label2 = new Label();
            lbl1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTemp = new TextBox();
            txtWind = new TextBox();
            txtTime = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn thành phố";
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(29, 75);
            cbCity.Margin = new Padding(3, 4, 3, 4);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(183, 28);
            cbCity.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(125, 465);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(205, 43);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật dữ liệu";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.White;
            picIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picIcon.Enabled = false;
            picIcon.ImageLocation = "";
            picIcon.Location = new Point(322, 67);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(169, 169);
            picIcon.TabIndex = 12;
            picIcon.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 245);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 17;
            label3.Text = "Kết quả";
            // 
            // txtLon
            // 
            txtLon.Location = new Point(109, 191);
            txtLon.Name = "txtLon";
            txtLon.Size = new Size(125, 27);
            txtLon.TabIndex = 16;
            // 
            // txtLat
            // 
            txtLat.Location = new Point(109, 137);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(125, 27);
            txtLat.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 195);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 14;
            label2.Text = "Vĩ độ";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(29, 137);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(60, 20);
            lbl1.TabIndex = 13;
            lbl1.Text = "Kinh độ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 305);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 18;
            label4.Text = "Nhiệt độ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 360);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 19;
            label5.Text = "Tốc độ gió";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 409);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 20;
            label6.Text = "Thời gian";
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(125, 295);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(125, 27);
            txtTemp.TabIndex = 21;
            // 
            // txtWind
            // 
            txtWind.Location = new Point(125, 349);
            txtWind.Name = "txtWind";
            txtWind.Size = new Size(125, 27);
            txtWind.TabIndex = 22;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(125, 399);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(366, 27);
            txtTime.TabIndex = 23;
            // 
            // ThoiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = tdash_app.Properties.Resources._3d_render_summer_landscape_with_sand_sea_blue_sky;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(538, 600);
            Controls.Add(txtTime);
            Controls.Add(txtWind);
            Controls.Add(txtTemp);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLon);
            Controls.Add(txtLat);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Controls.Add(picIcon);
            Controls.Add(btnUpdate);
            Controls.Add(cbCity);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ThoiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thời tiết";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbCity;
        private Button btnUpdate;
        private PictureBox picIcon;
        private Label label3;
        private TextBox txtLon;
        private TextBox txtLat;
        private Label label2;
        private Label lbl1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTemp;
        private TextBox txtWind;
        private TextBox txtTime;
    }
}
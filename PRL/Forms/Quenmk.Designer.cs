namespace PRL.Forms
{
    partial class Quenmk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quenmk));
            button1 = new Button();
            btnOTP = new Button();
            btnXacNhan = new Button();
            txtOTP = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(431, 400);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(194, 60);
            button1.TabIndex = 16;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnOTP
            // 
            btnOTP.AutoSize = true;
            btnOTP.BackColor = Color.Aqua;
            btnOTP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOTP.Location = new Point(505, 252);
            btnOTP.Margin = new Padding(4, 4, 4, 4);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(118, 51);
            btnOTP.TabIndex = 15;
            btnOTP.Text = "OTP";
            btnOTP.UseVisualStyleBackColor = false;
            btnOTP.Click += btnOTP_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Lime;
            btnXacNhan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(228, 400);
            btnXacNhan.Margin = new Padding(4, 4, 4, 4);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(194, 60);
            btnXacNhan.TabIndex = 14;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtOTP
            // 
            txtOTP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtOTP.Location = new Point(228, 255);
            txtOTP.Margin = new Padding(4, 4, 4, 4);
            txtOTP.Name = "txtOTP";
            txtOTP.PlaceholderText = "OTP";
            txtOTP.Size = new Size(269, 44);
            txtOTP.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(228, 180);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(396, 44);
            txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(532, 96);
            label1.TabIndex = 11;
            label1.Text = "Quên mật khẩu";
            // 
            // Quenmk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(852, 504);
            Controls.Add(button1);
            Controls.Add(btnOTP);
            Controls.Add(btnXacNhan);
            Controls.Add(txtOTP);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Quenmk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnOTP;
        private Button btnXacNhan;
        private TextBox txtOTP;
        private TextBox txtEmail;
        private Label label1;
    }
}
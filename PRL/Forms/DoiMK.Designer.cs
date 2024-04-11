namespace PRL.Forms
{
    partial class DoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMK));
            btnChnage = new Button();
            newpass = new TextBox();
            oldPass = new TextBox();
            label1 = new Label();
            nhaplaiPaxx = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnChnage
            // 
            btnChnage.AutoSize = true;
            btnChnage.BackColor = Color.Red;
            btnChnage.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChnage.ForeColor = Color.White;
            btnChnage.Location = new Point(182, 320);
            btnChnage.Name = "btnChnage";
            btnChnage.Size = new Size(176, 48);
            btnChnage.TabIndex = 14;
            btnChnage.Text = "Đổi mật khẩu";
            btnChnage.UseVisualStyleBackColor = false;
            btnChnage.Click += btnChnage_Click;
            // 
            // newpass
            // 
            newpass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            newpass.Location = new Point(182, 204);
            newpass.Name = "newpass";
            newpass.PlaceholderText = "Mật khẩu mới";
            newpass.Size = new Size(318, 38);
            newpass.TabIndex = 13;
            // 
            // oldPass
            // 
            oldPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            oldPass.Location = new Point(182, 144);
            oldPass.Name = "oldPass";
            oldPass.PlaceholderText = "Mật khẩu cũ";
            oldPass.Size = new Size(318, 38);
            oldPass.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 37);
            label1.Name = "label1";
            label1.Size = new Size(391, 81);
            label1.TabIndex = 11;
            label1.Text = "Đổi mật khẩu";
            // 
            // nhaplaiPaxx
            // 
            nhaplaiPaxx.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nhaplaiPaxx.Location = new Point(182, 266);
            nhaplaiPaxx.Name = "nhaplaiPaxx";
            nhaplaiPaxx.PlaceholderText = "Nhập lại mật khẩu mới";
            nhaplaiPaxx.Size = new Size(318, 38);
            nhaplaiPaxx.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(364, 320);
            button2.Name = "button2";
            button2.Size = new Size(136, 48);
            button2.TabIndex = 18;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DoiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 403);
            Controls.Add(button2);
            Controls.Add(nhaplaiPaxx);
            Controls.Add(btnChnage);
            Controls.Add(newpass);
            Controls.Add(oldPass);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoiMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnChnage;
        private TextBox newpass;
        private TextBox oldPass;
        private Label label1;
        private TextBox nhaplaiPaxx;
        private Button button2;
    }
}
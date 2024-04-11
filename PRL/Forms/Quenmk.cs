using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PRL.Forms
{
    public partial class Quenmk : Form
    {
        Random random = new Random();
        int otp;
        NguoidungRepos _repos = new NguoidungRepos();
        public Quenmk()
        {
            InitializeComponent();
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        private void btnOTP_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text))
            {
                var a = _repos.GetAll().FirstOrDefault(x => x.Email == txtEmail.Text);
                if (a != null)
                {
                    otp = random.Next(100000, 999999);
                    var fromAddress = new MailAddress("gianghtph44220@fpt.edu.vn");
                    var toAddress = new MailAddress(txtEmail.Text);
                    const string frompass = "csbdofyhunncsvcx";
                    const string subject = "OTP Code";
                    string body = $"Nhập mã OTP {otp} để xác thực đăng nhập bằng Email.";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, frompass),
                        Timeout = 200000
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Mã OTP của bạn đã được gửi qua email! Vui kiểm tra email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email của bạn không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email của bạn không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text != "")
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                int length = 8;
                string newpass = new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
                var fromAddress = new MailAddress("gianghtph44220@fpt.edu.vn");
                var toAddress = new MailAddress(txtEmail.Text);
                const string frompass = "csbdofyhunncsvcx";
                const string subject = "OTP Code";
                string body = $"Mật khẩu mới của bạn là : {newpass}";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                _repos.ForgetPass(txtEmail.Text, newpass);
                MessageBox.Show("Mật khẩu mới của bạn đã được gửi qua email! Vui kiểm tra email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã OTP!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

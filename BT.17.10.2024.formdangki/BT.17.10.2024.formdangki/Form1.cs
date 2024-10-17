using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BT._17._10._2024.formdangki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
        }

        // Hàm kiểm tra định dạng Email với Regex
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Regular Expression cho email hợp lệ
            return Regex.IsMatch(email, emailPattern);
        }

        // Hàm kiểm tra tính hợp lệ của Password với Regex
        private bool IsValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$"; // Regular Expression cho mật khẩu hợp lệ
            return Regex.IsMatch(password, passwordPattern);
        }

        // Sự kiện khi nhấn nút "Đăng ký"
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;

            // Kiểm tra tính hợp lệ của email và password
            if (IsValidEmail(email) && IsValidPassword(password))
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không hợp lệ! " +
                    "Email phải đúng định dạng, mật khẩu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.",
                    "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

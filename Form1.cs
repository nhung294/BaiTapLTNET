using System;
using System.Windows.Forms;

namespace _24th10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt con trỏ vào ô nhập tên đăng nhập khi form được tải
            txtUsername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện một hành động nào đó khi nhấp vào label
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Có thể để trống hoặc xử lý sự kiện khi nội dung của txtUsername thay đổi
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Có thể để trống hoặc xử lý sự kiện khi nội dung của txtPassword thay đổi
        }
    }
}

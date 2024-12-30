using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ClientApp
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            Login dn = new Login();
            dn.Show();
            this.Hide();
        }

        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btn_SendCode_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text != txt_confirmPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoResetPassword();
            }
        }

        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://localhost:7038")
        };

        private async void DoResetPassword()
        {
            string email = ForgotPassword.to;
            string password = HashPassword(txt_pass.Text);
            var data = new Dictionary<string, object>
            {
                { "email", email },
                { "password", password }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync("api/ForgotPW/ResetPassword", content);
            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (keyValuePairs.ContainsKey("loi") && keyValuePairs["loi"] != null)
                {
                    MessageBox.Show(keyValuePairs["loi"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (keyValuePairs.ContainsKey("iduser") && keyValuePairs["iduser"] != null)
                {
                    string iduser = keyValuePairs["iduser"].ToString();
                    if (!string.IsNullOrEmpty(iduser))
                    {
                        MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}

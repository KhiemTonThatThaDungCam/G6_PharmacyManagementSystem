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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;

namespace ClientApp
{
    public partial class ForgotPassword : Form
    {
        string randomCode;

        public static string to;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SendCode_Click(object sender, EventArgs e)
        {
            DoGetOTP();
        }

        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://localhost:7038")
        };

        private async void DoGetOTP()
        {
            string email = txt_email.Text;
            var data = new Dictionary<string, object>
            {
                { "email", email }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync("api/ForgotPW/GetOTP", content);
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
                if (keyValuePairs.ContainsKey("otp") && keyValuePairs["otp"] != null)
                {
                    string otp = keyValuePairs["otp"].ToString();
                    if (!string.IsNullOrEmpty(otp))
                    {
                        MessageBox.Show("Code successfully send, please check your email", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lb_enterCode.Visible = true;
                        txt_enterCode.Visible = true;
                        btn_verify.Visible = true;

                        randomCode = otp;
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void forgotPassword_Load(object sender, EventArgs e)
        {
            lb_enterCode.Visible = false;
            txt_enterCode.Visible = false;
            btn_verify.Visible = false;
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (randomCode == (txt_enterCode.Text).ToString())
            {
                to = txt_email.Text;
                ResetPassword rePass = new ResetPassword();
                this.Hide();
                rePass.Show();
            }
            else
            {
                MessageBox.Show("Wrong code !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

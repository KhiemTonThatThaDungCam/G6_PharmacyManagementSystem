using Microsoft.Win32;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = checkBox_ShowPass.Checked ? '\0' : '●';
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register dk = new Register();
            dk.Show();
            this.Hide();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoLogin();
                /*using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();

                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass AND status = 'Active' ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txt_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            DataRow row = table.Rows[0];
                            string role = row["role"].ToString();

                            if (role == "Admin")
                            {
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                            }
                            else if (role == "Cashier")
                            {
                                cashierMainForm cashierForm = new cashierMainForm();
                                cashierForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password or you need Admin' s approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }*/
            }
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

        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://localhost:7038")
        };

        private async void DoLogin()
        {
            string username = txt_username.Text;
            string password = HashPassword(txt_password.Text);
            var data = new Dictionary<string, object>
            {
                { "username", username },
                { "password", password }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync("api/Login", content);
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
                    string id = keyValuePairs["iduser"].ToString();
                    string role = keyValuePairs["role"].ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        DialogResult result = MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            /*if (role == "Admin")
                            {
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                            }
                            else if (role == "Cashier")
                            {
                                cashierMainForm cashierForm = new cashierMainForm();
                                cashierForm.Show();
                            }*/
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void linkLabel_forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*forgotPassword fgPass = new forgotPassword();
            fgPass.Show();

            this.Hide();*/
        }
    }
}

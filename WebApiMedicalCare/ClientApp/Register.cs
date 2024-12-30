using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using Azure.Storage.Blobs;

namespace ClientApp
{
    public partial class Register : Form
    {
        public Register()
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

        private void checkBox_showconfirm_CheckedChanged(object sender, EventArgs e)
        {
            txt_confirmPass.PasswordChar = checkBox_showconfirm.Checked ? '\0' : '●';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login dn = new Login();
            dn.Show();
            this.Hide();
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

        private void btn_SingUp_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_confirmPass.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.Text.Length < 8)
            {
                MessageBox.Show("Invalid password, at least 8 chacacters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.Text != txt_confirmPass.Text)
            {
                MessageBox.Show("Confirm password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoRegister();
                /*using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();

                    string checkUsernQuery = "SELECT * FROM users WHERE username = @usern";

                    using (SqlCommand checkUsern = new SqlCommand(checkUsernQuery, connection))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", txt_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string temUsern = txt_username.Text.Substring(0, 1).ToUpper() + txt_username.Text.Substring(1);
                            MessageBox.Show(temUsern + " is existing already!!!.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txt_password.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password, at least 8 chacacters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txt_password.Text != txt_confirmPass.Text)
                        {
                            MessageBox.Show("Confirm password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_register, email)" +
                                "VALUES(@username, @pass, @role, @status, @date, @email)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connection))
                            {
                                cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txt_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Cashier");
                                cmd.Parameters.AddWithValue("@status", "Approval");

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim());

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }*/
            }
        }

        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://localhost:7038")
        };

        private async void DoRegister()
        {
            
            string username = txt_username.Text;
            string email = txt_email.Text;
            string password = HashPassword(txt_password.Text);
            string role = "Cashier";
            string status = "Approval";
            DateTime today = DateTime.Today;
            var data = new Dictionary<string, object>
            {
                { "username", username },
                { "email", email },
                { "password", password },
                { "role", role },
                { "status", status },
                { "dateregister", today.ToString("yyyy-MM-dd") }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync("api/Users/CreateUser", content);
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
                    if (!string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ClientApp.Class;

using System.Security.Cryptography;

namespace ClientApp
{
    public partial class AdminAddUsers : Form
    {
        public AdminAddUsers()
        {
            InitializeComponent();
            displayAddUsers();
        }

        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://localhost:7038")
        };

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsers();
        }

        public async void displayAddUsers()
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Users/GetUsers");
            var res = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var errorResponse = JsonConvert.DeserializeObject<JObject>(res);
                if (errorResponse.ContainsKey("loi") && errorResponse["loi"] != null)
                {
                    MessageBox.Show(errorResponse["loi"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                var listData = JsonConvert.DeserializeObject<List<AdminAddUserData>>(res);
                dataGridView_userData.DataSource = listData;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Username.Text) ||
                string.IsNullOrWhiteSpace(txt_Password.Text) ||
                comboBox_role.SelectedIndex == -1 ||
                comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                DoAddUser();
            }
            /*using (SqlConnection connect = new SqlConnection(conectionString))
            {
                try
                {
                    connect.Open();

                    // Kiểm tra xem username đã tồn tại chưa
                    string checkUsername = "SELECT COUNT(*) FROM users WHERE username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", txt_Username.Text.Trim());
                        int count = (int)checkUsern.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username is already existing!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Thêm dữ liệu mới vào bảng
                    string insertData = "INSERT INTO users (username, password, role, status, date_register) " +
                                        "VALUES (@usern, @pass, @role, @status, @date)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", txt_Username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txt_Password.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", comboBox_role.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@status", comboBox_status.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        cmd.ExecuteNonQuery();
                        clearFieds();

                        MessageBox.Show("Added user successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

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

        private async void DoAddUser()
        {
            string username = txt_Username.Text;
            string email = txt_Email.Text;
            string password = HashPassword(txt_Password.Text);
            string role = comboBox_role.SelectedItem.ToString();
            string status = comboBox_status.SelectedItem.ToString();
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
                        MessageBox.Show("Added user successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFieds();
                        displayAddUsers();
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void clearFieds()
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Email.Text = "";
            comboBox_role.SelectedIndex = -1;
            comboBox_status.SelectedIndex = -1;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFieds();
        }


        private int getID = 0;
        private void dataGridView_userData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_userData.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                txt_Username.Text = row.Cells[1].Value.ToString();
                txt_Email.Text = row.Cells[2].Value.ToString();
                txt_Password.Text = row.Cells[3].Value.ToString();
                comboBox_role.SelectedItem = row.Cells[4].Value.ToString();
                comboBox_status.SelectedItem = row.Cells[5].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text == "" || txt_Email.Text == ""
                || comboBox_role.SelectedIndex == -1 || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update user with ID: " + getID + "?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoUpdateUser();
                }
            }
            displayAddUsers();
        }

        private async void DoUpdateUser()
        {
            string username = txt_Username.Text;
            string email = txt_Username.Text;
            string password = txt_Password.Text;
            string role = comboBox_role.SelectedItem.ToString();
            string status = comboBox_status.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            var data = new Dictionary<string, object>
            {
                { "iduser", getID },
                { "username", username },
                { "email", email },
                { "password", password },
                { "role", role },
                { "status", status },
                { "dateregister", today.ToString("yyyy-MM-dd") }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PutAsync($"api/Users/UpdateUser/{getID}", content);
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
                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFieds();
                        displayAddUsers();
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text == "" || txt_Email.Text == ""
               || comboBox_role.SelectedIndex == -1 || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to DELETE user with ID: " + getID + "?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoDeleteUser();
                }
            }
            displayAddUsers();
        }

        private async void DoDeleteUser()
        {
            var data = new Dictionary<string, object>
            {
                { "iduser", getID }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.DeleteAsync($"api/Users/DeleteUser/{getID}");
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
                if (keyValuePairs.ContainsKey("message") && keyValuePairs["message"] != null)
                {
                    string message = keyValuePairs["message"].ToString();
                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFieds();
                        displayAddUsers();
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

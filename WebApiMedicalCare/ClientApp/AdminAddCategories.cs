using ClientApp.Class;
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

namespace ClientApp
{
    public partial class AdminAddCategories : Form
    {
        public AdminAddCategories()
        {
            InitializeComponent();

            displayCategoriesData();
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
            displayCategoriesData();
        }

        public async void displayCategoriesData()
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Categories/GetCategories");
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
                var listData = JsonConvert.DeserializeObject<List<AdminAddCategoryData>>(res);
                dataGridView_CategoryData.DataSource = listData;
            }
        }

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            if (txt_Category.Text == "" || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoAddCategory();
                
            }
        }

        private async void DoAddCategory()
        {
            string category = txt_Category.Text;
            string status = comboBox_status.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            var data = new Dictionary<string, object>
            {
                { "category", category },
                { "status", status },
                { "dateinsert", today.ToString("yyyy-MM-dd") }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync("api/Categories/CreateCategory", content);
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
                if (keyValuePairs.ContainsKey("idcategory") && keyValuePairs["idcategory"] != null)
                {
                    string id = keyValuePairs["idcategory"].ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Added category successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        displayCategoriesData();
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void clearFields()
        {
            txt_Category.Text = "";
            comboBox_status.SelectedIndex = -1;
        }

        private void btn_clear_Category_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView_CategoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_CategoryData.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                txt_Category.Text = row.Cells[1].Value.ToString();
                comboBox_status.SelectedItem = row.Cells[2].Value.ToString();
            }
        }

        private void btn_update_Category_Click(object sender, EventArgs e)
        {
            if (txt_Category.Text == "" || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update category with ID: " + getID + "?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoUpdateCategory();
                }
            }

        }

        private async void DoUpdateCategory()
        {
            string category = txt_Category.Text;
            string status = comboBox_status.SelectedItem.ToString();
            DateTime today = DateTime.Now;
            var data = new Dictionary<string, object>
            {
                { "idcategory", getID },
                { "category", category },
                { "status", status },
                { "datesinsert", today.ToString("yyyy-MM-dd") }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PutAsync($"api/Categories/UpdateCategory/{getID}", content);
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
                if (keyValuePairs.ContainsKey("idcategory") && keyValuePairs["idcategory"] != null)
                {
                    string id = keyValuePairs["idcategory"].ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Updated category successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        displayCategoriesData();
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_delete_Category_Click(object sender, EventArgs e)
        {
            if (txt_Category.Text == "" || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete category with ID: " + getID + "?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoDeleteCategory();
                }
            }
            
        }

        private async void DoDeleteCategory()
        {
            var data = new Dictionary<string, object>
            {
                { "idcategory", getID }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.DeleteAsync($"api/Categories/DeleteCategory/{getID}");
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
                        clearFields();
                        displayCategoriesData();
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

using ClientApp.Class;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;

namespace ClientApp
{
    public partial class AdminAddProducts : Form
    {
        public AdminAddProducts()
        {
            InitializeComponent();
            displayCategory();

            displayProducts();
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
            displayCategory();

            displayProducts();
        }

        public async void displayProducts()
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Products/GetProducts");
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
                var listDataProduct = JsonConvert.DeserializeObject<List<AdminAddProductData>>(res);
                dataGridView_products.DataSource = listDataProduct;
            }
        }

        public async void displayCategory()
        {
            comboBox_Category.Items.Clear();
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Categories/GetCategoriesActive");
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
                List<AdminAddCategoryData> categoriesactive = JsonConvert.DeserializeObject<List<AdminAddCategoryData>>(res);

                foreach (var category in categoriesactive)
                {
                    comboBox_Category.Items.Add(category.Category);
                }
            }
        }


        private void btn_import_Click(object sender, EventArgs e)
        {
            if (pictureBox_product.Enabled == true)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.png";
                ofd.Title = "Select File";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = ofd.FileName;
                    string FileExtension = Path.GetExtension(FilePath).ToLower();
                    if (FileExtension == ".jpg" || FileExtension == ".png")
                    {
                        if (pictureBox_product.Image != null)
                        {
                            pictureBox_product.Image.Dispose();
                            pictureBox_product.Image = null;
                        }
                        pictureBox_product.Image = Image.FromFile(FilePath);
                    }

                    else
                    {
                        MessageBox.Show("Please select a valid file (.jpg, .png).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public string ConvertImageToBase64(string imagePath)
        {
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageBytes);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_productID.Text == "" || txt_productID.Text == "" || comboBox_Category.SelectedIndex == -1
                || txt_price.Text == "" || txt_stock.Text == "" || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoAddProduct();
            }
        }

        private async void DoAddProduct()
        {
            string proid = txt_productID.Text;
            string proname = txt_ProductName.Text;
            string category = comboBox_Category.SelectedItem.ToString();
            float price = float.Parse(txt_price.Text);
            int stock = int.Parse(txt_stock.Text);
            string image = ConvertImageToBase64(FilePath);
            string status = comboBox_status.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            var data = new Dictionary<string, object>
            {
                { "proid", proid },
                { "proname", proname },
                { "category", category },
                { "price", price },
                { "stock", stock },
                { "image", image },
                { "status",status },
                { "dateinsert", today.ToString("yyyy-MM-dd") }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync("api/Products/CreateProduct", content);
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
                if (keyValuePairs.ContainsKey("idpro") && keyValuePairs["idpro"] != null)
                {
                    string id = keyValuePairs["idpro"].ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Added product successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        displayProducts();
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
            txt_productID.Text = "";
            txt_ProductName.Text = "";
            comboBox_Category.SelectedIndex = -1;
            txt_price.Text = "";
            txt_stock.Text = "";
            comboBox_status.SelectedIndex = -1;
            pictureBox_product.Image = null;
        }

        private int getID = 0;
        private void dataGridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_products.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                txt_productID.Text = row.Cells[1].Value.ToString();
                txt_ProductName.Text = row.Cells[2].Value.ToString();
                comboBox_Category.SelectedItem = row.Cells[3].Value.ToString();
                txt_price.Text = row.Cells[4].Value.ToString();
                txt_stock.Text = row.Cells[5].Value.ToString();

                comboBox_status.SelectedItem = row.Cells[7].Value.ToString();

                string base64 = row.Cells[6].Value.ToString();

                ImageBase64 = "";
                ImageBase64 = base64;

                byte[] imageBytes = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {

                    Image image = Image.FromStream(ms);
                    pictureBox_product.Image = image;
                }


            }
        }

        private string FilePath;
        private string ImageBase64;

        private string GetImageAsBase64(string filePath, string imagebase64)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                byte[] imageBytes = File.ReadAllBytes(filePath);
                return Convert.ToBase64String(imageBytes);
            }
            else
            {
                return imagebase64;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_productID.Text == "" || txt_productID.Text == "" || comboBox_Category.SelectedIndex == -1
                || txt_price.Text == "" || txt_stock.Text == "" || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoUpdateProduct();
            }
        }

        private async void DoUpdateProduct()
        {
            string proid = txt_productID.Text;
            string proname = txt_ProductName.Text;
            string category = comboBox_Category.SelectedItem.ToString();
            float price = float.Parse(txt_price.Text);
            int stock = int.Parse(txt_stock.Text);
            string image = GetImageAsBase64(FilePath, ImageBase64);
            string status = comboBox_status.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            var data = new Dictionary<string, object>
            {
                { "idpro", getID },
                { "proid", proid },
                { "proname", proname },
                { "category", category },
                { "price", price },
                { "stock", stock },
                { "image", image },
                { "status",status },
                { "dateinsert", today.ToString("yyyy-MM-dd") }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PutAsync($"api/Products/UpdateProduct/{getID}", content);
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
                if (keyValuePairs.ContainsKey("idpro") && keyValuePairs["idpro"] != null)
                {
                    string id = keyValuePairs["idpro"].ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Updated product successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        displayProducts();
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
            if (txt_productID.Text == "" || txt_productID.Text == "" || comboBox_Category.SelectedIndex == -1
               || txt_price.Text == "" || txt_stock.Text == "" || comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoDeleteProduct();
                /*using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    if (MessageBox.Show("Are you sure want to DELETE product with ID: " + getID + "?",
                        "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string deleteData = "DELETE FROM products WHERE id = @id";


                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Deleted products successfully!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }*/
            }
        }

        private async void DoDeleteProduct()
        {
            var data = new Dictionary<string, object>
            {
                { "idpro", getID }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.DeleteAsync($"api/Products/DeleteProduct/{getID}");
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
                        displayProducts();
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

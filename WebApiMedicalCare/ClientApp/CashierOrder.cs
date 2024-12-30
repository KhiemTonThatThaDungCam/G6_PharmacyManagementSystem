using ClientApp.Class;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClientApp
{
    public partial class CashierOrder : Form
    {
        public CashierOrder()
        {
            InitializeComponent();

            displayCategories();

            displayAvailableProduct();

            //displayAllOrders();

            //displayTotal();
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
            displayCategories();

            displayAvailableProduct();

            displayAllOrders();
            displayTotal();
        }

        public async void displayAvailableProduct()
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Products/GetProductsActive");
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
                dataGridView_Available_products.DataSource = listDataProduct;
            }
        }


        public async void displayAllOrders()
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Orders/GetOrder");
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
                var listDataCashier = JsonConvert.DeserializeObject<List<CashierOrder>>(res);
                dataGridView_All_Oders.DataSource = listDataCashier;
            }
        }

        public async void displayCategories()
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

        private async void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_order_prodName.Text = "";
            comboBox_ProducstID.SelectedIndex = -1;

            comboBox_ProducstID.Items.Clear();


            lb_oders_regPrice.Text = "";
            numericUpDown_quantity.Value = 0;


            string selectedValue = comboBox_Category.SelectedItem as string;
            if (selectedValue != null)
            {

                using HttpResponseMessage response = await httpClient.GetAsync($"api/Categories/GetCategoriesActive/{selectedValue}");
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
                    List<AdminAddProductData> productsactive = JsonConvert.DeserializeObject<List<AdminAddProductData>>(res);

                    foreach (var product in productsactive)
                    {
                        comboBox_ProducstID.Items.Add(product.Proid);
                    }
                }
            }

            /*if (selectedValue != null)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string selectData = $"SELECT * FROM products WHERE category = @category AND status = 'Active'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string value = reader["pro_id"].ToString();

                                comboBox_ProducstID.Items.Add(value);
                            }
                        }
                    }
                }
            }*/
        }

        private async void comboBox_ProducstID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox_ProducstID.SelectedItem as string;

            if (selectValue != null)
            {
                using HttpResponseMessage response = await httpClient.GetAsync($"api/Products/GetProName/{selectValue}");
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
                        string proname = keyValuePairs["proname"].ToString();
                        string price = keyValuePairs["price"].ToString();
                        lb_order_prodName.Text = proname;
                        lb_oders_regPrice.Text = price;
                    }
                }
                /*using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE pro_id = @proID AND status = 'Active' ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@proID", selectValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string prodName = reader["pro_name"].ToString();
                                string prodPrice = reader["price"].ToString();

                                lb_order_prodName.Text = prodName;
                                lb_oders_regPrice.Text = prodPrice;
                            }
                        }
                    }
                }*/
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            if (comboBox_Category.SelectedIndex == -1 || comboBox_ProducstID.SelectedIndex == -1
                || numericUpDown_quantity.Value == 0 || lb_order_prodName.Text == "" || lb_oders_regPrice.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoAddOrder();
                /*using (SqlConnection connect = new SqlConnection(connecti))
                {
                    connect.Open();

                    string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, regular_price, quantity, status, date_oder) " +
                        "VALUES(@cid, @pID, @prodName, @cat, @regPrice, @qty, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cid", generateID());
                        cmd.Parameters.AddWithValue("@pID", comboBox_ProducstID.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@prodName", lb_order_prodName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", comboBox_Category.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@regPrice", lb_oders_regPrice.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", numericUpDown_quantity.Value);
                        cmd.Parameters.AddWithValue("@status", "Pending");

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }*/
            }
            displayAllOrders();
            displayTotal();
        }

        private async void DoAddOrder()
        {
            getgenerateID();

            string proid = comboBox_ProducstID.SelectedItem.ToString();
            string proname = lb_order_prodName.Text.Trim();
            string category = comboBox_Category.SelectedItem.ToString();
            string regularprice = lb_oders_regPrice.Text.Trim();
            int quantity = Convert.ToInt32(numericUpDown_quantity.Value);
            string status = "Pending";
            DateTime today = DateTime.Today;
            var data = new Dictionary<string, object>
            {
                { "customerid", generateID },
                { "proid", proid },
                { "proname", proname },
                { "category", category },
                { "regularprice", regularprice },
                { "quantity", quantity },
                { "status", status },
                { "dateorder", today.ToString("yyyy-MM-dd") }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync("api/Orders/CreateOders", content);
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
                        displayAllOrders();
                        displayTotal();
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private int generateID = 0;
        public async void getgenerateID()
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Transactions/GenerateID");
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
                if (keyValuePairs.ContainsKey("id") && keyValuePairs["id"] != null)
                {
                    generateID = Int32.Parse(keyValuePairs["id"].ToString());
                }
            }
        }



        public void displayTotal()
        {
            lb_price.Text = "$" + totalPrice.ToString() + ".00";
        }

        private float totalPrice = 0;

        public async void getTotal()
        {
            getgenerateID();
            using HttpResponseMessage response = await httpClient.GetAsync($"api/Orders/GetToTalPrice/{generateID}");
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
                if (keyValuePairs.ContainsKey("totalPrice") && keyValuePairs["totalPrice"] != null)
                {
                    totalPrice = Int32.Parse(keyValuePairs["totalPrice"].ToString());
                }
            }

            /*using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT regular_price AS price, quantity AS qty FROM orders WHERE customer_id = " + generateID();

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("price")) && !reader.IsDBNull(reader.GetOrdinal("qty")))
                            {
                                float price;
                                int qty;

                                if (float.TryParse(reader["price"].ToString(), out price)
                                    && int.TryParse(reader["qty"].ToString(), out qty))
                                {
                                    totalPrice += price * qty;
                                }
                            }
                        }
                    }
                }
            }*/
        }

        public void clearFields()
        {
            comboBox_Category.SelectedIndex = -1;
            comboBox_ProducstID.SelectedIndex = -1;
            numericUpDown_quantity.Value = 0;
            lb_order_prodName.Text = "-----";
            lb_oders_regPrice.Text = "$0.00";
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void txt_Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    getTotal();
                    float getAmount = Convert.ToSingle(txt_Amount.Text);
                    float getChange = (getAmount - totalPrice );

                    if (getChange <= -1)
                    {
                        txt_Amount.Text = "";
                        lb_change_price.Text = "$0.00";
                    }
                    else
                    {
                        lb_change_price.Text = "$" + getChange.ToString() + ".00";
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Amount.Text = "";
                    lb_change_price.Text = "$0.00";
                }
            }
        }

        private void dataGridView_All_Oders_Click(object sender, EventArgs e)
        {

        }

        private int getOrderID = 0;
        private void dataGridView_All_Oders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_All_Oders.Rows[e.RowIndex];
                getOrderID = (int)row.Cells[0].Value;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (getOrderID != 0)
            {
                DoDeleteProduct();
                /*if (MessageBox.Show("Are you sure you want to Delete ID: " + getOrderID + "?", "Comfirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM orders WHERE id = " + getOrderID;

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Remove successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }*/
            }
            else
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayAllOrders();
            displayTotal();
        }

        private async void DoDeleteProduct()
        {
            var data = new Dictionary<string, object>
            {
                { "idpro", getOrderID }
            };
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.DeleteAsync($"api/Orders/DeleteOrder/{getOrderID}");
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
                        displayAllOrders();
                        displayTotal();
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi chứa ID người dùng không hợp lệ hoặc bị thiếu.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (txt_Amount.Text == "" || dataGridView_All_Oders.Rows.Count < 0)
            {
                MessageBox.Show("You have not ordered, cannot pay!!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*if (MessageBox.Show("Are you sure for paying ?", "Comfirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string insertData = "INSERT INTO transactions (customers_id, total_price, status, date_trans) " +
                            "VALUES(@cid, @totalP, @status, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cid", generateID);
                            cmd.Parameters.AddWithValue("@totalP", getTotal());
                            cmd.Parameters.AddWithValue("@status", "Completed");

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                        }

                        string updateData = "UPDATE orders SET status = 'Completed' WHERE customer_id = " + generateID();  //-1

                        using (SqlCommand updateD = new SqlCommand(updateData, connect))
                        {
                            updateD.ExecuteNonQuery();
                        }

                        MessageBox.Show("Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }*/
            }
            displayTotal();
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float totalPrices = totalPrice;

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;


            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;


            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Pharmacy System";

            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);

            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (dataGridView_All_Oders.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "ID", "CID", "ProdID", "ProdName", "Category", "Qty", "RegPrice" };

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }

            count++;

            float rSpace = e.MarginBounds.Bottom - y;
            while (rowIndex < dataGridView_All_Oders.Rows.Count)
            {
                DataGridViewRow row = dataGridView_All_Oders.Rows[rowIndex];

                for (int i = 0; i < dataGridView_All_Oders.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }

                count++;
                rowIndex++;
                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                int labelMargin = (int)Math.Min(rSpace, 200);

                DateTime today = DateTime.Now;

                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-----------------------------", labelFont).Width;

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Total Price: \t$" + totalPrice + "\nAmount: \t$"
                    + lb_amount.Text + "\n\t\t--------------\nChange: \t$"
                    + lb_change_price.Text, labelFont, Brushes.Black, labelX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();
                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right
                    - e.Graphics.MeasureString("-----------------------------", labelFont).Width, y);





            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }
    }
}

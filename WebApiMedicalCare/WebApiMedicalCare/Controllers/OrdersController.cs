using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApiMedicalCare.Models_Categories;
using WebApiMedicalCare.Models_Categoties;
using WebApiMedicalCare.Models_Orders;
using WebApiMedicalCare.Models_Products;
using WebApiMedicalCare.Models_Users;

namespace WebApiMedicalCare.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OrdersController : ControllerBase
    {
        private readonly string connectionString;
        public OrdersController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> CreateOrder(AddOrder addorder)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"INSERT INTO orders 
                            (customer_id, prod_id, prod_name, category, regular_price, quantity, status, date_oder) 
                            VALUES (@customer_id, @prod_id, @prod_name, @category, @regular_price, @quantity, @status, @date_oder)";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", addorder.customerid);
                        cmd.Parameters.AddWithValue("@prod_id", addorder.proid);
                        cmd.Parameters.AddWithValue("@prod_name", addorder.proname);
                        cmd.Parameters.AddWithValue("@category", addorder.category);
                        cmd.Parameters.AddWithValue("@regular_price", addorder.regularprice);
                        cmd.Parameters.AddWithValue("@quantity", addorder.quantity);
                        cmd.Parameters.AddWithValue("@status", addorder.status);
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date_oder", addorder.dateorder);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }


                var order = new Order();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM orders WHERE customer_id = @customer_id";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", addorder.customerid);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                order.idoder = reader.GetInt32(0);
                                order.customerid = reader.GetInt32(1);
                                order.proid = reader.GetString(2);
                                order.proname = reader.GetString(3);
                                order.category = reader.GetString(4);
                                order.regularprice = (float)reader.GetDouble(5);
                                order.quantity = reader.GetInt32(6);
                                order.status = reader.GetString(7);
                                order.dateorder = reader.GetDateTime(8);
                            }
                        }
                    }
                }
                return Ok(order);
            }
            catch
            {
                var loi = new LoiCategory()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(loi);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOrder()
        {
            List<Order> orders = new List<Order>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM orders";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Order order = new Order()
                                {
                                    idoder = reader.GetInt32(0),
                                    customerid = reader.GetInt32(1),
                                    proid = reader.GetString(2),
                                    proname = reader.GetString(3),
                                    category = reader.GetString(4),
                                    regularprice = (float)reader.GetDouble(5),
                                    quantity = reader.GetInt32(6),
                                    status = reader.GetString(7),
                                    dateorder = reader.GetDateTime(8)
                                };
                                orders.Add(order);
                            }
                        }
                    }
                }
            }
            catch
            {
                LoiProduct Loi = new LoiProduct()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(Loi);
            }
            return Ok(orders);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string deleteSql = @"DELETE FROM orders WHERE id=@id";
                    using (var cmd = new SqlCommand(deleteSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected == 0)
                        {
                            return BadRequest(new LoiUser { loi = "Order not found." });
                        }
                    }
                }

                return Ok(new { message = "Order deleted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiUser { loi = $"Xin lỗi, nhưng chúng ta có ngoại lệ: {ex.Message}" });
            }
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetTotalPriceAsync(int customerId)
        {
            try
            {
                float totalPrice = await GetTotalAsync(customerId);
                return Ok(new { totalPrice });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi trong quá trình xử lý!", error = ex.Message });
            }
        }

        private async Task<float> GetTotalAsync(int customerId)
        {
            float totalPrice = 0;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

                string selectData = "SELECT regular_price AS price, quantity AS qty FROM orders WHERE customer_id = @CustomerId";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId); // Sử dụng tham số để bảo mật

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
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
            }

            return totalPrice;
        }
    }
}
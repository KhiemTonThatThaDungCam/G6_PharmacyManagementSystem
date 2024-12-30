using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Reflection;
using WebApiMedicalCare.Models_Categories;
using WebApiMedicalCare.Models_Products;
using WebApiMedicalCare.Models_Users;
using static System.Net.Mime.MediaTypeNames;

namespace WebApiMedicalCare.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly string connectionString;
        public ProductsController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> CreateProduct(AddProduct addproduct)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string checkSql = @"SELECT COUNT(*) FROM products WHERE pro_id = @proid";
                    using (var checkCmd = new SqlCommand(checkSql, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@proid", addproduct.proid);

                        int usernameExists = (int)await checkCmd.ExecuteScalarAsync();
                        if (usernameExists > 0)
                        {
                            var loiproduct = new LoiProduct()
                            {
                                loi = "This category already exists in the system."
                            };
                            return BadRequest(loiproduct);
                        }
                    }

                    string sql = @"INSERT INTO products 
                            (pro_id, pro_name, category, price, stock, image, status, date_insert) 
                            VALUES (@pro_id, @pro_name, @category, @price, @stock, @image, @status, @date_insert)";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pro_id", addproduct.proid);
                        cmd.Parameters.AddWithValue("@pro_name", addproduct.proname);
                        cmd.Parameters.AddWithValue("@category", addproduct.category);
                        cmd.Parameters.AddWithValue("@price", addproduct.price);
                        cmd.Parameters.AddWithValue("@stock", addproduct.stock);
                        cmd.Parameters.AddWithValue("@image", addproduct.image);
                        cmd.Parameters.AddWithValue("@status", addproduct.status);
                        cmd.Parameters.AddWithValue("@date_insert", addproduct.dateinsert);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }

                var product = new Product();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM products WHERE pro_id = @pro_id";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pro_id", addproduct.proid);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                product.idpro = reader.GetInt32(0);
                                product.proid = reader.GetString(1);
                                product.proname = reader.GetString(2);
                                product.category = reader.GetString(3);
                                product.price = (float)reader.GetDouble(4);
                                product.stock = reader.GetInt32(5);
                                product.image = reader.GetString(6);
                                product.status = reader.GetString(7);
                                product.dateinsert =reader.GetDateTime(8);
                            }
                        }
                    }
                }
                return Ok(product);
            }
            catch
            {
                var loi = new LoiProduct()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(loi);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM products";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Product product = new Product()
                                {
                                    idpro = reader.GetInt32(0),
                                    proid = reader.GetString(1),
                                    proname = reader.GetString(2),
                                    category = reader.GetString(3),
                                    price = (float)reader.GetDouble(4),
                                    stock = reader.GetInt32(5),
                                    image = reader.GetString(6),
                                    status = reader.GetString(7),
                                    dateinsert = reader.GetDateTime(8)
                                };
                                products.Add(product);
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
            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsActive()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM products WHERE status = 'Active'";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Product product = new Product()
                                {
                                    idpro = reader.GetInt32(0),
                                    proid = reader.GetString(1),
                                    proname = reader.GetString(2),
                                    category = reader.GetString(3),
                                    price = (float)reader.GetDouble(4),
                                    stock = reader.GetInt32(5),
                                    image = reader.GetString(6),
                                    status = reader.GetString(7),
                                    dateinsert = reader.GetDateTime(8)
                                };
                                products.Add(product);
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
            return Ok(products);
        }

        [HttpGet("{category}")]
        public async Task<IActionResult> GetProductsActive(string category)
        {
            List<Product> products = new List<Product>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM products WHERE status = 'Active' AND category = @category";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@category", category);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Product product = new Product()
                                {
                                    idpro = reader.GetInt32(0),
                                    proid = reader.GetString(1),
                                    proname = reader.GetString(2),
                                    category = reader.GetString(3),
                                    price = (float)reader.GetDouble(4),
                                    stock = reader.GetInt32(5),
                                    image = reader.GetString(6),
                                    status = reader.GetString(7),
                                    dateinsert = reader.GetDateTime(8)
                                };
                                products.Add(product);
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
            return Ok(products);
        }

        [HttpGet("{Proid}")]
        public async Task<IActionResult> GetProName(string Proid)
        {
            var product = new Product();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM products WHERE status = 'Active' AND pro_id = @pro_id";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pro_id", Proid);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {

                                product.idpro = reader.GetInt32(0);
                                product.proid = reader.GetString(1);
                                product.proname = reader.GetString(2);
                                product.category = reader.GetString(3);
                                product.price = (float)reader.GetDouble(4);
                                product.stock = reader.GetInt32(5);
                                product.image = reader.GetString(6);
                                product.status = reader.GetString(7);
                                product.dateinsert = reader.GetDateTime(8);
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
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            try
            {
                Product currentProduct = new Product();

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string selectSql = @"SELECT * FROM products WHERE id=@id";
                    using (var cmd = new SqlCommand(selectSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                currentProduct.idpro = reader.GetInt32(0);
                                currentProduct.proid = reader.GetString(1);
                                currentProduct.proname = reader.GetString(2);
                                currentProduct.category = reader.GetString(3);
                                currentProduct.price = (float)reader.GetDouble(4);
                                currentProduct.stock = reader.GetInt32(5);
                                currentProduct.image = reader.GetString(6);
                                currentProduct.status = reader.GetString(7);
                                currentProduct.dateinsert = reader.GetDateTime(8);
                            }
                            else
                            {
                                return BadRequest(new LoiUser { loi = "Product does not exist in the system." });
                            }
                        }
                    }
                }

                if (currentProduct.proid != product.proid)
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        string checkUsernameSql = @"SELECT COUNT(*) FROM products WHERE pro_id=@NEW_PROID AND id!=@CURRENT_IDPRO";
                        using (var cmd = new SqlCommand(checkUsernameSql, connection))
                        {
                            cmd.Parameters.AddWithValue("@NEW_PROID", product.proid);
                            cmd.Parameters.AddWithValue("@CURRENT_IDPRO", currentProduct.idpro);

                            int usernameExists = (int)await cmd.ExecuteScalarAsync();
                            if (usernameExists > 0)
                            {
                                return BadRequest(new LoiUser { loi = "This product already exists in the system." });
                            }
                        }
                    }
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string updateSql = @"UPDATE products SET pro_id=@pro_id, pro_name=@pro_name, category=@category, price=@price, stock=@stock, image=@image, status=@status, date_insert=@date_insert WHERE id=@idpro";
                    using (var cmd = new SqlCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pro_id", product.proid);
                        cmd.Parameters.AddWithValue("@pro_name", product.proname);
                        cmd.Parameters.AddWithValue("@category", product.category);
                        cmd.Parameters.AddWithValue("@price", product.price);
                        cmd.Parameters.AddWithValue("@stock", product.stock);
                        cmd.Parameters.AddWithValue("@image", product.image);
                        cmd.Parameters.AddWithValue("@status", product.status);
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date_insert", today);
                        cmd.Parameters.AddWithValue("@idpro", currentProduct.idpro);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }

                Product updatedProduct = new Product();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM prooducts WHERE id=@id";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", product.idpro);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                updatedProduct.idpro = reader.GetInt32(0);
                                updatedProduct.proid = reader.GetString(1);
                                updatedProduct.proname = reader.GetString(2);
                                updatedProduct.category = reader.GetString(3);
                                updatedProduct.price = (float)reader.GetDouble(4);
                                updatedProduct.stock = reader.GetInt32(5);
                                updatedProduct.image = reader.GetString(6);
                                updatedProduct.status = reader.GetString(7);
                                updatedProduct.dateinsert = reader.GetDateTime(8);
                            }
                        }
                    }
                }

                return Ok(updatedProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiUser { loi = $"Xin lỗi, nhưng chúng ta có ngoại lệ: {ex.Message}" });
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string deleteSql = @"DELETE FROM products WHERE id=@id";
                    using (var cmd = new SqlCommand(deleteSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected == 0)
                        {
                            return BadRequest(new LoiUser { loi = "Product not found." });
                        }
                    }
                }

                return Ok(new { message = "Product deleted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiUser { loi = $"Xin lỗi, nhưng chúng ta có ngoại lệ: {ex.Message}" });
            }
        }
    }
}

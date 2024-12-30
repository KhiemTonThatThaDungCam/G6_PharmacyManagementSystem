using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApiMedicalCare.Models_Categories;
using WebApiMedicalCare.Models_Categoties;
using WebApiMedicalCare.Models_Users;

namespace WebApiMedicalCare.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoriesController : ControllerBase
    {
        private readonly string connectionString;
        public CategoriesController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> CreateCategory(AddCategory addcategory)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string checkSql = @"SELECT COUNT(*) FROM categories WHERE category = @category";
                    using (var checkCmd = new SqlCommand(checkSql, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@category", addcategory.category);

                        int usernameExists = (int)await checkCmd.ExecuteScalarAsync();
                        if (usernameExists > 0)
                        {
                            var loiusers = new LoiUser()
                            {
                                loi = "This category already exists in the system."
                            };
                            return BadRequest(loiusers);
                        }
                    }

                    string sql = @"INSERT INTO categories 
                            (category, status, date_insert) 
                            VALUES (@category, @status, @date_insert)";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@category", addcategory.category);
                        cmd.Parameters.AddWithValue("@status", addcategory.status);
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date_insert", addcategory.dateinsert);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }


                var category = new Category();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM categories WHERE category = @category";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@category", addcategory.category);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                category.idcategory = reader.GetInt32(0);
                                category.category = reader.GetString(1);
                                category.status = reader.GetString(2);
                                category.dateinsert = reader.GetDateTime(3);
                            }
                        }
                    }
                }
                return Ok(category);
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
        public async Task<IActionResult> GetCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM categories";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Category category  = new Category()
                                {
                                    idcategory = reader.GetInt32(0),
                                    category = reader.GetString(1),
                                    status = reader.GetString(2),
                                    dateinsert = reader.GetDateTime(3)
                                };
                                categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch
            {
                LoiCategory Loi = new LoiCategory()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(Loi);
            }
            return Ok(categories);
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoriesActive()
        {
            List<Category> categories = new List<Category>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM categories WHERE status = 'Active'";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Category category = new Category()
                                {
                                    idcategory = reader.GetInt32(0),
                                    category = reader.GetString(1),
                                    status = reader.GetString(2),
                                    dateinsert = reader.GetDateTime(3)
                                };
                                categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch
            {
                LoiCategory Loi = new LoiCategory()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(Loi);
            }
            return Ok(categories);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            try
            {
                Category currentCategory = new Category();

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string selectSql = @"SELECT * FROM categories WHERE id=@id";
                    using (var cmd = new SqlCommand(selectSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                currentCategory.idcategory = reader.GetInt32(0);
                                currentCategory.category = reader.GetString(1);
                                currentCategory.status = reader.GetString(2);
                                currentCategory.dateinsert = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                            }
                            else
                            {
                                return BadRequest(new LoiUser { loi = "Category does not exist in the system." });
                            }
                        }
                    }
                }

                if (currentCategory.category != category.category)
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        string checkUsernameSql = @"SELECT COUNT(*) FROM categories WHERE category=@NEW_CATEGORY AND id!=@CURRENT_IDCATEGORY";
                        using (var cmd = new SqlCommand(checkUsernameSql, connection))
                        {
                            cmd.Parameters.AddWithValue("@NEW_CATEGORY", category.category);
                            cmd.Parameters.AddWithValue("@CURRENT_IDCATEGORY", currentCategory.idcategory);

                            int usernameExists = (int)await cmd.ExecuteScalarAsync();
                            if (usernameExists > 0)
                            {
                                return BadRequest(new LoiUser { loi = "This category already exists in the system." });
                            }
                        }
                    }
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string updateSql = @"UPDATE categories SET category=@CATEGORY, status=@STATUS, date_insert=@DATEINSERT WHERE id=@IDCATEGORY";
                    using (var cmd = new SqlCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CATEGORY", category.category);
                        cmd.Parameters.AddWithValue("@STATUS", category.status);

                        DateTime today = DateTime.Today;

                        cmd.Parameters.AddWithValue("@DATEINSERT", today);
                        cmd.Parameters.AddWithValue("@IDCATEGORY", currentCategory.idcategory);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }

                Category updatedCategory = new Category();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM categories WHERE id=@id";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", category.idcategory);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                updatedCategory.idcategory = reader.GetInt32(0);
                                updatedCategory.category = reader.GetString(1);
                                updatedCategory.status = reader.GetString(2);
                                updatedCategory.dateinsert = reader.GetDateTime(3);
                            }
                        }
                    }
                }

                return Ok(updatedCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiUser { loi = $"Xin lỗi, nhưng chúng ta có ngoại lệ: {ex.Message}" });
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string deleteSql = @"DELETE FROM categories WHERE id=@id";
                    using (var cmd = new SqlCommand(deleteSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected == 0)
                        {
                            return BadRequest(new LoiUser { loi = "Category not found." });
                        }
                    }
                }

                return Ok(new { message = "Category deleted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiUser { loi = $"Xin lỗi, nhưng chúng ta có ngoại lệ: {ex.Message}" });
            }
        }
    }
}


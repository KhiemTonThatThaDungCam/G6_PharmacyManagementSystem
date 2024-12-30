using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiMedicalCare.Models_Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace WebApiMedicalCare.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly string connectionString;
        public UsersController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> CreateUser(DKUser dkusers)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string checkSql = @"SELECT COUNT(*) FROM users WHERE username = @USERNAME";
                    using (var checkCmd = new SqlCommand(checkSql, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@USERNAME", dkusers.username);

                        int usernameExists = (int)await checkCmd.ExecuteScalarAsync();
                        if (usernameExists > 0)
                        {
                            var loiusers = new LoiUser()
                            {
                                loi = "Account already registered, please choose another username!"
                            };
                            return BadRequest(loiusers);
                        }
                    }

                    string sql = @"INSERT INTO users 
                            (username, email, password, role, status, date_register) 
                            VALUES (@username, @email, @password, @role, @status, @date_register)";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", dkusers.username);
                        cmd.Parameters.AddWithValue("@email", dkusers.email);
                        cmd.Parameters.AddWithValue("@password", dkusers.password);
                        cmd.Parameters.AddWithValue("@role", dkusers.role);
                        cmd.Parameters.AddWithValue("@status", dkusers.status);
                        cmd.Parameters.AddWithValue("@date_register", dkusers.dateregister);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }

               
                var user = new User();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM users WHERE username = @USERNAME";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@USERNAME", dkusers.username);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                user.iduser = reader.GetInt32(0);
                                user.username = reader.GetString(1);
                                user.email = reader.GetString(2);
                                user.role = reader.GetString(4);
                                user.status = reader.GetString(5);
                                user.dateregister = reader.GetDateTime(6);
                            }
                        }
                    }
                }
                return Ok(user);
            }
            catch
            {
                var loi = new LoiUser()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(loi);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM users";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                User user = new User()
                                {
                                    iduser = reader.GetInt32(0),
                                    username = reader.GetString(1),
                                    email = reader.GetString(2),
                                    password = reader.GetString(3),
                                    role = reader.GetString(4),
                                    status = reader.GetString(5),
                                    dateregister = reader.GetDateTime(6)
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch
            {
                LoiUser Loi = new LoiUser
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(Loi);
            }
            return Ok(users);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User user)
        {
            try
            {
               User currentUser = new User();

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string selectSql = @"SELECT * FROM users WHERE id=@id";
                    using (var cmd = new SqlCommand(selectSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                currentUser.iduser = reader.GetInt32(0);
                                currentUser.username = reader.GetString(1);
                                currentUser.email = reader.GetString(2);
                                currentUser.password = reader.GetString(3);
                                currentUser.role = reader.GetString(4);
                                currentUser.status = reader.GetString(5);
                                currentUser.dateregister = reader.GetDateTime(6);
                            }
                            else
                            {
                                return BadRequest(new LoiUser { loi = "User does not exist." });
                            }
                        }
                    }
                }

                if (currentUser.username != user.username)
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        string checkUsernameSql = @"SELECT COUNT(*) FROM users WHERE username=@NEW_USERNAME AND id != @CURRENT_IDNGUOIDUNG";
                        using (var cmd = new SqlCommand(checkUsernameSql, connection))
                        {
                            cmd.Parameters.AddWithValue("@NEW_USERNAME", user.username);
                            cmd.Parameters.AddWithValue("@CURRENT_IDNGUOIDUNG", currentUser.iduser);

                            int usernameExists = (int)await cmd.ExecuteScalarAsync();
                            if (usernameExists > 0)
                            {
                                return BadRequest(new LoiUser { loi = "Username already exists. Please choose another one." });
                            }
                        }
                    }
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string updateSql = @"UPDATE users SET username=@USERNAME, email=@EMAIL, password=@PASSWORD, role=@ROLE, status=@STATUS, date_register=@DATEREGISTER WHERE id=@IDUSER";
                    using (var cmd = new SqlCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@USERNAME", user.username);
                        cmd.Parameters.AddWithValue("@EMAIL", user.email);
                        cmd.Parameters.AddWithValue("@PASSWORD", user.password);
                        cmd.Parameters.AddWithValue("@ROLE", user.role);
                        cmd.Parameters.AddWithValue("@STATUS", user.status);
                        cmd.Parameters.AddWithValue("@DATEREGISTER", user.dateregister);
                        cmd.Parameters.AddWithValue("@IDUSER", currentUser.iduser);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }

                User updatedUser = new User();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM users WHERE id=@id";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", user.iduser);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                updatedUser.iduser = reader.GetInt32(0);
                                updatedUser.username = reader.GetString(1);
                                updatedUser.email = reader.GetString(2);
                                updatedUser.password = reader.GetString(3);
                                updatedUser.role = reader.GetString(4);
                                updatedUser.status = reader.GetString(5);
                                updatedUser.dateregister = reader.GetDateTime(6);
                            }
                        }
                    }
                }

                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiUser { loi = $"Xin lỗi, nhưng chúng ta có ngoại lệ: {ex.Message}" });
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string deleteSql = @"DELETE FROM users WHERE id=@id";
                    using (var cmd = new SqlCommand(deleteSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected == 0)
                        {
                            return BadRequest(new LoiUser { loi = "User not found." });
                        }
                    }
                }

                return Ok(new { message = "User deleted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiUser { loi = $"Xin lỗi, nhưng chúng ta có ngoại lệ: {ex.Message}" });
            }
        }
    }
}

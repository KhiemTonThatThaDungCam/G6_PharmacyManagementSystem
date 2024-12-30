using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApiMedicalCare.Models_Login;
using WebApiMedicalCare.Models_Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace WebApiMedicalCare.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly string connectionString;
        public LoginController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> Login(Login login)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"
                                SELECT id, username, email, role, status, date_register 
                                FROM users 
                                WHERE username = @USERNAME AND password = @PASSWORD";

                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@USERNAME", login.username);
                        cmd.Parameters.AddWithValue("@PASSWORD", login.password);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                User user = new User
                                {
                                    iduser = reader.GetInt32(0),
                                    username = reader.GetString(1),
                                    email = reader.GetString(2),
                                    role = reader.GetString(3),
                                    status = reader.GetString(4),
                                    dateregister = reader.GetDateTime(5)
                                };

                                return Ok(user);
                            }
                            else
                            {
                                return BadRequest(new LoiLogin
                                {
                                    loi = "Incorrect Username/Password or you need Admin' s approval"
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new LoiLogin
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ! Chi tiết: " + ex.Message
                });
            }
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApiMedicalCare.Models_Users;
using WebApiMedicalCare.Models_OTP;
using System.Net.Mail;
using System.Net;

namespace WebApiMedicalCare.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ForgotPWController : ControllerBase
    {
        private readonly string connectionString;
        public ForgotPWController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> GetOTP(Email email)
        {
            try
            {
                string randomCode;
                string to;
                string from, pass, messagebody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();

                MailMessage message = new MailMessage();
                to = email.email;
                from = "23521081@gm.uit.edu.vn";
                pass = "jyhdihbedugocfaa";

                messagebody = $"Your Reset Code is {randomCode}";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Password Reset Code";

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        await smtp.SendMailAsync(message);
                    }
                    catch (Exception ex)
                    {
                        var loiotp = new LoiOTP()
                        {
                            loi = ex.Message
                        };
                        return BadRequest(loiotp);
                    }
                }

                var otp = new OTP();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync(); 

                    string sql = @"SELECT * FROM users WHERE email = @Email";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.email);

                        using (var reader = await cmd.ExecuteReaderAsync()) 
                        {
                            if (await reader.ReadAsync()) 
                            {
                                otp.otp = randomCode;
                                otp.iduser = reader.GetInt32(0);
                                otp.username = reader.GetString(1);
                                otp.email = reader.GetString(2);
                                otp.role = reader.GetString(4);
                                otp.status = reader.GetString(5);
                                otp.dateregister = reader.GetDateTime(6);
                            }
                            else
                            {
                                var loi = new LoiOTP()
                                {
                                    loi = "Email does not exist in the system"
                                };
                                return BadRequest(loi);
                            }
                        }
                    }
                }
                return Ok(otp);
            }
            catch
            {
                var loi = new LoiOTP()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(loi);
            }
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> ResetPassword(ResetPw resetpw)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateSql = @"UPDATE users SET password = @password WHERE email = @Email";
                    using (var cmd = new SqlCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@password", resetpw.password);
                        cmd.Parameters.AddWithValue("@Email", resetpw.email);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            var loi = new LoiOTP()
                            {
                                loi = "Failed to reset the password. Please try again."
                            };
                            return BadRequest(loi);
                        }
                    }
                }

                var user = new User();
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string sql = @"SELECT * FROM users WHERE email = @Email";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", resetpw.email);

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
                            else
                            {
                                var loi = new LoiOTP()
                                {
                                    loi = "Email does not exist in the system"
                                };
                                return BadRequest(loi);
                            }
                        }
                    }
                }
                return Ok(user);
            }
            catch
            {
                var loi = new LoiOTP()
                {
                    loi = "Xin lỗi, nhưng chúng ta có ngoại lệ!"
                };
                return BadRequest(loi);
            }
        }

    }
}

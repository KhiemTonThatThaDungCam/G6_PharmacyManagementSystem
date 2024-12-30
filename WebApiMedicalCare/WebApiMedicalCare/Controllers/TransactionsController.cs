using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApiMedicalCare.Models_Orders;
using WebApiMedicalCare.Models_Products;

namespace WebApiMedicalCare.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TransactionsController : ControllerBase
    {
        private readonly string connectionString;
        public TransactionsController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:SqlServerDb"] ?? "";
        }

        [HttpGet]
        public async Task<IActionResult> GenerateID()
        {
            try
            {
                int newID = await GenerateTransactionID();
                return Ok(new { id = newID });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi trong quá trình xử lý!", error = ex.Message });
            }
        }

        private async Task<int> GenerateTransactionID()
        {
            int getID = 0;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync(); 

                string selectData = "SELECT MAX(id) as getID FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) 
                    {
                        if (await reader.ReadAsync()) 
                        {
                            if (reader["getID"] != DBNull.Value)
                            {
                                getID = Convert.ToInt32(reader["getID"]);
                            }

                            if (getID == 0)
                            {
                                getID = 1;
                            }
                        }
                    }
                }
            }

            return getID == 0 ? 1 : getID + 1;
        }

    }
}

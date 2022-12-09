using appli_gest_assoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace appli_gest_assoc.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        // Get Account
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=gest_assoc_db; integrated security=true";
        }

        [HttpPost]
        public IActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from login where email='"+acc.Email+"' and password='"+acc.password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Index");
            }
            else
            {
                con.Close();
                return View("ErrorLogin");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

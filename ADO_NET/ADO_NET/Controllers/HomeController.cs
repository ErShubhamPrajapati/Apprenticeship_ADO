using ADO_NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Data;

namespace ADO_NET.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(StudentModel model)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=db_ex1;Integrated Security=True;");
                SqlCommand command = new SqlCommand($"insert into tbl_register values('{model.name}','{model.email}','{model.number}','{model.dob.ToString("yyyy-MM-dd")}','{model.gender}','{model.quali}','{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')", connection);
                connection.Open();
                int res = command.ExecuteNonQuery();
                connection.Close();

                return Content("<script>alert('Data Successfully Added');location.href='/home/index';</script>");
            }
            catch (Exception ex)
            {
                return Content("<script>alert(`Enter Occured: " + ex.Message + "`);location.href='/home/index';</script>");
            }



        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
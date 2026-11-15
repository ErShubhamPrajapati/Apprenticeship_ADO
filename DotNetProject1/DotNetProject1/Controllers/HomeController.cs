using DotNetProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;


namespace DotNetProject1.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=db_ex1;Integrated Security=True;");
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Register()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_signup",connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            ViewBag.data = data;
            return View();
        }
        [HttpPost]
        public ActionResult Register(Empmodel model)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=db_ex1;Integrated Security=True;");

                SqlCommand cmd = new SqlCommand($"insert into tbl_signup values('{model.name}','{model.email}','{model.Postion}','{model.password}','{model.gender}')", con);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
               return Content("<script>alert('Data Successfully Added');location.href='/home/Register';</script>");
            }
            catch (Exception ex)
            {
                return Content("<script>alert(`Enter Occured: " + ex.Message + "`);location.href='/home/Register';</script>");
            }
        }


    }
}
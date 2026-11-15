using ADO_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace ADO_Project2.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=db_ex2;Integrated Security=True;");
        public ActionResult Index()
        {

            SqlCommand cmd = new SqlCommand("sp_selectEmp", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            ViewBag.data = data;
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

        public ActionResult EmpRegistration()
        {
            SqlCommand cmd = new SqlCommand("sp_selectEmp",connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            ViewBag.data = data;
            return View();
        }
        [HttpPost]
        public ActionResult EmpRegistration(EmpModel model)
        {
            SqlCommand cmd = new SqlCommand("sp_AddEmployee",connection);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid",model.empid);
            cmd.Parameters.AddWithValue("@empname",model.empname);
            cmd.Parameters.AddWithValue("@gender", model.gender);
            cmd.Parameters.AddWithValue("@dob", model.dob.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@designation", model.designation);
            cmd.Parameters.AddWithValue("@salary", model.salary);
            connection.Open();
            int res = cmd.ExecuteNonQuery();
            connection.Close();
            return Content("<script>alert('Data Added Successfully');location.href='/Home/EmpRegistration';</script>");


        }
    }
}
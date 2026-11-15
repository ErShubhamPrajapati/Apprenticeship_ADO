using MultiFormManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiFormManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=MultiFormManagementSystemDB;Integrated Security=True;");
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
        public ActionResult StudentRegistration()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectStudentRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ViewBag.dt = dt;
            return View();
        }
        [HttpPost]
        public ActionResult StudentRegistration(StudentRegistrationModel model)
        {
            SqlCommand cmd = new SqlCommand("sp_AddStudentRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentid", model.studentid);
            cmd.Parameters.AddWithValue("@studentname", model.studentname);
            cmd.Parameters.AddWithValue("@studentemail", model.studentemail);
            cmd.Parameters.AddWithValue("@StudentMobileNo", model.studentmobileno);
            cmd.Parameters.AddWithValue("@studentdob", model.studentdob);
            cmd.Parameters.AddWithValue("@studentgender", model.studentgender);
            cmd.Parameters.AddWithValue("@studentaddress", model.studentaddress);
            cmd.Parameters.AddWithValue("@fathername", model.fathername);
            cmd.Parameters.AddWithValue("@studentqualification", model.studentqualification);
            cmd.Parameters.AddWithValue("@studentregistration", model.studentregistration);

            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();

            return Content("<script>alert('Data Added Successfully'); location.href='/home/studentregistration'</script>");
        }

        public ActionResult EmployeeRegistration()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectEmployeeRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ViewBag.dt = dt;
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeRegistration(EmployeeRegistrationModel model)
        {
            SqlCommand cmd = new SqlCommand("sp_AddEmployeeRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeid", model.employeeid);
            cmd.Parameters.AddWithValue("@employeename", model.employeename);
            cmd.Parameters.AddWithValue("@employeeemail", model.employeeemail);
            cmd.Parameters.AddWithValue("@employeemobileno", model.employeemobileno);
            cmd.Parameters.AddWithValue("@employeedepartment", model.employeedepartment);
            cmd.Parameters.AddWithValue("@employeesalary", model.employeesalary);
            cmd.Parameters.AddWithValue("@employeejoining", model.employeejoining);
            cmd.Parameters.AddWithValue("@employeedesignation", model.employeedesignation);
            cmd.Parameters.AddWithValue("@employeegender", model.employeegender);
            cmd.Parameters.AddWithValue("@employeeaddress", model.employeeaddress);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return Content("<script>alert('Data Added Successfully');location.href='/home/EmployeeRegistration'</script>");
        }


        public ActionResult CourseRegistration()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectCourseRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ViewBag.dt = dt;
            return View();
        }
        [HttpPost]

        public ActionResult CourseRegistration(CourseRegistrationModel model)
        {
            SqlCommand cmd = new SqlCommand("sp_AddCourseRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@courseid", model.courseid);
            cmd.Parameters.AddWithValue("@coursename", model.coursename);
            cmd.Parameters.AddWithValue("@courseduration", model.courseduration);
            cmd.Parameters.AddWithValue("@coursefees", model.coursefees);
            cmd.Parameters.AddWithValue("@studentname", model.studentname);
            cmd.Parameters.AddWithValue("@admissiondate", model.admissiondate);
            cmd.Parameters.AddWithValue("@coursecategory", model.coursecategory);
            cmd.Parameters.AddWithValue("@instructorname", model.instructorname);
            cmd.Parameters.AddWithValue("@paymentstatus", model.paymentstatus);
            cmd.Parameters.AddWithValue("@coursemode", model.coursemode);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return Content("<script>alert('Data Added Successfully');location.href='/home/CourseRegistration'</script>");
        }

        public ActionResult ProductRegistration()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectProductRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ViewBag.dt = dt;
            return View();
        }
        [HttpPost]
        public ActionResult ProductRegistration(ProductRegistrationModel model)
        {
            SqlCommand cmd = new SqlCommand("sp_AddProductRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", model.productid);
            cmd.Parameters.AddWithValue("@productname", model.productname);
            cmd.Parameters.AddWithValue("@productcategory", model.productcategory);
            cmd.Parameters.AddWithValue("@productprice", model.productprice);
            cmd.Parameters.AddWithValue("@productquantity", model.productquantity);
            cmd.Parameters.AddWithValue("@productdescription", model.productdescription);
            cmd.Parameters.AddWithValue("@brandname", model.brandname);
            cmd.Parameters.AddWithValue("@ManufacturingDate", model.manufacturingdate);
            cmd.Parameters.AddWithValue("@ExpiryDate", model.expirydate);
            cmd.Parameters.AddWithValue("@productstatus", model.productstatus);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return Content("<script>alert('Data Added Successfully');location.href='/home/ProductRegistration'</script>");
        }


        public ActionResult ContactForm()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectContactRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ViewBag.dt = dt;
            return View();
        }
        [HttpPost]
        public ActionResult ContactForm(ContactFormModel model)
        {
            SqlCommand cmd = new SqlCommand("sp_AddContactRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("contactid", model.contactid);
            cmd.Parameters.AddWithValue("contactname", model.contactname);
            cmd.Parameters.AddWithValue("contactemail", model.contactemail);
            cmd.Parameters.AddWithValue("contactmobileno", model.contactmobileno);
            cmd.Parameters.AddWithValue("contactsubject", model.contactsubject);
            cmd.Parameters.AddWithValue("contactmessage", model.contactmessage);
            cmd.Parameters.AddWithValue("contactcity", model.contactcity);
            cmd.Parameters.AddWithValue("contactstate", model.contactstate);
            cmd.Parameters.AddWithValue("contactdate", model.contactdate);
            cmd.Parameters.AddWithValue("contacttype", model.contacttype);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return Content("<script>alert('Data Added Successfully');location.href='/home/ContactForm'</script>");
        }
    }
}

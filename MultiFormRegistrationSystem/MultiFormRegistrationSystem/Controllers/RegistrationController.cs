using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MultiFormRegistrationSystem.Models;

namespace MultiFormRegistrationSystem.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Student(StudentModel model)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=MultiFormRegistrationDB;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand($"insert into Students values('{model.name}','{model.Email}','{model.mobile}','{model.dob}','{model.gender}','{model.address}')",con);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                return Content("<script>alert('Data Successfully Added');location.href='/Registration/Student';</script>");
            }
            catch (Exception ex) 
            {
                return Content("<script>alert(`Enter Occured: " + ex.Message + "`);location.href='/Registration/Student';</script>");

            }

        }

        public ActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Employee(EmployeeModel model)
        {
            try 
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=MultiFormRegistrationDB;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand($"insert into Employees values('{model.name}','{model.email}','{model.mobile}','{model.department}','{model.salary}','{model.joiningdate}')", con);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                return Content("<script>alert('Data Added Successfully');location.href='/Registration/Employee';</script>");
            }
            catch (Exception ex)
            {
                return Content("<script>alert(`Enter Occured: " + ex.Message + "`);location.href='/Registration/Employee';</script>");

            }


        }

        public ActionResult Course()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Course(CourseModel model)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=MultiFormRegistrationDB;Integrated Security=True;");

                SqlCommand cmd = new SqlCommand($"insert into Courses values('{model.coursename}','{model.courseduration}','{model.coursefees}','{model.studentname}','{model.admissiondate}')", con);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();

                return Content("<script>alert('Course Successfully Added');location.href='/Registration/Course';</script>");
            }
            catch (Exception ex)
            {
                return Content("<script>alert(`Enter Occured: " + ex.Message + "`);location.href='/Registration/Course';</script>");
            }
        }


        public ActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Product(ProductModel model)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=MultiFormRegistrationDB;Integrated Security=True;");

                SqlCommand cmd = new SqlCommand($"insert into Products values('{model.productname}','{model.category}','{model.price}','{model.quantity}','{model.description}')", con);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();

                return Content("<script>alert('Product Successfully Added');location.href='/Registration/Product';</script>");
            }
            catch (Exception ex)
            {
                return Content("<script>alert(`Enter Occured: " + ex.Message + "`);location.href='/Registration/Product';</script>");
            }
        }


        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LA76PSS\\SQLEXPRESS02;Initial Catalog=MultiFormRegistrationDB;Integrated Security=True;");

                SqlCommand cmd = new SqlCommand($"insert into Contacts values('{model.name}','{model.email}','{model.mobile}','{model.subject}','{model.message}')", con);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();

                return Content("<script>alert('Contact Successfully Added');location.href='/Registration/Contact';</script>");
            }
            catch (Exception ex)
            {
                return Content("<script>alert(`Enter Occured: " + ex.Message + "`);location.href='/Registration/Contact';</script>");
            }
        }
    }
}
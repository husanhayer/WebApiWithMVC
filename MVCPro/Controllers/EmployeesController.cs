using MVCPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCPro.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            IEnumerable<mvcEmployee> empList;
            HttpResponseMessage response = ApiVariables.WebApiClient.GetAsync("Employees").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmployee>>().Result;
            return View(empList);
        }
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new mvcEmployee());
            else
            {
                HttpResponseMessage response = ApiVariables.WebApiClient.GetAsync("Employees/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcEmployee>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcEmployee mvcEmployee)
        {
            if (mvcEmployee.EmployeeID == 0)
            {
                HttpResponseMessage response = ApiVariables.WebApiClient.PostAsJsonAsync("Employees", mvcEmployee).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = ApiVariables.WebApiClient.PutAsJsonAsync("Employees/" + mvcEmployee.EmployeeID, mvcEmployee).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = ApiVariables.WebApiClient.DeleteAsync("Employees/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
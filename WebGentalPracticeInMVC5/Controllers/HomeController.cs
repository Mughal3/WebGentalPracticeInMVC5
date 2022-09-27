using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGentalPracticeInMVC5.Models;


namespace WebGentalPracticeInMVC5.Controllers
{
    public class HomeController : Controller
    {
        StudentServices stuServ = new StudentServices();
        // GET: Home

        public ActionResult List()
        {
           
            return View(stuServ.GetDataFromDB());
        }
        public ActionResult Details(int id)
        {
            return View(stuServ.GetStudentByID(id));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel obj)
        {
            stuServ.SetDataInDB(obj);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            stuServ.DeletDataFromDb(id);
            return RedirectToAction("List");
        }
        public ActionResult Edit(int id)
        {            
            return View(stuServ.GetStudentByID(id));
        }
        [HttpPost]
        public ActionResult Edit(int id,StudentModel obj)
        {

            stuServ.EditDataInDB (id,obj);
            return RedirectToAction("List");
        }
      


        
        
        
    }
}
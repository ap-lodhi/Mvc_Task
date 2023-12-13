using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Dal;
using Task_1.interfaces;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class ProjectController : Controller
    {
        RegisterInterface ui = new RegUserClass();
        public IActionResult Index()
        {

            return View();
          
            

        }
     
        public JsonResult registerUser( registerModel objmodel)
        {

            ResponseModel result = new ResponseModel();
            result = ui.adduser(objmodel);
            return Json(result);
        }




        [HttpPost]
        public IActionResult loginUser(registerModel objmodel)
        {

            ResponseModel result = new ResponseModel();
            
            result = ui.loginUser(objmodel);

            if(result.status== true)
            {
                HttpContext.Session.SetString("text", objmodel.name);
               return RedirectToAction("Index", "Dashboard");
            }      
       //     else
        //    {
                TempData["error"] = "invalid credetial";
            //  return Json(result);
            //  }
            return RedirectToAction("Login", "Project");
           
        }

        public IActionResult Login()
        {

         //   HttpContext.Session.SetString("text", "This text is came here by using SESSION");

          //  ViewBag.sess = HttpContext.Session.GetString("text");
            return View();

        } 

        
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Dal;
using Task_1.interfaces;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class DashboardController : Controller
    {
       
        //Student Master 
       
        StudentInterface stu = new StudentClass();
        public IActionResult Index()

        {
            ViewBag.sess = HttpContext.Session.GetString("text");
           
            return View();
        }
       public IActionResult Student()
        {
            ViewBag.sess = HttpContext.Session.GetString("text");
            // var z = res.getRoleDetails();
            return View();
        }
       public JsonResult DeleteStudent(int Id)
        {
            return Json(stu.deleteStuListItem(Id));
        }
        public IActionResult GetStudentList()

        {

            ViewBag.sess = HttpContext.Session.GetString("text");
            List<StudentModel> result = stu.getStuDetails();
            return View(result);
        }
        public IActionResult EditStu(int id)
        {
            var s = stu.editStudentMater(id);
            return View(s);
        }
        public JsonResult addStudent(StudentModel M)
        {

            ResponseModel result = new ResponseModel();

            result = stu.addStudent(M);


            return Json(result);
        }       
        public JsonResult updateStudent(StudentModel M)
        
        {
            return Json(stu.updateStudent(M));
        }





        //Department  master
        DepartmentInterface deps = new DepartmentClass();
        public IActionResult Department()
        {
            ViewBag.sess = HttpContext.Session.GetString("text");
            // var z = res.getRoleDetails();
            return View();
        }
        public JsonResult Depuser(DeparmentModel M)
            {

                ResponseModel result = new ResponseModel();

                result = deps.Depuser(M);


                return Json(result);
            }
        public IActionResult EditDep(int id)
        {
            var d= deps.editDepMaster(id);
            return View(d);
        }
        public JsonResult updateDep(DeparmentModel dep)
        {
            return Json(deps.updateDepart(dep));
        }
        public JsonResult DeleteDepartment(int Id)
        {
            return Json(deps.deleteDepListItem(Id));
        }
        public IActionResult GetDepList()

        {

            ViewBag.sess = HttpContext.Session.GetString("text");
            List<DeparmentModel> result = deps.getDepDetails();
            return View(result);
        }





        //Role master 
        RoleInterface res = new RoleMaster();
        public JsonResult DeleteRole(int Id)
        {
            return Json(res.deleteRoleListItem(Id));
        }
        public IActionResult RoleMaster()
        {
            ViewBag.sess = HttpContext.Session.GetString("text");
            // var z = res.getRoleDetails();
            return View();
        }
        public IActionResult GetRoleList()

        {

            ViewBag.sess = HttpContext.Session.GetString("text");
            List < RoleModel > result = res.getRoleDetails();
            return View(result);
        }
        public JsonResult roleUser(RoleModel M)
        {

            ResponseModel result = new ResponseModel();

            result = res.roleuser(M);
           

            return Json(result);
        }
        public IActionResult editRole(int id)
        {
            var l = res.editRoleMater(id);
            return View(l);
        }
        public JsonResult updateRole(RoleModel objmodel)
        {
            return Json(res.updateRole(objmodel));
        }




        //college Addmission 

        DropDownInterface drop = new DropDown();
    public IActionResult AddCollege()
        {
            var desination = drop.getRoleDesignation();
            ViewBag.roleDes = new SelectList(desination, "Role_id", "Role_designation");
            var branch = drop.getDepBranchName();
            ViewBag.DepBranch = new SelectList(branch, "Branch_id", "Branch_name");
            var stu_Name = drop.getStudentName();
            ViewBag.stuname = new SelectList(stu_Name, "Student_id", "Student_fisrt_Name");
            return View();
        }

        public JsonResult saveAdmission(CollegeModel objmodel)

        {
            ResponseModel result = new ResponseModel();

            result = drop.addadmission(objmodel);

            return Json(result);

        }

        public IActionResult GetCollegeList()

        {

           
            List<getCollegeModel> result = drop.getCollege();
            return View(result);
        }

        public JsonResult DeleteCollege(int Id)
        {
            return Json(drop.deleteClgListItem(Id));
        }

        public IActionResult editCollege(int id)
        {

            var desination = drop.getRoleDesignation();
            ViewBag.roleDes = new SelectList(desination, "Role_id", "Role_designation");
            var branch = drop.getDepBranchName();
            ViewBag.DepBranch = new SelectList(branch, "Branch_id", "Branch_name");
            var stu_Name = drop.getStudentName();
            ViewBag.stuname = new SelectList(stu_Name, "Student_id", "Student_fisrt_Name");
            var l = drop.editCollegeMater(id);
            return View(l);
        }


        public JsonResult updateCollege(CollegeModel M)

        {
            return Json(drop.updateCollege(M));
        }



        public JsonResult GetCollegefilterList(DateTime? fromDate, DateTime? toDate)
        {
            List<getCollegeModel> result = drop.getCollegeList(fromDate, toDate);
            return Json(result);
        }



    }
}

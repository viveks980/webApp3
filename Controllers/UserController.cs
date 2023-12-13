using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Dal;
using WebApplication3.Interface;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        UserInterface ui = new UserClass();
        signUpInterface ut = new signUpClass();
        AdmissionInterface Add = new AdmissionClass();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Role_master()
        {
            return View();
        }

        public IActionResult Department_master()
        {
            return View();
        }
        public IActionResult Student_master()
        {
            return View();
        }
        public JsonResult saveRole(RoleModel objmodel)

        {
            ResponseModel result = new ResponseModel();

            result = ui.adduser(objmodel);

            return Json(result);

        }
        public JsonResult saveDepartment(DepartmentModel objmodel)

        {
            ResponseModel result = new ResponseModel();

            result = ut.adddepartment(objmodel);

            return Json(result);

        }
        public JsonResult saveStudent(StudentModel objmodel)

        {
            ResponseModel result = new ResponseModel();

            result = ut.addstudent(objmodel);

            return Json(result);

        }
       
         public IActionResult GetDepList()

        {
            List<DepartmentModel> result = ut.getDepDetails();
            return View(result);
        }

        public IActionResult GetStudentList()

        {
            List<StudentModel> result = ut.getStudentDetails();
            return View(result);
        }

        public IActionResult GetRoleList()

        {
            List<RoleModel> result = ut.getRoleDetails();
            return View(result);
        }

        public JsonResult deleteRole(int Role_id)
        {
            return Json(ut.deleteRole(Role_id));
        }
        public JsonResult deleteDepartment(int branchId)
        {
            return Json(ut.deleteDepartment(branchId));
        }
        public JsonResult deleteStudent(int studentId)
        {
            return Json(ut.deleteStudent(studentId));
        }

        public ActionResult editStudent(int studentId)
        {
            return View(ut.editStudent(studentId));
            
        }
        public ActionResult editRole(int Role_id)
        {

            return View(ut.editRole(Role_id));

        }
        public ActionResult editDepartment(int branchId)
        {
            return View(ut.editDepartment(branchId));

        }
        public JsonResult updateDepartment(DepartmentModel objmodel)
        {
            return Json(ut.updateDepartment(objmodel));
        }
        public JsonResult updateStudent(StudentModel objmodel)
        {
            return Json(ut.updateStudent(objmodel));
        }
        public JsonResult updateRole(RoleModel objmodel)
        {
            return Json(ut.updateRole(objmodel));
        }
      
            public IActionResult AddCollege()

        {

            var desination = Add.getRoleDesignation();

            ViewBag.roleDes = new SelectList(desination, "Role_id", "Role_designation");

            var branch = Add.getDepBranchName();

            ViewBag.DepBranch = new SelectList(branch, "branchId", "branchName");

            var stu_Name = Add.getStudentName();

            ViewBag.stuname = new SelectList(stu_Name, "studentId", "firstName");

            return View();

        }
        public JsonResult saveAdmission(College objmodel)

        {
            ResponseModel result = new ResponseModel();

            result = Add.addadmission(objmodel);

            return Json(result);

        }
        public IActionResult GetAddmissionList()

        {
            List<getCollege> result = Add.getAdmissionDetails();
            return View(result);
        }

        public ActionResult editCollege(int clg_id)
        {
            var desination = Add.getRoleDesignation();

            ViewBag.roleDes = new SelectList(desination, "Role_id", "Role_designation");

            var branch = Add.getDepBranchName();

            ViewBag.DepBranch = new SelectList(branch, "branchId", "branchName");

            var stu_Name = Add.getStudentName();

            ViewBag.stuname = new SelectList(stu_Name, "studentId", "firstName");

            return View(Add.editCollege(clg_id));

        }

        public JsonResult deleteCollege(int clg_id)
        {
            return Json(Add.deleteCollege(clg_id));
        }
        public JsonResult updateCollege(College objmodel)
        {
             return Json(Add.updateCollege(objmodel));
        }




    }
}

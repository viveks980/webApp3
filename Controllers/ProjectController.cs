using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Dal;
using WebApplication3.Interface;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProjectController : Controller
    {
        signUpInterface ui = new signUpClass();
        public IActionResult Index()
        {
            return View(); 
        }
      
        public JsonResult registerUser(RegisterModel objmodel)

        {
            ResponseModel result = new ResponseModel();

            result = ui.adduser(objmodel);

            return Json(result);

        }
        [HttpPost]
        public IActionResult loginUser(RegisterModel objmodel)
           
        {
            ResponseModel result = new ResponseModel();

            result = ui.loginUser(objmodel);
            if (result.status == true)
            {
                return RedirectToAction("GetRoleList", "User");
            }
            TempData["errormg"] = "invalid user & password";
            return View();

            //return Json(result);
            

        }
        public IActionResult display()
        {
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MS_Web_App.Models;

namespace MS_Web_App.Controllers
{
    public class EmployeeController : Controller
    {
		        public IActionResult Index()
				{
					var Emps = new EmployeeDatabase();
					 return View(Emps);
				}
	}
}
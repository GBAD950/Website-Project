using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OCOS_System.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        public ViewResult UserPage()
        {
            return View();
        }
    }
}
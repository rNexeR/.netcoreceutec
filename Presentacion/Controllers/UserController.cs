using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicativa.User.Queries;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;

namespace Presentacion.Controllers
{
    public class UserController : Controller
    {
        private ListUsers listUsers;

        public UserController()
        {
            listUsers = new ListUsers();
        }

        public IActionResult Index()
        {
            var createdUsers = listUsers.Execute();

            var userModels = createdUsers.Select(user => new UserInfoModel
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email
            }).ToList(); ;

            return View(userModels);
        }

        public IActionResult Create()
        {
            var model = new UserInfoModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(UserInfoModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarexFinal.Models;
using StarexFinal.ViewModels;
using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using StarexFinalProject.ViewModel;

namespace StarexFinalProject.Controllers
{
    public class AccountController : Controller

    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<AppUsers> userManager;
        private readonly SignInManager<AppUsers> signInManager;
        private readonly StarexDbContext dbContext;
        public AccountController(UserManager<AppUsers> userManager,
            SignInManager<AppUsers> signInManager,
              IUserRepository userRepository,
            StarexDbContext _dbcontext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = _dbcontext;
            this._userRepository = userRepository;
        }

        public IActionResult Register()
        {
            ViewBag.Warehouse = dbContext.Warehouse.Select(
                c => new SelectListItem()
                {
                    Text = c.Adress,
                    Value = c.Id.ToString()
                }).ToList();
            return View();
        }
        [HttpPost]
        public  IActionResult Register(UserViewModel userViewModel)
        {
            //ViewBag.Warehouses = dbContext.Warehouse.Select(
            //    c => new SelectListItem()
            //    {
            //        Text = c.Adress,
            //        Value = c.Id.ToString()
            //    }).ToList();
            //return View();
            if (ModelState.IsValid)
            {
                var result = _userRepository.Create(userViewModel);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
    }
}

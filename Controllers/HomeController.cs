using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
        int hour=DateTime.Now.Hour;
        var sayHi=hour>12 ? "Have a good day" : "Good morning";

        // ViewBag.selamlama=sayHi;
        // ViewBag.Username="Ata";
        ViewBag.Usercount=Repository.Users.Where(m=>m.WillAttend==true).Count();

        ViewData["selamlama"]=hour>12 ? "Have a good day" : "Good morning";
        ViewData["Username"]="Ata";
        var MeetingInfo= new MeetingInfo(){
            Id=1,
            Location= "Istanbul Future Campus",
            Date= new DateTime(2024,01,20,20,0,0),
            NumberOfPeople=100
        };

            return View(MeetingInfo);
        }
    }
}
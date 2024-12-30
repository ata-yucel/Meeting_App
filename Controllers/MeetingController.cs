using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {


        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo user)
        {
            if(ModelState.IsValid){
                
            Repository.CreateUser(user);
            ViewBag.UserCount=Repository.Users.Where(i=>i.WillAttend==true).Count();
            return View("Thanks",user);
            }
            return View(user);
        }

        public IActionResult List()
        {
            var user = Repository.Users;
            return View(user);
        }
        public IActionResult Details(int id){
            return View(Repository.GetById(id));
        }
    }
}
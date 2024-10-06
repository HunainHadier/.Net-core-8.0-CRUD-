using crupapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace crupapp.Controllers
{
    public class HomeController : Controller
    {

        private static MyDbContext _db;
        public HomeController(MyDbContext myDb)
        {
            _db = myDb;

        }
       public IActionResult Index()
        {
            var AllData = _db.Users.ToList();
            return View(AllData);

    
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserReg us)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(us);
                _db.SaveChanges();
                TempData["successmsg"] = "Record has been submited";
                TempData.Keep();
                return RedirectToAction("Index");
            }

            
            return View();
        }

        public IActionResult Edit(int ID)
        {
            var student = _db.Users.Find(ID);

            return View(student);

        }

        
        [HttpPost]
        public IActionResult Edit(UserReg student)
        {
            if (ModelState.IsValid)
            {


                _db.Users.Update(student);
                _db.SaveChanges();
                TempData["updatedmsg"] = "Record has been Updated";
                TempData.Keep();
                return RedirectToAction("Index");



            }
            return View(student);

        }


        public IActionResult Delete(int ID)
        {

            var dele = _db.Users.Find(ID);
            return View(dele);

        }

        [HttpPost]
        public IActionResult Delete(UserReg dele)
        {
            _db.Users.Remove(dele);
            _db.SaveChanges();
            TempData["deletemsg"] = "Record has been Updated";
            TempData.Keep();
            return RedirectToAction("Index");


        }

    }


}






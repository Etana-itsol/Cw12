using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw12.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw12.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            var db = new s18725Context();
            var doctors = db.Doctor.ToList();

           // string html = "<ul>";
           // foreach (var d in doctors)
            //{
            //    html += "<li>" + d.LastName + "</li>";
           // }
           // html += "</ul>";
            return View(doctors);
        }
        public IActionResult GetDetails(int id) 
        {
            var db = new s18725Context();
            var doctor = db.Doctor.FirstOrDefault(d => d.IdDoctor == id);

            return View(doctor);
        }
        public IActionResult Create()
        {
             return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor d)
        {
            var db = new s18725Context();
            d.Email = "aa@";
            db.Doctor.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
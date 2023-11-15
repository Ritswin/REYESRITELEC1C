using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReyesRITELEC1C.Data;
using ReyesRITELEC1C.Models;
//using ReyesRITELEC1C.Services;


namespace ReyesRITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbContext;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Instructors);
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditInstructor(int Id)
        {
            var instructor = _dbContext.Instructors.FirstOrDefault(ins => ins.Id == Id);

            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();
        }

        public IActionResult EditInstructor(Instructor instructor)
        {
            var ins = _dbContext.Instructors.FirstOrDefault(ins => ins.Id == instructor.Id);

            if (ins != null)
            {
                ins.FirstName = instructor.FirstName;
                ins.LastName = instructor.LastName;
                ins.isTenured = instructor.isTenured;
                ins.Rank = instructor.Rank;
                ins.HiringDate = instructor.HiringDate;
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int Id)
        {
            var instructor = _dbContext.Instructors.FirstOrDefault(ins => ins.Id == Id);

            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Instructor instructor)
        {
            var ins = _dbContext.Instructors.FirstOrDefault(ins => ins.Id == instructor.Id);

            if (ins != null)
            {
                _dbContext.Instructors.Remove(ins);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return NotFound();
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ReyesRITELEC1C.Models;


namespace ReyesRITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InsList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", isTenured = true, Rank = Rank.instructor, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", isTenured = false, Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-08-07")
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", isTenured = true, Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2020-01-25")
                },
                new Instructor()
                {
                    Id= 4,FirstName = "Bongbong",LastName = "Montano", isTenured = false, Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2020-01-26")
                }
            };
        public IActionResult Index()
        {
            return View(InsList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? inst = InsList.FirstOrDefault(truc => truc.Id == id);

            if (inst != null)//was an instructor found?
                return View(inst);


            return NotFound(); 
        
        }

    }
}

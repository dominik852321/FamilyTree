using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DominikO_Tree.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using DominikO_Tree.ViewModels;
using System.Threading;
using System.Text.Json;

namespace DominikO_Tree.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
           _context = context;
        }

        public async Task<IActionResult> Index(string search, int sort)
        {
            List<Person> people = new List<Person>();
            people = await _context.People.ToListAsync();
            
            var vm = new VM()
            { 
                People = people,
                SearchPeople = people
            };

            if(search != null )
                vm.SearchPeople = vm.SearchPeople.Where(x => x.Name.ToLower().Contains(search)).ToList();
             
            if(sort > 0)
                vm.SearchPeople = vm.SearchPeople.OrderByDescending(x => x.Id).ToList(); 
           

            
            ViewData["people"] = new SelectList(people, "Id", "Name");
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> AddPerson()
        {
            var people = await _context.People.ToListAsync();
            ViewData["people"] = new SelectList(people, "Id", "Name");

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> AddPerson(AddPersonVM addPerson)
        {
            if (ModelState.IsValid && await CheckNameExist(addPerson.Name) == 0)
            {
                var peopleCount = await _context.People.CountAsync() + 1;

                Person person = new Person()
                {
                    Id = peopleCount + 1,
                    Name = addPerson.Name,
                    ParentId = addPerson.ParentId
                };
                await _context.People.AddAsync(person);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(addPerson);
        }

        [HttpGet]
        public async Task<IActionResult> EditPerson(int Id)
        {
            var people = await _context.People.ToListAsync();
            ViewData["people"] = new SelectList(people, "Id", "Name");

            var person = await _context.People.FirstOrDefaultAsync(x => x.Id == Id);

            EditPersonVM editPerson = new EditPersonVM()
            {
                Id = person.Id,
                Name = person.Name,
                ParentId = person.ParentId
            };
            
            return View(editPerson);
        }

        [HttpPost]
        public async Task<IActionResult> EditPerson(EditPersonVM editPerson)
        {
            if (ModelState.IsValid)
            {
                var person = await _context.People.FirstOrDefaultAsync(x => x.Id == editPerson.Id);
               
                person.Name = editPerson.Name;
                person.ParentId = editPerson.ParentId;

                _context.People.Update(person);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(editPerson);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePerson(int Id)
        {
           _context.Remove(await _context.People.FirstOrDefaultAsync(x => x.Id == Id));
           await _context.SaveChangesAsync();
           return RedirectToAction("Index");
        }

        public async Task<int> CheckNameExist(string name)
        {
            var searchName = await _context.People.Where(x => x.Name == name).CountAsync();
            if(searchName>0)
            {
                return 1;
            }
            
            return 0;
        }
    }
}

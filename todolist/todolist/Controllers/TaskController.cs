using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todolist.Data;
using todolist.Models;

namespace todolist.Controllers
{
    public class TaskController : Controller
    {
        private readonly db_TodolistContext _context;
        public TaskController(db_TodolistContext context)
        {
            _context = context;
        }
        [HttpGet]
        public  IActionResult Index()
        {

            List<Task> tasks = _context.tbTasks.ToList();
                return View(tasks);
        }
        [HttpGet]
        public IActionResult Edit(int Id) 
        {
            Task task = _context.tbTasks.Where(t => t.TaskId == Id).FirstOrDefault();
            return View(task);
        }
        [HttpPost]
        public IActionResult Edit(Task task) 
        {
            _context.Attach(task);
            _context.Entry(task).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Task task = _context.tbTasks.Where(t => t.TaskId == Id).FirstOrDefault();
            return View(task);
        }
        [HttpPost]
        public IActionResult Delete(Task task) 
        {
            _context.Attach(task);
            _context.Entry(task).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Create() 
        {
            Task task = new Task();
            return View(task);
        }
        [HttpPost]
        public IActionResult Create(Task task) 
        {
            
            _context.Attach(task);
            _context.Entry(task).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}

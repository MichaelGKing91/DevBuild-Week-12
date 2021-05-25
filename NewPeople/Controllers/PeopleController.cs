using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using NewPeople.Models;
using Dapper;
using System.Data;

namespace NewPeople.Controllers
{
    public class PeopleController : Controller
    {
        //static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=newpeople;Uid=root;Password=abc123"); //CHANGE DATABASE NAME
        IDbConnection myDB;
        public PeopleController(IDbConnection _myDB)
        {
            myDB = _myDB;
        }

        public IActionResult Index()
        {

            List<People> allPeople = myDB.GetAll<People>().ToList();
            //List<People> allPeople = myDB.Query<People>("select * from people where lastname like 'B%' order by lastname").ToList();
            //List<People> allPeople = DAL.GetAll();
            return View(allPeople);

        }

        public IActionResult EditForm(int id)
        {
            People aPerson = myDB.Get<People>(id);
            return View(aPerson);
        }

        [HttpPost]
        public IActionResult Edit(People aPerson)
        {
            myDB.Update(aPerson);
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(People aPerson)
        {
            myDB.Insert(aPerson);
            return RedirectToAction("Index");
        }

        public IActionResult QuestionDelete(int id)
        {
            People aPerson = myDB.Get<People>(id);
            return View(aPerson);
        }

        public IActionResult Delete(int id)
        {
            People aPerson = myDB.Get<People>(id);
            myDB.Delete(aPerson);
            return RedirectToAction("Index");
        }


    }
}

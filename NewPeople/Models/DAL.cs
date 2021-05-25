using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Data;

namespace NewPeople.Models
{
    public class DAL
    {
        public static IDbConnection myDB; // = new MySqlConnection("Server=localhost;Database=newpeople;Uid=root;Password=abc123");

        static public List<People> GetAllPeopleByLastName()
        {
            //List<People> peeps = myDB.GetAll<People>().ToList();
            List<People> peeps = myDB.Query<People>("select * from people order by lastname").ToList();
            return peeps;
        }

        static public List<People> GetAllPeopleWithLastName(string lastname)
        {
            //List<People> peeps = myDB.GetAll<People>().ToList();
            List<People> peeps = myDB.Query<People>($"select * from people where lastname = '{lastname}' order by lastname").ToList();
            return peeps;
        }
        static public People GetPerson(int id)
        {
            return myDB.Get<People>(id);
        }
        static public void EditPerson(People peep)
        {
            myDB.Update(peep);
        }
        static public void DeletePerson(int id)
        {
            People peep = new People();
            peep.id = id;
            myDB.Delete<People>(peep); // 
        }

        static public void Create(People peep)
        {
            myDB.Insert(peep);
        }
    }
}

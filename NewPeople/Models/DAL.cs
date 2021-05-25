using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace NewPeople.Models
{
    // This class is not being used.
    public class DAL
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=newpeople;Uid=root;Password=abc123"); //CHANGE DATABASE NAME

        public static List<People> GetAll()
        {
            List<People> allPeople = myDB.Query<People>("select * from people order by lastname").ToList();
            return allPeople;
        }

        public static List<People> Insert()
        {
            List<People> allPeople = myDB.Query<People>("select * from people order by lastname").ToList();
            return allPeople;
        }


    }
}

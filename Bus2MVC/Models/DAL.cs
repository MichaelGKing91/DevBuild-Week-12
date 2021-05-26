using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Bus2MVC.Models
{
    public class DAL
    {
        static public IDbConnection db;
        static public string currentUser;
        // Add all CRUD ops

        public static Department AddDepartment(string id, string name, string location)
        {
            Department dep = new Department() { id = id, name = name, location = location };
            db.Insert(dep);
            return dep;
        }

        public static Department AddDepartment(Department dep)
        {
            dep.username = DAL.currentUser;
            db.Insert(dep);
            return dep;
        }

        public static List<Department> ReadAllDepartments()
        {
            return db.GetAll<Department>().ToList();
        }

        public static Department ReadOneDepartments(string id)
        {
            return db.Get<Department>(id);
        }

        public static void EditDepartment(Department dep)
        {
            db.Update(dep);
        }

        public static void DeleteDepartment(string id)
        {
            // Requires an extra database operation
            //Department temp = db.Get<Department>(id);
            Department temp = new Department();
            temp.id = id;
            // Dapper just needs an obj with an id to delete. It doesnt need the actual instanc.
            db.Delete(temp);
        }

        public static List<Employee> ReadEmpsInDep(string depID)
        {
            
            return db.Query<Employee>($"SELECT * FROM employee where department = '{depID}'").ToList();
        }

        public static bool DeleteEmployee(int id)
        {
            //Employee temp = new Employee() { id = id };
            // Dapper just needs an obj with an id to delete. It doesnt need the actual instance.
            Employee emp = db.Get<Employee>(id);
            if (emp.username == DAL.currentUser || DAL.currentUser == "admin")
            {
                db.Delete(emp);
                return true;
            }
            return false;   
        }

        public static void AddEmployee(Employee emp)
        {
            emp.username = DAL.currentUser;
            db.Insert(emp);
        }
    }

}

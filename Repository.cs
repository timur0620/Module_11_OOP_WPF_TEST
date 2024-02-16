using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_OOP_WPF_TEST
{
    public class Repository
    {
        static Random random;
        static Repository() { random = new Random(); }
        public List<Worker> WorkerDB { get; set; }
        public List<Department> DepartmentDB { get; set; }
        public Repository (int CountDepartment, int CountEmployee)
        {   
            WorkerDB = new List<Worker>();
            DepartmentDB = new List<Department>();

            for (int i = 0; i < CountDepartment; i++)
            {
                DepartmentDB.Add(new Department($"Department {i + 1}", i));
            }
            for (int i = 0;i < CountEmployee; i++)
            {
                WorkerDB.Add(new Worker($"Name {i + 1}", random.Next(18, 30), random.Next(DepartmentDB.Count)));
            }
        }
        public static Repository CreateRepository (int CountDepartment = 10, int CountEmployee = 100) 
        {
            return new Repository (CountDepartment, CountEmployee);
        }
        
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_OOP_WPF_TEST
{
    public class Worker
    {
        public string Name { get; set; }
        public int Age { get; private set; }
        public int DepartmentId { get; private set; }
        public Worker(string Name, int age, int DeptID) 
        {
            this.Name = Name;
            Age = age;
            this.DepartmentId = DeptID;
        }
        public override string ToString()
        {
            return $"{Name,7} {Age,3} {DepartmentId,3}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_OOP_WPF_TEST
{
    public class Department
    {
        public string DepartmentName {  get; set; }
        public int DepartmentId { get; set;}

        public Department(string Name, int id) 
        {
            DepartmentName = Name;
            DepartmentId = id;
        }
        public override string ToString()
        {
            return $"{DepartmentName, 15} {DepartmentId, 3}";
        }
    }
}

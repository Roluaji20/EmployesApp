using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entity
{
    public class Employee
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Name")]
        public string? employee_name { get; set; }
        [DisplayName("Salary")]
        public float employee_salary 
        { get { return _employee_salary;  } set { _employee_salary = value; CalcualteAnualSalary(); } }
        [DisplayName("Age")]
        public int employee_age { get; set; }
        public string? profile_image { get; set; }

        private float _anualSalary;
        private float _employee_salary;

        [DisplayName("AnualSalary")]
        public float AnualSalary
        {
            get { return _anualSalary; }
            set { _anualSalary = value;
            }
        }

        private void CalcualteAnualSalary()
        {
            _anualSalary = employee_salary * 12;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VittePro1
{
    internal class Employee
    {
        public int? Id { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private int age { get; set; }
        private string division { get; set; }
        private DateTime dateStart { get; set; }
        private DateTime? dateFinish { get; set; }

        public Employee(string name, string surname, int age, string division, DateTime dateStart)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.division = division;
            this.dateStart = dateStart;
        }
    }
}

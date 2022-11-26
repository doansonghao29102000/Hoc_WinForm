using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordForm
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Major { get; set; }
        public DateTime BirthDate { get; set; }
        public float Gpa { get; set; }

        public Student(string id , string name , string major , DateTime birthdate, float gpa)
        {
            this.Id = id;
            this.FullName = name;
            this.Major = major;
            this.BirthDate = birthdate;
            this.Gpa = gpa;
            
        }
        public object[] ToPropertiesArray()
        {
            return new object[] { Id, FullName, BirthDate.ToString("dd/MM/yyyy"), Major, Gpa };
        }
    }
}

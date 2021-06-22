using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant7
{
    [Serializable]
    public class Student
    {
        public string firstName;
        public string lastName;
        public int startYear;

        public Student(string firstName, string lastName, int startYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.startYear = startYear;
        }
        public Student()
        {
            this.firstName = "-";
            this.lastName = "-";
            this.startYear = 2000;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + startYear;
        }
    }
}

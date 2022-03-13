using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        public static List<Student> studentsArray;

        public static List<Student> testStudents
        {
            get
            {
                return getStudents();
            }
            private set { }
        }

        public static List<Student> getStudents()
        {
            studentsArray = new List<Student>();

            studentsArray.Add(new Student("Donovan", "Thomas", "Briggs", "FKST", "KSI", "bachelor", "semester graduate", "121218556", 4, 7, 31));
            studentsArray.Add(new Student("Kiro", "Gavrailov", "Dondukov", "FPMI", "MI", "bachelor", "discontinued", "503119002", 1, 9, 22));
            studentsArray.Add(new Student("Joseph", "Jorge", "Joestar", "FKST", "KSI", "bachelor", "active", "503119106", 3, 9, 50));

            return studentsArray;
        }
    }
}

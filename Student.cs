using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Exception
{
    internal class Student
    {
        public string name { get; set; }
        public string registrationNumber { get; set; }
        public int age { get; set; }

        public Student(string name, string registrationNumber, int age)
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.age = age;
        }

        public static Boolean validateStudent(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].registrationNumber == students[j].registrationNumber)
                    {
                        //  throw new ApplicationException($"\r\nTwo student have same registration Number \r\n{students[i].name},with ID {students[i].registrationNumber} \r\n and \r\n{students[j].name},With ID {students[j].registrationNumber} ");
                        throw new sameRegistrationNumberExcption(students[i], students[j]);
                    }
                }
            }
            return true;
        }
    }
}

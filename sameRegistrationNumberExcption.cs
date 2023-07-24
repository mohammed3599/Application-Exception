using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Exception
{
    internal class sameRegistrationNumberExcption : ApplicationException
    {
        Student A { get; set; }
        Student B { get; set; }

        public sameRegistrationNumberExcption(Student A, Student B)
        {
            this.A = A;
            this.B = B;
        }

        //public sameRegistrationNumberExcption(string? message) : base(message)
        //{

        //}
        public override string ToString()
        {
            return $"{A.name} and {B.name} have the same Registration Number";
        }
    }
}

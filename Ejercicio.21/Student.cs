using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._21
{
    internal class Student
    {
        private  static Random random;
        private string name;
        private string surname;
        private int file;

        static Student()
        {
            random = new Random();
        }

        public Student(string name, string surname, int file)
        {
            this.name = name;
            this.surname = surname;
            this.file = file;
        }
    }
}

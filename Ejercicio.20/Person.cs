using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._20
{
    internal class Person
    {
        private string name;
        private string date;
        private int dni;

        public Person(string name, string date, int dni)
        {
            this.name = name;
            this.date = date;
            this.dni = dni;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetDate()
        {
            return this.date;
        }

        public int GetDni()
        {
            return this.dni;
        }

        private int CalculateAge()
        {

        }

        private string IsNotUnderage(Person person)
        {

        }
    }
}

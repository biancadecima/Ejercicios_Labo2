using System;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace Entrants
{
    public class Entrant
    {
        private string[] courses;
        private string address;
        private int age;
        private string gender;
        private string name;
        private string country;

        public Entrant(string[] courses, string address, int age, string gender, string name, string country)
        {
            this.courses = courses;
            this.address = address;
            this.age = age;
            this.gender = gender;
            this.name = name;
            this.country = country;
        }

        public static string ShowEntrant(Entrant e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cursos: ");
            foreach (string s in e.courses)
            {
                if (!String.IsNullOrWhiteSpace(s))
                {
                    sb.AppendLine(s);
                }
            }
            sb.AppendLine($"Dirección: {e.address}");
            sb.AppendLine($"Edad: {e.age}");
            sb.AppendLine($"Género: {e.gender}");
            sb.AppendLine($"Nombre: {e.name}");
            sb.AppendLine($"País: {e.country}");
            return sb.ToString();
        }

        
    }
}
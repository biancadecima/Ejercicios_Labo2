using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Person
    {
        private string _name;
        private int _file;

        public string Name { 
            get { return _name; }
            set { _name = value; }
        }
        public int File {
            get { return _file; }
            set { _file = value; }
        }

        public Person(string name, int file)
        {
            Name = name;
            File = file;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this._name} - Legajo: {this._file}");
            return sb.ToString();
        }
    }
}

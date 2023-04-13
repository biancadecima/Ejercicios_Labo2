using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._19
{
    internal class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public int GetCuenta()
        {
            return this.cantidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"--------------------------");
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Cuenta: {this.cantidad}");
            sb.AppendLine($"--------------------------");

            return sb.ToString();
        }

        public void ingresar(int monto)
        {
            if(monto > 0 )
            {
                this.cantidad += monto;
            } 
        }

        public void retirar(int monto)
        {
            this.cantidad -= monto;
        }
    }
}

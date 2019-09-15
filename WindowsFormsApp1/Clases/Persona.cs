using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        #region Atributos
        private string nombre;
        private string sexo;
        private byte edad;
        private string correo;
        private string password;
        private string direccion;
        private string telefono;
        #endregion Atributos

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public byte Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Password { get => password; set => password = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        #endregion Propiedades

        #region Métodos

        virtual public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Correo: " + Correo);
            Console.WriteLine("Dirección: " + Direccion);
        }

        #endregion Métodos
    }
}

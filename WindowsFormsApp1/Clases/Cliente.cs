using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Clases
{
    public class Cliente:Persona
    {
        #region Atributos
        private string nickName;
        private byte codigoCliente;
        #endregion Atributos

        #region Propiedades
        public string NickName { get => nickName; set => nickName = value; }
        public byte CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        #endregion Propiedades

        #region Métodos
        public override void MostrarDatos()
        {
            Console.WriteLine("NickName/Apodo: " + NickName);
            base.MostrarDatos();
            Console.WriteLine("Codigo de cliente" + CodigoCliente);
        }

        #endregion Métodos
    }
}

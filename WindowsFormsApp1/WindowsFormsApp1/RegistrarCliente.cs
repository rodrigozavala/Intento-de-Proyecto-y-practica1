using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class RegistrarCliente : Form
    {
        private Cliente usuario;
        private ErrorProvider ErrorAcceso;
        private string direccionUsuarios;
        private Form1 padre;
        public RegistrarCliente(string direccionUsuarios,Form1 padre)
        {
            ErrorAcceso = new ErrorProvider();
            InitializeComponent();
            this.padre = padre;
            usuario = new Cliente();
            this.direccionUsuarios = direccionUsuarios;
        }

        private void bttnRegistrarse_Click(object sender, EventArgs e)
        {
            bool existeCuenta;
            usuario.NickName = txtBNickName.Text;
            usuario.Nombre = txtBNombre.Text;
            usuario.Password = txtBPassword.Text;
            usuario.Edad = Convert.ToByte(txtBEdad.Text);
            usuario.Sexo = txtBSexo.Text;
            usuario.Telefono = txtBTelefono.Text;
            usuario.Correo = txtBCorreo.Text;
            usuario.Direccion = txtBDireccion.Text;
            try
            {
                //Pasa la dirección del archivo y el nombre del archivo al constructor del StreamReader 
                StreamReader sr = new StreamReader(direccionUsuarios);//Read the first line of text
                existeCuenta = leyendoUsuarios(sr, usuario.NickName, usuario.Password);
                if (existeCuenta == true)
                {
                    ErrorAcceso.SetError(txtBNickName, "Este nombre de usuario ya existe, escoge otro nombre");
                }
                else
                {
                    StreamWriter wr = new StreamWriter(direccionUsuarios,true,Encoding.ASCII);
                    wr.WriteLine("///");
                    wr.WriteLine(usuario.NickName);
                    wr.WriteLine("Password:");
                    wr.WriteLine(usuario.Password);
                    wr.WriteLine("Nombre:");
                    wr.WriteLine(usuario.Nombre);
                    wr.WriteLine("Sexo:");
                    wr.WriteLine(usuario.Sexo);
                    wr.WriteLine("Edad:");
                    wr.WriteLine(usuario.Edad);
                    wr.WriteLine("Correo:");
                    wr.WriteLine(usuario.Correo);
                    wr.WriteLine("Direccion:");
                    wr.WriteLine(usuario.Direccion);
                    wr.WriteLine("Telefono:");
                    wr.WriteLine(usuario.Telefono);
                    wr.Close();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Exception: " + error.Message);
            }



        }
        private bool leyendoUsuarios(StreamReader sr, string cuenta, string password)
        {
            string line;
            line = sr.ReadLine();
            if (line == "///")//busca el apartado
            {
                line = sr.ReadLine();
                if (line == cuenta)
                {
                    line = sr.ReadLine();
                    if (line == "Password:")
                    {
                        line = sr.ReadLine();
                        if (line == password)//Y ahora sólo me falta saber qué hacer con el if
                        {
                            return true;
                        }
                    }
                }
            }
            while (line != null)
            {
                line = sr.ReadLine();
                if (line == "///")//busca el apartado
                {
                    line = sr.ReadLine();
                    if (line == cuenta)
                    {
                        line = sr.ReadLine();
                        if (line == "Password:")
                        {
                            line = sr.ReadLine();
                            if (line == password)//Y ahora sólo me falta saber qué hacer con el if
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            sr.Close();
            return false;

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            padre.Show();
            this.Hide();
        }
    }
}

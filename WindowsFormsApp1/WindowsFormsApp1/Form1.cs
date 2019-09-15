using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MenuPrincipal pantallaPrincipal;
        private RegistrarCliente pantallaRegistroCliente;
        private string cuenta;
        private string password;
        private bool existeCuenta;
        private ErrorProvider ErrorAcceso;
        private string direccionUsuarioActual;
        private string direccionUsuarios;
        public Form1()
        {
            InitializeComponent();
            ErrorAcceso = new ErrorProvider();
            direccionUsuarioActual = "C:\\Users\\Rodrigo\\source\\repos\\WindowsFormsApp1\\UsuarioActual.txt";
            direccionUsuarios = "C:\\Users\\Rodrigo\\source\\repos\\WindowsFormsApp1\\Usuarios.txt";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttnEntrar_Click(object sender, EventArgs e)
        {
            
            cuenta = txtBNombreUsuario.Text;
            password =txtBPassword.Text;
            try
            {
                //Pasa la dirección del archivo y el nombre del archivo al constructor del StreamReader 
                StreamReader sr = new StreamReader(direccionUsuarios);//Read the first line of text
                existeCuenta=leyendoDatos(sr, cuenta, password);
                if (existeCuenta == false)
                {
                   ErrorAcceso.SetError(txtBNombreUsuario, "Usuario o contraseña incorrecta");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Exception: " + error.Message);
            }
        }

        private bool leyendoDatos(StreamReader sr,string cuenta, string password)
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
                            pantallaPrincipal = new MenuPrincipal(cuenta,direccionUsuarios);
                            pantallaPrincipal.Show();
                            this.Hide();
                            StreamWriter wr = new StreamWriter(direccionUsuarioActual);
                            wr.WriteLine(cuenta);
                            wr.Close();
                            pantallaPrincipal = null;
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
                                pantallaPrincipal = new MenuPrincipal(cuenta,direccionUsuarios);
                                pantallaPrincipal.Show();
                                this.Hide();
                                StreamWriter wr = new StreamWriter(direccionUsuarioActual);
                                wr.WriteLine(cuenta);
                                wr.Close();
                                pantallaPrincipal = null;
                                return true;
                            }
                        }
                    }
                }
            }
            sr.Close();
            return false;

        }

        private void bttnRegistrarse_Click(object sender, EventArgs e)
        {
            pantallaRegistroCliente = new RegistrarCliente(direccionUsuarios,this);
            this.Hide();
            pantallaRegistroCliente.Show();
            pantallaRegistroCliente = null;
        }
    }
}

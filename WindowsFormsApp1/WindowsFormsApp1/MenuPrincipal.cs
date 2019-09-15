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
    public partial class MenuPrincipal : Form
    {
        private Cliente usuarioActual;
        public MenuPrincipal(string cuenta,string direccionUsuarios)
        {
            usuarioActual = new Cliente();
            InitializeComponent();
            StreamReader sr = new StreamReader(direccionUsuarios);
            encontrarUsuario(sr,cuenta);
            usuarioActual.NickName = cuenta;
            label1.Text = usuarioActual.NickName;
            label2.Text = usuarioActual.Nombre;
            label3.Text = usuarioActual.Password;
            label4.Text = usuarioActual.Sexo;
            label5.Text = usuarioActual.Telefono;
            label6.Text = usuarioActual.Correo;
            label7.Text = usuarioActual.Direccion;
            label8.Text = Convert.ToString(usuarioActual.Edad);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void encontrarUsuario(StreamReader sr, string cuenta)
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
                        usuarioActual.Password = line;
                        line = sr.ReadLine();
                        if (line == "Nombre:")
                        {
                            line = sr.ReadLine();
                            usuarioActual.Nombre = line;
                            line = sr.ReadLine();
                            if (line == "Sexo:")
                            {
                                line = sr.ReadLine();
                                usuarioActual.Sexo = line;
                                line = sr.ReadLine();
                                if (line == "Edad:")
                                {
                                    line = sr.ReadLine();
                                    usuarioActual.Edad = Convert.ToByte(line);
                                    line = sr.ReadLine();
                                    if (line == "Correo:")
                                    {
                                        line = sr.ReadLine();
                                        usuarioActual.Correo = line;
                                        line = sr.ReadLine();
                                        if (line == "Direccion:")
                                        {
                                            line = sr.ReadLine();
                                            usuarioActual.Direccion = line;
                                            line = sr.ReadLine();
                                            if (line == "Telefono:")
                                            {
                                                line = sr.ReadLine();
                                                usuarioActual.Telefono = line;
                                                line = sr.ReadLine();
                                            }
                                        }
                                    }
                                }
                            }
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
                            usuarioActual.Password = line;
                            line = sr.ReadLine();
                            if (line == "Nombre:")
                            {
                                line = sr.ReadLine();
                                usuarioActual.Nombre = line;
                                line = sr.ReadLine();
                                if (line == "Sexo:")
                                {
                                    line = sr.ReadLine();
                                    usuarioActual.Sexo = line;
                                    line = sr.ReadLine();
                                    if (line == "Edad:")
                                    {
                                        line = sr.ReadLine();
                                        usuarioActual.Edad = Convert.ToByte(line);
                                        line = sr.ReadLine();
                                        if (line == "Correo:")
                                        {
                                            line = sr.ReadLine();
                                            usuarioActual.Correo = line;
                                            line = sr.ReadLine();
                                            if (line == "Direccion:")
                                            {
                                                line = sr.ReadLine();
                                                usuarioActual.Direccion = line;
                                                line = sr.ReadLine();
                                                if (line == "Telefono:")
                                                {
                                                    line = sr.ReadLine();
                                                    usuarioActual.Telefono = line;
                                                    line = sr.ReadLine();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sr.Close();
        }

    }
}

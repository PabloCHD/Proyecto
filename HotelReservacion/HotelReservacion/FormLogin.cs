using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservacion
{
    public partial class FormLogin : Form
    {
        Seguridad.BL.SeguridadBL _seguridad;
        public FormLogin()
        {
           
            InitializeComponent();
            _seguridad = new Seguridad.BL.SeguridadBL();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            string usuario;
            usuario = textBox1.Text;
            password = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, password);

            if (resultado==true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña INCORRECTA");
            }
        }

        
    }
}

using Seguridad.BL;
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
    public partial class FormMenu : Form
    {
        

        public FormMenu()
        {
            InitializeComponent();

            

        }
        
           

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void nuevaReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReservaciones = new FormNuevaReservacion();
            formReservaciones.MdiParent = this;
            formReservaciones.Show();
        }

        private void cancelarReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCancelarReservaciones = new FormCancelarReservacion();
            formCancelarReservaciones.MdiParent = this;
            formCancelarReservaciones.Show();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }
    }
}

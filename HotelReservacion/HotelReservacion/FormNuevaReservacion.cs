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
    public partial class FormNuevaReservacion : Form
    {
        Seguridad.BL.ReservacionBL _reservaciones;

        public FormNuevaReservacion()
        {
            InitializeComponent();
            _reservaciones = new Seguridad.BL.ReservacionBL();
            listaReservacionesBindingSource.DataSource = _reservaciones.ObtenerReservacion();

        }


    }
}

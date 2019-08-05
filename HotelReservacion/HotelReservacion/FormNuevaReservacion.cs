using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Reservacion.BL.ReservacionBL;

namespace HotelReservacion
{
    public partial class FormNuevaReservacion : Form
    {
        Reservacion.BL.ReservacionBL _reservaciones;

        public FormNuevaReservacion()
        {
            InitializeComponent();
            _reservaciones = new Reservacion.BL.ReservacionBL();
            listaReservacionesBindingSource.DataSource = _reservaciones.ObtenerReservacion();

        }

       

        private void listaReservacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaReservacionesBindingSource.EndEdit();
            var reservacion = (Reservacion.BL.ReservacionBL.Reservacion)listaReservacionesBindingSource.Current;
            var resultado = _reservaciones.GuardarReservacion(reservacion);
            if (resultado == true)
            {
                listaReservacionesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show("Error al Guardar Reservacion");
            }
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reservaciones.AgregarReservaciones();
            listaReservacionesBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false) ;
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text!="")
            {
                var id = Convert.ToInt32(idTextBox.Text);
                Eliminar(id);
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _reservaciones.EliminarReservaciones(id);
            if (resultado == true)
            {
                listaReservacionesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al Eliminar Reservacion");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}

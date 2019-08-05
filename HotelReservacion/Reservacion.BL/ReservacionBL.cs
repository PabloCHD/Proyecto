using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservacion.BL
{
    public class ReservacionBL
    {
        public BindingList<Reservacion> ListaReservaciones { get; set; }

        public ReservacionBL()
        {
            ListaReservaciones = new BindingList<Reservacion>();

            var reservacion1 = new Reservacion();
            reservacion1.Id = 1;
            reservacion1.Nombre = "Flor";
            reservacion1.Edad = 20;
            reservacion1.Origen = "Santa Barbara";
            reservacion1.Npersonas = 2;
            reservacion1.HoraI = new DateTime(2019, 7, 28);
            reservacion1.Pago = 450;
            reservacion1.Activo = true;

            var reservacion2 = new Reservacion();
            reservacion2.Id = 2;
            reservacion2.Nombre = "Nico";
            reservacion2.Edad = 21;
            reservacion2.Origen = "Yoro";
            reservacion2.Npersonas = 2;
            reservacion2.HoraI = new DateTime(2019, 7, 28);
            reservacion2.Pago = 650;
            reservacion2.Activo = true;

            var reservacion3 = new Reservacion();
            reservacion3.Id = 3;
            reservacion3.Nombre = "David";
            reservacion3.Edad = 23;
            reservacion3.Origen = "Progreso";
            reservacion3.Npersonas = 3;
            reservacion3.HoraI = new DateTime(2019, 7, 28);
            reservacion3.Pago = 700;
            reservacion3.Activo = true;

            var reservacion4 = new Reservacion();
            reservacion4.Id = 4;
            reservacion4.Nombre = "Pablo";
            reservacion4.Edad = 30;
            reservacion4.Origen = "San Pedro Sula";
            reservacion4.Npersonas = 1;
            reservacion4.HoraI = new DateTime(2019, 7, 28);
            reservacion4.Pago = 350;
            reservacion4.Activo = true;

            ListaReservaciones.Add(reservacion1);
            ListaReservaciones.Add(reservacion2);
            ListaReservaciones.Add(reservacion3);
            ListaReservaciones.Add(reservacion4);
            
        }

        public BindingList<Reservacion> ObtenerReservacion()
        {
            return ListaReservaciones;
        }

        public bool GuardarReservacion(Reservacion reservacion)
        {
            if (reservacion.Id == 0)
            {
                reservacion.Id = ListaReservaciones.Max(item => item.Id) + 1;
            }
            return true;
        }


        public void AgregarReservaciones()
        {
            var nuevaReservacion = new Reservacion();
            ListaReservaciones.Add(nuevaReservacion);
        }

        public bool EliminarReservaciones(int id)
        {
            foreach (var item in ListaReservaciones)
            {
                if (item.Id == id)
                {
                    ListaReservaciones.Remove(item);
                    return true;
                }
            }
            return false;

        }


        public class Reservacion
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Origen { get; set; }
            public int Npersonas { get; set; }
            public DateTime HoraI { get; set; }
            public double Pago { get; set; }
            public bool Activo { get; set; }
        }






    }
}

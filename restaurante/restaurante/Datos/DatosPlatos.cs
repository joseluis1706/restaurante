using restaurante.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace restaurante.Datos
{
    public class DatosPlatos
    {
        public ObservableCollection<ModelPlatos> ListarPlatos()
        {
            return new ObservableCollection<ModelPlatos>()
            {
                new ModelPlatos()
                {
                    descripcion = "plato 1",
                    precio = "$5.000",
                    icono = "https://ibb.co/2snsxj1"
                },
                new ModelPlatos()
                {
                    descripcion = "plato 2",
                    precio = "$5.000",
                    icono = "https://ibb.co/MfHBhZ2"
                },
                new ModelPlatos()
                {
                    descripcion = "plato 3",
                    precio = "$5.000",
                    icono = "https://ibb.co/pvS4b2X"
                },
            };
        }
    }
}

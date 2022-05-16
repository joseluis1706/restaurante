using restaurante.Datos;
using restaurante.Model;
using restaurante.VistaModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace restaurante.ViewModel
{
    public class PrincipalViewModel:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<ModelPlatos> _listaPlatos;
        #endregion
        #region CONSTRUCTOR
        public PrincipalViewModel(INavigation navigation)
        {
            Navigation = navigation;
            ListarPlatos();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<ModelPlatos> ListaPlatos
        {
            get { return _listaPlatos; }
            set { SetValue(ref _listaPlatos, value); }
        }
        #endregion
        #region PROCESOS
        public void ListarPlatos()
        {
            var funcion = new DatosPlatos();
            ListaPlatos = funcion.ListarPlatos();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDO
        //public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

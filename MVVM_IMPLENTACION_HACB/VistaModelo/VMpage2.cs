using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_IMPLENTACION_HACB.Modelo;

namespace MVVM_IMPLENTACION_HACB.VistaModelo
{
    internal class VMpage2: BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuario> listausuario {  get; set; }
        #endregion
        #region CONTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            MostraUsuarios();
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        public void MostraUsuarios()
        {
            listausuario = new List<Musuario>
            {
                new Musuario
                {
                    Nombre = "Furina1",
                    Imagen = "https://i.ibb.co/GMxnP8D/dee6a9929c83caca52904d830909742c.jpg"

                },
                new Musuario
                {
                    Nombre = "Furina2",
                    Imagen = "https://i.ibb.co/9pyVhyT/884596c19b8b67c918de4f3fef34521b.jpg"
                },
                new Musuario
                {
                    Nombre = "Furina3",
                    Imagen = "https://i.ibb.co/YZkWVtF/0a3d856d01d52bb7e513122ef43782de.jpg"
                }
            };
        }
        public async Task Alerta()
        {
            await DisplayAlert("Titulo", "Mensaje", "ok");
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand MostraUsuarioscommand => new Command(MostraUsuarios);
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command(async () => await Alerta());
        #endregion
    }
}

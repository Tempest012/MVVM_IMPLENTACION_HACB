using MVVM_IMPLENTACION_HACB.Modelo;
using MVVM_IMPLENTACION_HACB.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_IMPLENTACION_HACB.VistaModelo
{
    class VMmenuprincipal: BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listausuario { get; set; }
        #endregion
        #region CONTRUCTOR
        public VMmenuprincipal(INavigation navigation)
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
            listausuario = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Enty, datepicker, picker, label , navegacion",
                    Icono = "https://i.ibb.co/GMxnP8D/dee6a9929c83caca52904d830909742c.jpg"

                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a base a datos",
                    Icono = "https://i.ibb.co/9pyVhyT/884596c19b8b67c918de4f3fef34521b.jpg"
                },
                new Mmenuprincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://i.ibb.co/R6XRyS6/sticker-png-green-circle-gardevoir-drawing-gallade-fan-art-comics-cuteness-video-thumbnail.png"
                }
            };
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina=parametros.Pagina;
            if(pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if(pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if(pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion
        #region COMANDOS
      //  public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand MostraUsuarioscommand => new Command(MostraUsuarios);
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}

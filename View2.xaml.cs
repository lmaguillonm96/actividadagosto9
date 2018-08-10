using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace actividadagosto9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View2 : ContentPage
    {
        public View2()
        {
            InitializeComponent();
        }
    
        void pickMusic_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var elementoSeleccionado = pickMusic.SelectedItem.ToString();
            DisplayAlert("Genero Musica", elementoSeleccionado, "Aceptar");
        }
        void btnSimular_Cliked(object sender, System.EventArgs e)
        {
            var progreso = progressNum.Progress;
            if (progreso == 1)
            {
                progressNum.ProgressTo(.1, 250, Easing.SpringOut);

            }
            else
            {
                progressNum.ProgressTo(1, 300, Easing.Linear);

            }


        }
        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando Resultados", "Aceptar");

        }
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            DisplayAlert("Cambiando", "Este texto esta cambiando", "Aceptar");

        }
        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            labCambio.Text = mama.Value.ToString();
        }

        void stepEvent(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            lbDisplay.Text = steeper.Value.ToString();
        }
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var estado = this.swtEstado.IsToggled;
            if (this.swtEstado.IsToggled)
            {
                DisplayAlert(
                    "Switch", "Estoy encendido", "Aceptar");

            }
            else
            {
                DisplayAlert("Switch", "Estoy apagado", "Aceptar");
            }
        }
    }
}
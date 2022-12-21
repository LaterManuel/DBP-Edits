using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AhoraSi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string english = "";
            string leng = "";
            string habil = "";
            if (videojuegos.IsChecked)
            {
                habil += "- Programacion videojuegos" + Environment.NewLine;
            }
            if (office.IsChecked)
            {
                habil += "- Uso de Ofimatica de Office" + Environment.NewLine;
            }
            if (video.IsChecked)
            {
                habil += "- Experto en creacion de Videos" + Environment.NewLine;
            }
            if (musica.IsChecked)
            {
                habil += "- Musico de hobby" + Environment.NewLine;
            }
            if (editor.IsChecked)
            {
                habil += "- Editor de videos 4k" + Environment.NewLine;
            }
            if (Python.IsChecked)
            {
                leng += " Python ";
            }
            if (Java.IsChecked)
            {
                leng += " Java ";
            }
            if (Html.IsChecked)
            {
                leng += " Html ";
            }
            if (C.IsChecked)
            {
                leng += " C ";
            }
            if (basico.IsChecked)
            {
                english = basico.Value.ToString();
            }
            if (intermedio.IsChecked)
            {
                english = intermedio.Value.ToString();
            }
            if (avanzado.IsChecked)
            {
                english = avanzado.Value.ToString();
            }
            if (fluido.IsChecked)
            {
                english = fluido.Value.ToString();
            }
            string nombre = name.Text;
            string nacimiento = borndate.Date.ToString("d");
            string telefono = number.Text;
            string ocupacion = ocupation.Text;
            string correo = mail.Text;
            string nacionalidad = (string)nacionality.ItemsSource[nacionality.SelectedIndex];
            string ingles = english;
            string lenguaje = leng;
            string habilidades = habil;
            string perfil = inperfil.Text;
            string aptitudes = aptitud.Text;
            string experiencia = experience.Text;
            string formacion = formation.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new Page2(nombre, ocupacion,telefono, correo, nacimiento, nacionalidad, perfil, ingles, lenguaje, habilidades, aptitudes, experiencia, formacion));
        }
    }
}
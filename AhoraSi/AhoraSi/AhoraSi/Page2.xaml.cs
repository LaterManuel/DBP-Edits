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
    public partial class Page2 : ContentPage
    {
        public Page2(string nombre, string ocupacion,string telefono, string correo, string nacimiento, string nacionalidad, string perfil, string ingles, string lenguaje, string habilidades, string aptitudes, string experiencia, string formacion)
        {
            InitializeComponent();
            nombr.Text = nombre;
            ocp.Text = ocupacion;
            nac.Text = nacimiento;
            cor.Text = "Correo: " + correo + Environment.NewLine + "Telefono de contacto: " + telefono ;
            perf.Text = perfil + Environment.NewLine + "Nacionalidad: " + nacionalidad;
            ing.Text = "Nivel de Ingles: " + ingles;
            leng.Text = "Leng. de program: " + lenguaje + Environment.NewLine + "Aptitudes propias: " + aptitudes;
            hab.Text = habilidades;
            exp.Text = experiencia;
            form.Text = formacion;
        }
    }
}
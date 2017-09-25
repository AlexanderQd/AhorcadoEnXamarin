using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ahorcado
{
    
    public partial class MainPage : ContentPage
    {
        readonly string[] ALFABETO = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public MainPage()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            imageAhorcado.Source = ImageSource.FromResource("Ahorcado.imagenes.1.jpg");
            int fila = 0;
            for (int c = 0; c < 7; c++)                
                gridBotonera.Children.Add(new Button
                {
                    Text = ALFABETO[c],
                    VerticalOptions = LayoutOptions.Center
                }, c, fila);
        }
    }
}

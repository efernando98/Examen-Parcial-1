using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            string num = (numero.Text);
            num = num.Remove(num.Length - 1);
            int x, y;

            y = int.Parse(num);
            x = y - 4;


            DisplayAlert("El numero es:", x.ToString(), "Siguiente");

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            (sender as Button).Text = "Anote cualquier numero";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            (sender as Button).Text = "Multiplique el numero por dos";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            (sender as Button).Text = "sumale 8 al resultado";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            (sender as Button).Text = "El resultado multiplicarlo por cinco";
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            (sender as Button).Text = "El resultado final es";
        }
    }

}
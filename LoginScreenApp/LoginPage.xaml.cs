using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginScreenApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();  
        }

        async private void ButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFieldUsername.Text) && string.IsNullOrEmpty(txtFieldPassword.Text))
            {
                await DisplayAlert("Error", "Los campos están vacíos", "Ok");
            }
            else if (string.IsNullOrEmpty(txtFieldUsername.Text))
            {
                await DisplayAlert("Error", "El campo email no puede estar vacío", "Ok");
            }
            else if (string.IsNullOrEmpty(txtFieldPassword.Text))
            {
                await DisplayAlert("Error", "El campo password no puede estar vacío", "Ok");
            }
            else
            {
                await DisplayAlert("Bienvenido", $"¡Hola {txtFieldUsername.Text}!", "Ok");
            }
        }

        async private void TapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Register", "This simulates Register Page", "Ok");
        }
    }
}
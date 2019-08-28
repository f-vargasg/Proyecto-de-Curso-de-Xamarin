using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
	public partial class BienvenidaPage : ContentPage
	{
		public BienvenidaPage()
		{
			InitializeComponent();

			Title = "Hola mundo";
			NavigationPage.SetBackButtonTitle(this, Title);
			NavigationPage.SetHasNavigationBar(this, false);

			if (Device.RuntimePlatform == Device.iOS)
			{
				botonComenzar.BackgroundColor = Color.DarkGray;
			}

			botonComenzar.Clicked += BotonComenzar_Clicked;
		}

		private async void BotonComenzar_Clicked(object sender, EventArgs e)
		{
			//
			await Navigation.PushAsync(new MainPage() {
				// NombreUsuario = entryNombre.Text
			});
		}
	}
}

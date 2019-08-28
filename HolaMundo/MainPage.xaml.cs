using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMundo
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : TabbedPage
	{
		public string NombreUsuario { get; set; }

		public MainPage()
		{
			InitializeComponent();

			int numero = 123;

			var variable = new {
				Titulo = "",
				Edad = numero
			};

			Console.WriteLine(variable);
            /*
			boton1.Text = "listo. Haga click";

			// Evento
			boton1.Clicked += Boton1_Click;
            
			// Command
			botonControles.Command = new Command(() => {
            
				// PushAsync / PushModalAsync
				Navigation.PushAsync(new ControlesPage {
					Title = "Pantalla" + Navigation.NavigationStack.Count
				});
			});
            */
		}

	/*
     protected override void OnAppearing()
		{
			base.OnAppearing();

			entryNombre.Text = NombreUsuario;
		}

		private void Boton1_Click(object sender, EventArgs e)
		{
			var mensaje = "Hola Mundo! " + entryNombre.Text;
			Console.WriteLine(mensaje);

			mensaje = string.Concat("Hola Mundo", entryNombre.Text);
			Console.WriteLine(mensaje);

			mensaje = $"Hola mundo {entryNombre.Text}";
			Console.WriteLine(mensaje);

			DisplayAlert("Titulo", mensaje, "Cerrar");
		}
        */
	}
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

// Deserializacion
using Newtonsoft.Json;
using HolaMundo.Modelos;
using HolaMundo.Datos;

namespace HolaMundo
{
	public partial class ListadoPage
	{
		public SQLiteDb BaseDatos { get => DependencyService.Get<SQLiteDb>(); }

		public ObservableCollection<Producto> Datos { get; set; } = new ObservableCollection<Producto>();

		public Command AgregarCommand { get; set; }

		public Command RefrescarCommand { get; set; }

		public ListadoPage()
		{
			AgregarCommand = new Command(() => {

				// Accion de codigo del comando
				Datos.Add(new Producto { Nombre = "Nuevo elemento" });
			});

			RefrescarCommand = new Command(async() => {

				await Task.Delay(2000);

				Refrescar();

				IsBusy = false;
			});

			BindingContext = this;

			InitializeComponent();

			/*
			for (int i = 0; i < 5; i++)
			{
				Datos.Add(i.ToString());
			}*/

			//listViewDatos.ItemsSource = Datos;

			listViewDatos.ItemTapped += ListViewDatos_ItemTapped;
		}

		private async void Refrescar()
		{
			Datos.Clear();

			IsBusy = true;

			try
			{
				if (Xamarin.Essentials.Connectivity.NetworkAccess != Xamarin.Essentials.NetworkAccess.Internet)
				{
					await DisplayAlert("Importante", "No hay internet!", "Cerrar");
				}
				// WebService, con conexion

				// Llamado al API REST
				var httpClient = new HttpClient();

				const string restAPI = "https://cloud-services.azurewebsites.net/api/";

				httpClient.BaseAddress = new Uri(restAPI);

				// importante: usar el await
				string resultado = await httpClient.GetStringAsync("products");

				// Deserializar a clases
				var objetos = JsonConvert.DeserializeObject<Producto[]>(resultado);

				//Datos.Add(resultado);
				Console.WriteLine(resultado);
				await BaseDatos.DeleteAllAsync();

				foreach (Producto item in objetos)
				{
					Datos.Add(item);
					await BaseDatos.InsertAsync(item);
				}

				Console.WriteLine((await BaseDatos.ListAsync()).Count);

				IsBusy = false;
			}
			catch (Exception ex)
			{
				// Cargar desde SQLite
				var locales = await BaseDatos.ListAsync();

				foreach (var item in locales)
				{
					Datos.Add(item);
				}
			}	
		}

		// async
		protected override async void OnAppearing()
		{
			base.OnAppearing();

			Refrescar();
		}

		// async
		private async void ListViewDatos_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var seleccion = (Producto)e.Item;

			await Navigation.PushAsync(new DetalleProductoPage() { Modelo = seleccion });
		}
	}
}

using HolaMundo.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPeliculasPage : ContentPage
    {


        public ObservableCollection<Pelicula> Datos { get; set; } = new ObservableCollection<Pelicula>();

        public Command RefrescarCommand { get; set; }
       
        public ListPeliculasPage()
        {
            RefrescarCommand = new Command(async () => {

                await Task.Delay(2000);

                Refrescar();

                IsBusy = false;
            });

            BindingContext = this;  // importantisimo
            InitializeComponent();

            listViewDatos.ItemTapped += ListViewDatos_ItemTapped;

        }

        private async void ListViewDatos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var seleccion = (Pelicula)e.Item;

            await Navigation.PushAsync(new DetPeliculaPage() { Peli = seleccion });
        }

        private async void Refrescar()
        {
            Datos.Clear();

            IsBusy = true;
            // WebService, con conexion

            // Llamado al API REST
            var httpClient = new HttpClient();

            const string restAPI = "https://swapi.co/api/";

            httpClient.BaseAddress = new Uri(restAPI);

            // importante: usar el await
            string resultado = await httpClient.GetStringAsync("films");

            // Deserializar a clases
            var objetos = JsonConvert.DeserializeObject<PeliculasCons>(resultado);

            //Datos.Add(resultado);
            //Console.WriteLine(resultado);

            foreach (var item in objetos.Results)
            {
                Datos.Add(item);
            }

            IsBusy = false;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            Refrescar();
        }
    }
}
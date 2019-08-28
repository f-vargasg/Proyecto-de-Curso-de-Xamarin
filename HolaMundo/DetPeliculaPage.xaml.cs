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
    public partial class DetPeliculaPage : ContentPage
    {

        public ObservableCollection<DetPersonaje> Datos { get; set; } = new ObservableCollection<DetPersonaje>();

        public DetPeliculaPage()
        {
            InitializeComponent();

            listViewPersonajes.ItemTapped += ListViewPersonajes_ItemTapped;
        }

        private async void ListViewPersonajes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var seleccion = (DetPersonaje)e.Item;
            var httpClient = new HttpClient();

            string resultado = await httpClient.GetStringAsync(seleccion.UrlApi);

            // Console.WriteLine(resultado);

            // Deserializar a clases
            var personaje = JsonConvert.DeserializeObject<Personaje>(resultado);

            await Navigation.PushAsync(new DetPersonajePage() { Pers = personaje });
        }

        public Pelicula Peli { get; set; }

        protected override void OnAppearing()
        {
            BindingContext = Peli;

            base.OnAppearing();

            Refrescar();
        }

        private async void Refrescar()
        {
            Datos.Clear();

            IsBusy = true;
            // WebService, con conexion

            // Llamado al API REST
            // var httpClient = new HttpClient();

            // const string restAPI = "https://swapi.co/api/";

            // httpClient.BaseAddress = new Uri(restAPI);

            // importante: usar el await
            // string resultado = await httpClient.GetStringAsync("films");

            // Deserializar a clases
            // var objetos = JsonConvert.DeserializeObject<PeliculasCons>(resultado);

            //Datos.Add(resultado);
            //Console.WriteLine(resultado);
            // listViewPersonajes.ItemsSource = Peli.Characters;
            List<string> nomPersonajes = new List<string>();

            foreach (var urlApiDetPers in Peli.Characters)
            {
                // WebService, con conexion

                // Llamado al API REST
                var httpClient = new HttpClient();

                // const string restAPI = "https://swapi.co/api/";

                

                // httpClient.BaseAddress = new Uri(restAPI);

                // importante: usar el await
                // string resultado = await httpClient.GetStringAsync("films");
                string resultado = await httpClient.GetStringAsync(urlApiDetPers);

                // Console.WriteLine(resultado);

                // Deserializar a clases
                var objetos = JsonConvert.DeserializeObject<Personaje>(resultado);
                DetPersonaje detPersonaje = new DetPersonaje();
                detPersonaje.Name = objetos.Name;
                detPersonaje.UrlApi = urlApiDetPers;
                Datos.Add(detPersonaje);
            }
            listViewPersonajes.ItemsSource = Datos;
            /*
            foreach (var item in Peli.Characters)
            {
                Datos.Add(item);
            }
            */

            IsBusy = false;
        }
    }
}
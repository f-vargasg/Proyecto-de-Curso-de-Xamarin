using HolaMundo.Datos;
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
    public partial class ListCustomerPage : ContentPage
    {
        public SQLiteCustomerDb BaseDatos { get => DependencyService.Get<SQLiteCustomerDb>(); }
        public ObservableCollection<Customer> Datos { get; set; } = new ObservableCollection<Customer>();

        public Command RefrescarCommand { get; set; }
        public ListCustomerPage()
        {
            RefrescarCommand = new Command(async () => {

                await Task.Delay(2000);

                Refrescar();

                IsBusy = false;
            });
            InitializeComponent();
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

                const string restAPI = "http://northwind.netcore.io/";

                httpClient.BaseAddress = new Uri(restAPI);

                // importante: usar el await
                string resultado = await httpClient.GetStringAsync("customers.json");

                // Deserializar a clases
                var objetos = JsonConvert.DeserializeObject<Customer[]>(resultado);

                //Datos.Add(resultado);
                Console.WriteLine(resultado);
                await BaseDatos.DeleteAllAsync();

                foreach (Customer item in objetos)
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
    }
}
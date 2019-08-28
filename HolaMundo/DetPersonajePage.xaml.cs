using HolaMundo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetPersonajePage : ContentPage
    {
        public DetPersonajePage()
        {
            InitializeComponent();
        }

        public Personaje Pers { get; set; }

        protected override void OnAppearing()
        {
            BindingContext = Pers;
            base.OnAppearing();

        }
    }
}
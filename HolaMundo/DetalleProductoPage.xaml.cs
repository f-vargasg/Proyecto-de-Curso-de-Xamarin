using HolaMundo.Modelos;

namespace HolaMundo
{
	public partial class DetalleProductoPage
	{
		public DetalleProductoPage()
		{
			InitializeComponent();
		}

		public Producto Modelo { get; set; }

		protected override void OnAppearing()
		{
			BindingContext = Modelo;

			base.OnAppearing();

		}
	}
}

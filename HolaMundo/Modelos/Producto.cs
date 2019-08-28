using System;
using Newtonsoft.Json;
using SQLite;

namespace HolaMundo.Modelos
{
	[Table("Productos")]
	public class Producto
	{
		[PrimaryKey, Column("Id"), AutoIncrement]
		public int Id { get; set; } 

		[JsonProperty(PropertyName = "name")]
		[Column(nameof(Nombre)), NotNull]
		public string Nombre { get; set; }

		[JsonProperty(PropertyName = "price")]
		[Column(nameof(Precio)), NotNull]
		public double Precio { get; set; }

		[Column(nameof(Cantidad)), NotNull]
		public double Cantidad { get; set; }

		[Ignore]
		public string LineaTotal { get => Nombre + "    -     " + Precio; }
	}
}

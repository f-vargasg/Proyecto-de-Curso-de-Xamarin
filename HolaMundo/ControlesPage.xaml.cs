using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
	public partial class ControlesPage : ContentPage
	{
		public ControlesPage()
		{
			InitializeComponent();

			toolbarItem1.Command = new Command(() => Console.WriteLine("click"));

			toolbarItem2.Command = toolbarItem1.Command;
			toolbarItem3.Command = toolbarItem1.Command;
		}
	}
}

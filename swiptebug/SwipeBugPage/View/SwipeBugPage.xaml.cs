using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace swipebug
{
	public partial class SwipeBugPage : ContentPage
	{
		public SwipeBugPage ()
		{

			this.BindingContext = new SwipeBugPageViewModel ();

			InitializeComponent ();
		}

		public void OnDelete (object sender, EventArgs e) 
		{
			DisplayAlert ("Clicked", "Button has been clicked", "OK");
		}

		public async void OnItemSelected(object sender, ItemTappedEventArgs e)
		{
			((ListView)sender).SelectedItem = null;

			var exc = new Exception ("Ups");
			await DisplayAlert ("test", "blub", "blah");
			throw exc;
		}
	}
}


using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kontakty
{
	public partial class PeopleList : ContentPage
	{
		public PeopleList()
		{
			InitializeComponent();
			fill();
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();

			fill();

		}

		/// <summary>
		/// Odkaz na stránku přidání nového uživatele
		/// </summary>
		/// <returns>-------</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void pridat(object sender, EventArgs args)
		{
			fill();
			Navigation.PushModalAsync(new NewPerson());
		}

		/// <summary>
		/// Otevření stránky s detailem po kliknutí
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public async void SelectedItemMethod(object sender, ItemTappedEventArgs e)
		{
			fill();
			//vytvoření var s info o uživately
			App.person = e.Item as Person;
			//otevře novou stranku
			await Task.Delay(3);
			await Navigation.PushAsync(new Detail());
		}

		/// <summary>
		/// Napln ListView kontakty
		/// </summary>
		public void fill() { 
			var dbConnection = App.Database;
			PersonDatabase personDatabase = App.Database;

			PeopleListViewFormatted.ItemsSource = App.Database.GetItemsAsync().Result;

		}



	}
}

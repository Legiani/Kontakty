using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Kontakty
{
	public partial class PeopleList : ContentPage
	{
		public PeopleList()
		{
			InitializeComponent();

		

			var dbConnection = App.Database;
			PersonDatabase personDatabase = App.Database;

			PeopleListViewFormatted.ItemsSource = App.Database.GetItemsAsync().Result;

			//vypis skupin a kontaktu do Listviev
			//PeopleListViewFormatted.ItemsSource = grouped;
		

		}

		/// <summary>
		/// Odkaz na stránku přidání nového uživatele
		/// </summary>
		/// <returns>-------</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void pridat(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new NewPerson());
		}

		/// <summary>
		/// Otevření stránky s detailem po kliknutí
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public async void SelectedItemMethod(object sender, ItemTappedEventArgs e)
		{
			//vytvoření var s info o uživately
			var user = e.Item as Person;
			//otevře novou stranku
			await Navigation.PushAsync(new Detail(user));
		}



	}
}

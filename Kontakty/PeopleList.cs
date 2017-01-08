using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Kontakty
{
	public partial class PeopleList : ContentPage
	{
		//list listu se skupinamy a jednotlivímy kontakty
		ObservableCollection<Groop> grouped { get; set; }
		public PeopleList()
		{
			InitializeComponent();

			//vložení dat do listu
			grouped = new ObservableCollection<Groop>();
			var A = new Groop() { LongName = "Akát", 	ShortName = "A" };
			var E = new Groop() { LongName = "Erb",		ShortName = "E" };
			A.Add(new Person() { Firstname = "Anna", 	Lastname = "Polik", DateOfBirth = new DateTime(1980 + 34, 1, 1), ID = 1, Phone = 222552471 });
			A.Add(new Person() { Firstname = "Alois", 	Lastname = "Derp", 	DateOfBirth = new DateTime(1980 + 10, 1, 1), ID = 2, Phone = 222552471 });
			A.Add(new Person() { Firstname = "Arabela", Lastname = "Klik", 	DateOfBirth = new DateTime(1980 + 22, 1, 1), ID = 3, Phone = 222552471 });
			A.Add(new Person() { Firstname = "Arnold", 	Lastname = "Dupl", 	DateOfBirth = new DateTime(1980 + 46, 1, 1), ID = 4, Phone = 222552471 });
			E.Add(new Person() { Firstname = "Eda", 	Lastname = "Sypal", DateOfBirth = new DateTime(1980 + 20, 1, 1), ID = 5, Phone = 22552471 });
			E.Add(new Person() { Firstname = "Emma", 	Lastname = "Sokl", 	DateOfBirth = new DateTime(1980 + 12, 1, 1), ID = 6, Phone = 222552471 });
			E.Add(new Person() { Firstname = "Ego",	 	Lastname = "PCod", 	DateOfBirth = new DateTime(1980 + 18, 1, 1), ID = 7, Phone = 222552471 });
			grouped.Add(A); 
			grouped.Add(E);
			//vypis skupin a kontaktu do Listviev
			PeopleListViewFormatted.ItemsSource = grouped;
		

		}

		/// <summary>
		/// Odkaz na stránku přidání nového uživatele
		/// </summary>
		/// <returns>-------</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void pridat(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new NewPerson());
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

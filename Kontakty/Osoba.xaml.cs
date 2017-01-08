using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Kontakty
{
	public partial class Osoba : ContentPage
	{
		public Osoba()
		{
			List<Osoba> osoba = new List<Osoba>();
			for (int i = 0; i < 10; i++) persons.Add(new Person() { Lastname = "Jméno" + i, Firstname = "Přijmení" + i, DateOfBirth = new DateTime(1980+i,1,1) });
			PeopleListViewNotFormatted.ItemsSource = persons;

			InitializeComponent();
		}
	}
}

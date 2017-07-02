using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Kontakty
{
    public partial class Cat : ContentPage
    {
        public Cat()
        {
            InitializeComponent();

			var dbConnection = App.Database;
			PersonDatabase personDatabase = App.Database;



			ListViewFormatted.ItemsSource = App.Database.GetKategorieAsync().Result;
        }

		/// <summary>
		/// Otevření stránky s detailem po kliknutí
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void SelectedItemMethod(object sender, ItemTappedEventArgs e)
		{
			//vytvoření var s info o uživately
            Kategorie kate = e.Item as Kategorie;

            Vazebni vazebni = new Vazebni();
            vazebni.ID_kategorie = kate.ID;
            vazebni.ID_kontaktu = App.person.ID;
			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db uživatelu
			PersonDatabase userDatabase = App.Database;
			//přikaz smaž
            App.Database.SaveVazebniAsync(vazebni);
            Navigation.PopModalAsync();

		}

		void back(object sender, EventArgs args)
		{
			Navigation.PopModalAsync();
		}
    }
}

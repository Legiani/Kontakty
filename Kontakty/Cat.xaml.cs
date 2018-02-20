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

            Navigation.PopModalAsync();

		}

		void back(object sender, EventArgs args)
		{
			Navigation.PopModalAsync();
		}
    }
}

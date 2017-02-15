using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kontakty
{
	public partial class Edit : ContentPage
	{
		public Edit()
		{
			InitializeComponent();

			//vložení informací do zobrazení XAML
			jmeno.Text = App.person.Firstname;
			prijmeni.Text = App.person.Lastname;
			dateOfBird.SetValue(DatePicker.MaximumDateProperty, App.person.DateOfBirth);
			phone.Text = App.person.Phone.ToString();
		}

		void save(object sender, EventArgs args)
		{
			App.person.Firstname = jmeno.Text;
			App.person.Lastname = prijmeni.Text;
			App.person.DateOfBirth = dateOfBird.Date;
			App.person.Phone = Convert.ToInt32(phone.Text);

			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db uživatelu
			PersonDatabase userDatabase = App.Database;
			//přikaz smaž
			App.Database.SaveItemAsync(App.person);
			//čekej pro stabilitu
			Task.Delay(1);
			//vrat se na domovskou obrazovku
			Navigation.PopModalAsync();
		}
	}
}

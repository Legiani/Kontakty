using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kontakty
{
	public partial class NewPerson : ContentPage
	{
		public NewPerson()
		{
			InitializeComponent();
			//načtení aktualniho data
			dateOfBird.SetValue(DatePicker.MaximumDateProperty, DateTime.Now);
		}

		public void ulozit(object sender, EventArgs args)
		{
			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db uživatelu
			PersonDatabase userDatabase = App.Database;

			//list pro dočasne uložení
			Person item = new Person();
			item.DateOfBirth = dateOfBird.Date;
			item.Firstname = jmeno.Text;
			item.Phone = Convert.ToInt32(phone.Text);
			item.Lastname = prijmeni.Text;

			//zapis dat do db
			App.Database.SaveItemAsync(item);
			//počkej pro stabilitu
			Task.Delay(3);
			//vrat se na domovskou obrazovku
			Navigation.PopModalAsync();
			 // Seems to work most of the time with a delay as short as 2 ms, but delay of 1 or zero consistently fails
			//await Navigation.PopModalAsync(true);

		}

	}
}

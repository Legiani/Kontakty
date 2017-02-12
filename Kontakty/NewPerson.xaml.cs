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
			dateOfBird.SetValue(DatePicker.MaximumDateProperty, DateTime.Now);
		}

		public void ulozit(object sender, EventArgs args)
		{
			var dbConnection = App.Database;
			PersonDatabase userDatabase = App.Database;

			Person item = new Person();
			item.DateOfBirth = dateOfBird.Date;
			item.Firstname = jmeno.Text;
			item.Phone = Convert.ToInt32(phone.Text);
			item.Lastname = prijmeni.Text;

			App.Database.SaveItemAsync(item);

			Navigation.PushModalAsync(new PeopleList());

		}

	}
}

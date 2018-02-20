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
			
			//vrat se na domovskou obrazovku
			Navigation.PopModalAsync();
			 // Seems to work most of the time with a delay as short as 2 ms, but delay of 1 or zero consistently fails
			//await Navigation.PopModalAsync(true);

		}

	}
}

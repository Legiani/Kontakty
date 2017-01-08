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

		}

		public async void ulozit(object sender, EventArgs args)
		{
			await this.Navigation.PushAsync(new PeopleList());

		}

	}
}

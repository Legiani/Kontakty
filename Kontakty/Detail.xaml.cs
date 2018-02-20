using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.Messaging;
using Xamarin.Forms;

namespace Kontakty
{
	/// <summary>
	/// Stranka s detajlem kontaktu
	/// </summary>
	public partial class Detail : ContentPage
	{
        string s;
		//constructor pro přijem infa o kontaktu
		public Detail()
		{
			InitializeComponent();

			//vložení informací do zobrazení XAML
			//jmeno.Text = App.person.Firstname;
			//prijmeni.Text = App.person.Lastname;
			//narozen.Text = App.person.DateOfBirth.ToString("dd MMMMM yyyy");
			//vek.Text = App.person.Age.ToString();
			//phone.Text = App.person.Phone.ToString();

		}

		protected override void OnAppearing()
		{


		}

		//funkce pro volání z app
		void Call(object sender, EventArgs args)
		{
			//Device.OpenUri(new Uri("tel://"+this.user.Phone));
			var phoneDialer = CrossMessaging.Current.PhoneDialer;
			//if (phoneDialer.CanMakePhoneCall)
				//phoneDialer.MakePhoneCall(string.Format("+420{0}", App.person.Phone));
		}

		void delete(object sender, EventArgs args)
		{
			
			//vrat se na domovskou obrazovku
			Navigation.PopToRootAsync();
		}

		void edit(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new Edit());
		}





	}
}

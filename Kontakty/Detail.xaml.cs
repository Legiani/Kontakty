using System;
using Plugin.Messaging;
using Xamarin.Forms;

namespace Kontakty
{
	/// <summary>
	/// Stranka s detajlem kontaktu
	/// </summary>
	public partial class Detail : ContentPage
	{
		//Info kontaktu
		Person user;

		//constructor pro přijem infa o kontaktu
		public Detail(Person user)
		{
			InitializeComponent();
			this.user = user;

			//vložení informací do zobrazení XAML
			jmeno.Text = this.user.Firstname;
			prijmeni.Text = this.user.Lastname;
			narozen.Text = this.user.DateOfBirth.ToString("dd MMMMM yyyy");
			vek.Text = this.user.Age.ToString();
			phone.Text = this.user.Phone.ToString();
		}

		//funkce pro volání z app
		void Call(object sender, EventArgs args)
		{
			//Device.OpenUri(new Uri("tel://"+this.user.Phone));
			var phoneDialer = CrossMessaging.Current.PhoneDialer;
			if (phoneDialer.CanMakePhoneCall)
				phoneDialer.MakePhoneCall(string.Format("+420{0}", user.Phone));
		}



	}
}

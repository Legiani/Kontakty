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
            jmeno.Text = App.person.name;
            //prijmeni.Text = App.person.surname;
            //dateOfBird.SetValue(DatePicker.MaximumDateProperty, App.person.birthn);
			//phone.Text = App.person.Phone.ToString();
		}

		void save(object sender, EventArgs args)
		{
            App.person.name = jmeno.Text;

			//vrat se na domovskou obrazovku
			Navigation.PopModalAsync();
		}
	}
}

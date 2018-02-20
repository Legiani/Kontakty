using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kontakty
{
	public partial class PeopleList : ContentPage
	{
		public PeopleList()
		{
			InitializeComponent();
			fill();
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();

			fill();

		}

		/// <summary>
		/// Odkaz na stránku přidání nového uživatele
		/// </summary>
		/// <returns>-------</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void pridat(object sender, EventArgs args)
		{
			fill();
			
		}

		/// <summary>
		/// Otevření stránky s detailem po kliknutí
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public async void SelectedItemMethod(object sender, ItemTappedEventArgs e)
		{
			fill();
			//vytvoření var s info o uživately
			App.person = e.Item as Person;
			//otevře novou stranku
			await Task.Delay(3);
			await Navigation.PushAsync(new Detail());
		}

		/// <summary>
		/// Napln ListView kontakty
		/// </summary>
		public void fill() { 
          

            Task<HttpResponseMessage> secndJson = GetTheGoodStuff(id.Text);
            var code = secndJson.Result.EnsureSuccessStatusCode().StatusCode;
            //System.Diagnostics.Debug.WriteLine(code);
            if (code.ToString() != "OK"){
                DisplayAlert("Alert", "Error code: "+code, "OK");
            }
                
            using (HttpContent content = secndJson.Result.Content)
            {
                var json = content.ReadAsStringAsync().Result;
                
                System.Diagnostics.Debug.WriteLine(json);
                if (  json == "[]"  )            {
                    DisplayAlert("Alert", "Nikdo tam nebidlí :-) " + code, "OK");
                }
                else
                {
                    PeopleListViewFormatted.ItemsSource = JsonConvert.DeserializeObject<List<Person>>(json);
                }


                //var dbConnection = App.Database;
                //PersonDatabase personDatabase = App.Database;

                //foreach (var item in JsonConvert.DeserializeObject<List<Person>>(json))
                //{
                //    App.Database.SaveItemAsync(item);
                //}
            }

		}



        public Task<HttpResponseMessage> GetTheGoodStuff(string data = "1")
        {
            var httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/comments?postId=" + data);
            var response = httpClient.SendAsync(request);
            return response;
        }



	}
}

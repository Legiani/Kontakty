using Xamarin.Forms;

namespace Kontakty
{
	public partial class App : Application
	{
		public static Person person;

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new PeopleList());

		}


		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		private static PersonDatabase _database;

		public static PersonDatabase Database
		{
			get
			{
				if (_database == null)
				{
					_database = new PersonDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("Konty.db3"));
				}
				return _database;
			}
		}
	}
}

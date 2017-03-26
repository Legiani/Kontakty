using System;
using System.IO;
using Kontakty;
using Kontakty.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace Kontakty.Droid
{
	public class FileHelper : IFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			return Path.Combine(path, filename);
		}
	}
}
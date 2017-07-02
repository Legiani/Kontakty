using System;
using System.Collections.ObjectModel;
using SQLite;

namespace Kontakty
{
	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public int Phone { get; set; }
		public string Lastname { get; set; }
		public string Firstname { get; set; }
        public int Cedulka { get; set; }

		public int Age
		{
			get { return DateTime.Now.Year - DateOfBirth.Year; }
		}
		public DateTime DateOfBirth { get; set; }

		public string GetName => Lastname + " " + Firstname;

		public override string ToString()
		{
			return Firstname + " " + Lastname + " " + Age + " " + Phone;
		}
	}
}

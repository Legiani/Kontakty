using System;
using SQLite;

namespace Kontakty
{
    public class Kategorie
    {
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Nazev { get; set; }
    }
}

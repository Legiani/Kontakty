using System;
using SQLite;

namespace Kontakty
{
    public class Vazebni
    {
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public int ID_kategorie { get; set; }
		public int ID_kontaktu { get; set; }
    }
}

using System;
namespace Kontakty
{
	public class Osoba
	{
		private string jmeno;
		private string prijmeni;
		private DateTime datumNarozeni;

		public string CeleJmeno => Jmeno + " " + Prijmeni;
		public int Vek
		{
			get { return DateTime.Now.Year - DatumNarozeni.Year; }
		}



		public string Jmeno
		{
			get
			{
				return jmeno;
			}

			set
			{
				jmeno = value;
			}
		}

		public string Prijmeni
		{
			get
			{
				return prijmeni;
			}

			set
			{
				prijmeni = value;
			}
		}

		public DateTime DatumNarozeni
		{
			get
			{
				return datumNarozeni;
			}

			set
			{
				datumNarozeni = value;
			}
		}

		public override string ToString()
		{
			return string.Format("[Osoba: CeleJmeno={0}, Vek={1}]", CeleJmeno, Vek);
		}
	}
}

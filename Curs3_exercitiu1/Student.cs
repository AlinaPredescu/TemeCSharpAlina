using System;

namespace Curs3_exercitiu1
{
	//internal poate fi folosita doar in acest proiect
	//public pot apela si in celelalte proiecte
	public class Student
	{
		public string nume;
		public string prenume;
		//numele si prenumele sunt publice, in interiorul programului, unde am definit studentul s1 o sa am acces la proprietatae lui nume
		private string cnp;
	//nu-l vede toata lumea, la fel si daca pun modificatorul protected in loc de private

	}
}


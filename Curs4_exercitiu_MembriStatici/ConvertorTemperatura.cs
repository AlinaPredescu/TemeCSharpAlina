using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Curs4_exercitiu_MembriStatici
{
	static class ConvertorTemperatura
	{
		private static float conversieCtoK = 273.15F;
		public static float  ConvertCelsiusToKelvin(float temperaturaCelsius)
		{
			return temperaturaCelsius + conversieCtoK;
		}

		public static float ConvertCelsiusToFahrenheit(float temperaturaCelsius)
		{
			return temperaturaCelsius * 18 / 10 + 32;
		}

		public static float ConvertKelvinToCelsius(float temperaturaKelvin)
		{
			return temperaturaKelvin - conversieCtoK;
		}

	}
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace C__Operators_Types_conversions
{
	internal class Program
	{
		static void Main(string[] args)
		{
		//https://forum.sources.ru/index.php?showtopic=268911
		//https://ru.stackoverflow.com/questions/966970/c-%D0%BD%D0%B5-%D0%B2%D1%8B%D0%B2%D0%BE%D0%B4%D0%B8%D1%82-%D0%B2%D1%81%D0%B5-%D1%81%D0%B8%D0%BC%D0%B2%D0%BE%D0%BB%D1%8B-%D0%BA%D0%BE%D1%82%D0%BE%D1%80%D1%8B%D0%B5-%D0%BD%D1%83%D0%B6%D0%BD%D0%BE-%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D0%BE%D0%B2%D0%B0%D1%82%D1%8C

			Byte[] recived_Symbol_Code = new Byte [1];

			for (int i = 0; i < 256; i++)
			{
				if (i % 10 == 0)
				{
					Console.WriteLine();
				}
				recived_Symbol_Code[0] = Convert.ToByte(i);
				String str = Encoding.GetEncoding(866).GetString(recived_Symbol_Code);
				Console.Write("["+i+"]" + " = "+str+" ");
			}
			Console.WriteLine();

			//Console.WriteLine();
			//Byte[] recivedBytes = new Byte[] { 208 };
			//String str = Encoding.GetEncoding(866).GetString(recivedBytes);
			//Console.WriteLine(str);

		}
	}
}

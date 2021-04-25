using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			uint n;
			Console.Write("Enter n:");
			n = uint.Parse(Console.ReadLine());

			double product = 1;
			if (n % 2 == 0)
			{
				for (int i = 2; i <= n; i += 2)
				{
					product *= i;
				}
			}
			else
			{
				for (int i = 1; i <= n; i += 2)
				{
					product *= i;
				}
			}
			Console.Write("product =: "+ product);
			Console.ReadKey();


		}
	}
}


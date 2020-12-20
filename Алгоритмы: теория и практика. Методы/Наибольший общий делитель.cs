using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {		
		public static void Main()
		{
			string[] vs = Console.ReadLine().Split();
			ulong a = Convert.ToUInt64(vs[0]);
			ulong b = Convert.ToUInt64(vs[1]);

			while(a != 0 && b != 0)
            {
				if (a > b)
					a %= b;
				else
					b %= a;
            }

			Console.WriteLine(a + b);
		}
	}
}

using System;
using System.Collections.Generic;

namespace ADOPM3_04_02
{
    class Program
    {
		static IEnumerable<int> Fibs(int fibCount)
		{
			for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
			{
				yield return prevFib;
				int newFib = prevFib + curFib;
				prevFib = curFib;
				curFib = newFib;
			}
		}
		static IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
		{
			foreach (int x in sequence)
				if ((x % 2) == 0)
					yield return x;
		}
		static void Main(string[] args)
        {
			foreach (int fib in Fibs(15))
				Console.WriteLine(fib);

            Console.WriteLine();
			foreach (int fib in EvenNumbersOnly(Fibs(15)))
				Console.WriteLine(fib);
			
		}
	}
	//Exercise:
	//1.	Go through the code with the debugger step by step and explore what happens. Particular around the yield return statment.
	//		Explore variables as you debug. Discuss in the group so you understand the flow. Explain
}

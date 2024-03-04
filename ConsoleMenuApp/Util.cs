using System;
namespace ConsoleMenuApp
{
	public class Util
	{
		public Util()
		{
		}

		static public void wait() {

			Thread.Sleep(1000);
		}

		static public void drawLine() {

			for (int index = 0; index < 10; index++) {
				Console.Write("*");
				Thread.Sleep(40);
			}

			Console.WriteLine("\n");
		}


    }
}


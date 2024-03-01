using System;
using System.Reflection;

namespace ConsoleMenuApp
{
	public class TextEcho
	{
		string text { get; set; }

		public TextEcho()
		{
        }

		public void GetUserInput() {

			Console.WriteLine("please enter any text");
            text = Console.ReadLine();
		}

		public void showEcho() {

			GetUserInput();

            for (int index = 0; index < 10; index++)
            {

                Console.Write($"{index}." + text + "  ");
            }

			Console.WriteLine("");
        }
    }
}


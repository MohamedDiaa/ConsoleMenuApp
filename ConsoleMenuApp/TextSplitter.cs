using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleMenuApp
{
    public class TextSplitter
    {
        string text { get; set; }

        public TextSplitter()
        {
            text = "";
        }

        public string GetUserInput()
        {

            Console.WriteLine("please enter any text consiste of 3 words with space between");
            text = Console.ReadLine();


            string[] subtext = text.Split(' ', '\t');

            if (isValid(subtext)) {

                return subtext[2];
            }

            return "Please enter valid text";
        }


        bool isValid(string[] subtext) {

            return subtext.Length >= 3;
        }
    }
}


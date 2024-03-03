using System;

namespace ConsoleMenuApp
{
    public class Menu
    {

        string[] menuOtpions = {
                "0 - Quit",
                "1 - Ungdom eller pensionär",
                "2 - total price",
                "3 - Upprepa tio gånger",
                "4 - Det tredje ordet" };

        TextEcho textEcho = new TextEcho();
        TextSplitter splitter = new TextSplitter();

        public Menu()
        {

        }


        public void showMainMenu() {

            bool quit = false;

            do
            {
                Console.WriteLine("Select Menu number");
                showMenuOptions();

                int.TryParse(Console.ReadLine(), out int value);

                if (value == 0)
                {
                    quit = true;
                    Console.WriteLine("Thanks for coming");
                }
                else if (value == 1) {
                    showTicketPrice();
                }
                else if (value == 2)
                {
                    showTicketPrice();
                }

                else if (value == 3)
                {
                    textEcho.showEcho();
                }

                else if (value == 4)
                {
                    string result = splitter.GetUserInput();
                    Console.WriteLine(result);
                }


                Util.drawLine();

            }
            while (!quit);
        }


        public void showMenuOptions() {

            foreach (string option in menuOtpions) {

                Console.WriteLine(option);
            }
        }


        public void showTicketPrice() {

            TicketPrice ticketPrice = new TicketPrice();
            string result = ticketPrice.GetFormattedTicketPrice();
            Console.WriteLine(result);
        }
    }
}


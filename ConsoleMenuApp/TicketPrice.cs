using System;
namespace ConsoleMenuApp
{

    public class TicketCheckout
    {

        public enum AgeGroup
        {
            ungdom,
            pension,
            normal
        }

        const double ungdomPris = 80;
        const double pensionsPris = 90;
        const double normalPris = 120;

        public TicketCheckout()
        {
        }

        public double GetUserAge()
        {
            Console.WriteLine("Enter your age");
            _ = double.TryParse(Console.ReadLine(), out double age);

            return age;
        }

        public double GetUserTicketPrice()
        {

            double age = GetUserAge();
            double price = PriceForAge(age);

            return price;
        }

        public string GetFormattedTicketPrice()
        {

            double age = GetUserAge();
            double price = PriceForAge(age);

            if (age < 20)
            {
                return $"ungdompris {price}";
            }
            else if (age > 64)
            {
                return $"pensionärpris {price}";
            }
            else
            {
                return $"pris {price}";
            }
        }


        public double PriceForAge(double age)
        {

            if (age < 20)
            {
                return TicketCheckout.ungdomPris;
            }
            else if (age > 64)
            {
                return TicketCheckout.pensionsPris;
            }
            else
            {
                return TicketCheckout.normalPris;
            }
        }


        public void getTotalPriceForGroupOfCustomers()
        {

            Console.WriteLine("please enter number of customers");
            string input = Console.ReadLine();

            int.TryParse(input, out int count);

            Console.WriteLine("please enter age of each user followed by enter");

            double result = 0;

            for (int i = 1; i <= count; i++) {

                Console.WriteLine($"age of customer {i}");
                string inputage = Console.ReadLine();
                double.TryParse(inputage, out double userAge);

                double price = PriceForAge(userAge);

                result += price;
            }


            Console.WriteLine($"total price for the {count} customers are {result} SEK");

        }

    }
}


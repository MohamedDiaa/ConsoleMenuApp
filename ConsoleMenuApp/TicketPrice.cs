using System;
namespace ConsoleMenuApp
{

    public class TicketPrice
    {

        public enum AgeGroup
        {
            ungdom,
            pension,
            normal
        }

        const int ungdomPris = 80;
        const int pensionsPris = 90;
        const int normalPris = 120;

        public TicketPrice()
        {
        }



        public int GetUserAge() {


            Console.WriteLine("Enter your age");
            _ = int.TryParse(Console.ReadLine(), out int age);

            return age;
        }

        public int GetUserTicketPrice()
        {

            Console.WriteLine("Enter your age");
            _ = int.TryParse(Console.ReadLine(), out int age);

            AgeGroup ageGroup = AgeGroupCalculation(age);
            int price = PrisforAgeGroup(ageGroup);

            return price;
        }


        public int PrisforAgeGroup(AgeGroup ageGroup)
        {

            switch (ageGroup)
            {

                case AgeGroup.ungdom:
                    return TicketPrice.ungdomPris;
                case AgeGroup.pension:
                    return TicketPrice.pensionsPris;
                case AgeGroup.normal:
                    return TicketPrice.normalPris;
                default:
                    return 0;

            }
        }


        public string GetFormattedTicketPrice()
        {

            int age = GetUserAge();
            AgeGroup group = AgeGroupCalculation(age);
            int price = PrisforAgeGroup(group);

            switch (group)
            {

                case AgeGroup.ungdom:
                    return $"ungdompris {price}";
                case AgeGroup.pension:
                    return $"pensionärpris {price}";
                default:
                    return $"pris {price}";
            }
        }

        public AgeGroup AgeGroupCalculation(int age)
        {

            if (age < 20)
            {
                return AgeGroup.ungdom;
            }
            else if (age > 64)
            {
                return AgeGroup.pension;
            }
            else
            {
                return AgeGroup.normal;
            }
        }
    }
}


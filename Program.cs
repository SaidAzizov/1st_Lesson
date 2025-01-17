using System;
namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */

            #region task№1
            // 1. Find your BMI - body mass index
            Console.WriteLine("Task #1");
            double currentWeight;
            int currentHeight;

            while (true)
            {
                Console.Write("    Enter your weight (kilograms): ");
                if (!double.TryParse(Console.ReadLine(), out currentWeight))
                {
                    Console.WriteLine("    Something wrong with given weight...");
                }
                if (currentWeight <= 0  &&  currentWeight <= 300)
                {
                    Console.WriteLine("    Weight have to be greater than 0 and smaller than 300kg. Try again...");
                    continue;
                }
                break;
            }
            
            while (true)
            {
                Console.Write("    Enter your height (centimeter): ");
                if (!int.TryParse(Console.ReadLine(), out currentHeight))
                {
                    Console.WriteLine("    Something wrong with given height...");
                }
                if (currentHeight <= 0 && currentHeight <= 270)
                {
                    Console.WriteLine("    Height have to be greater than 0 and smaller than 270cm. Try again...");
                    continue;
                }
                break;
            }
                

            double heightSquared = currentHeight / 100.0;
            heightSquared = heightSquared * heightSquared;

            // BMI = kg / m^2; where kg - weight in kilograms and m is a heigth in sentimeters
            double BMI = Math.Round(currentWeight / heightSquared, 2);
            Console.WriteLine($"    asnwer: Your BMI = {BMI}");
            #endregion

            #region task№2
            /* 
             * 2. Find the length of the ellipse sector curve with:
             * a = 100 % (№ in the group)
             * b = age - (a / № in the group)
             * grad = 10 * (№ in the group)
            */
            Console.WriteLine("Task #2");
            double a = 100 % 17;
            double b = 17 - (a / 17);
            double grad = 10 * 17;

            //double sectorLength = (a + b) * Math.PI * (degree / 360);
            Console.WriteLine($"    answer: {Math.Round((a + b) * Math.PI * (grad / 360), 2)}");

            #endregion

            #region task№3
            /*
             * 3.Find the step(d) and nth term of an Arithmetic Sequence when:
             * a0 = (№ in the group)
             * S = 1ddmm of your birth day
             */
            Console.WriteLine("Task #3");
            int first_elem = 17;
            int s = 13009;
            int cnt;
            while (true)
            {
                Console.Write("    Enter cnt: ");
                if (!int.TryParse(Console.ReadLine(), out cnt))
                {
                    Console.WriteLine("    Something wrong with given data...");
                    continue;
                }
                break;
            }
            int last_elem = (s / cnt) * 2 - first_elem;
            double step = (last_elem - first_elem) / cnt;
            Console.WriteLine($"   Last element: {last_elem}\n    Step: {step}");
            #endregion
        }
    }
}

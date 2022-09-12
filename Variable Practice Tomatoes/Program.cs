// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string crop = "tomato";
            int numPlants = 5;
            int acres = 15;
            char firstChar = 'l';
            char secondChar = 'o';
            char thirdChar = 'n';
            char fourthChar = 'g';
            bool isRipe = false;
            double growingPeriod = 1.5;
            const decimal sfInAcre = 43560;

            Console.WriteLine($"We have been waiting a {firstChar}{secondChar}{thirdChar}{fourthChar} time to grow plants.");
            Console.WriteLine($"This year, we have planted {numPlants} {crop} plants.");
            Console.WriteLine($"Are the tomatoes ready? {isRipe}");
            Console.WriteLine($"We have to wait {growingPeriod} months for the first {crop}es.");
            Console.WriteLine($"We have {acres} acres of land; that's {sfInAcre} feet per acre.");
            Console.WriteLine($"In total, we have {acres * sfInAcre} square feet to work with.");
        }
    }
}

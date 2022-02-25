using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Collections_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> carsBrandsCountries = new Dictionary<string, string>();

            carsBrandsCountries.Add("Ауди", "Германия");
            carsBrandsCountries.Add("Лада", "Россия");

            string userInput;
            bool canExit = false;

            while (canExit == false)
            {
                Console.Write("Введите марку авто или введите exit для выхода: ");
                userInput = Console.ReadLine();

                if (carsBrandsCountries.ContainsKey(userInput))
                    Console.WriteLine(carsBrandsCountries[userInput]);

                if (userInput == "exit")
                    canExit = true;
                
                else
                    Console.WriteLine("Этого нет в словаре");
            }
        }
    }
}

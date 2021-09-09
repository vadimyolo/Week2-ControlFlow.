using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada (tingimuseks 18 aastat vana.)


            Console.WriteLine("Tere, mis on sinu sünniaasta?");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int age = 2021 - YearOfBirth;
            Console.WriteLine("Oled praeguseks ajaks " + age);
            if (age > 18)
            {
                Console.WriteLine("Oled piisavalt vana ning saate juhiluba teha.");
            }
            else if (age < 18)
            {
                Console.WriteLine("Oled veits noor et juhiluba saada.");
            }

            Console.WriteLine("Kenat päeva jätku!");

        }
    }
}

using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasitaja vanust.
            //kui kasutaja on vanem ,kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem kui 18, konsoolis kuvatatakse "oled liiga noor."
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18."
            Console.WriteLine("Tere, mis on teie nimi?");

            string FirstName = Console.ReadLine();

            Console.WriteLine($"Tore tutvuda {FirstName}");

            Console.WriteLine($"Kui vana sa oled {FirstName}?");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Oled piisavalt vana.");
            }
            else if (age < 18)
            {
                Console.WriteLine("Oled veits noor.");
            }    
            else
            {
                Console.WriteLine("Oledki 18-st.");
            }
          

            

        }
    }
}

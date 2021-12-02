using System;

namespace Test_for_Teamfloaternational_by_Valeriia_Demydova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate x of dot A:");
            string input = Console.ReadLine();
            float xOfA = float.Parse(input);
            Console.WriteLine("Enter coordinate y of dot A:");
            input = Console.ReadLine();
            float yOfA = float.Parse(input);
            Console.WriteLine("Enter coordinate x of dot B:");
            input = Console.ReadLine();
            float xOfB = float.Parse(input);
            Console.WriteLine("Enter coordinate y of dot B:");
            input = Console.ReadLine();
            float yOfB = float.Parse(input);
            Console.WriteLine("Enter coordinate x of dot C:");
            input = Console.ReadLine();
            float xOfC = float.Parse(input);
            Console.WriteLine("Enter coordinate y of dot C:");
            input = Console.ReadLine();
            float yOfC = float.Parse(input);

            double AB = Math.Sqrt(Math.Pow(xOfB - xOfA, 2) + Math.Pow(yOfB - yOfA, 2));
            double BC = Math.Sqrt(Math.Pow(xOfC - xOfB, 2) + Math.Pow(yOfC - yOfB, 2));
            double CA = Math.Sqrt(Math.Pow(xOfA - xOfC, 2) + Math.Pow(yOfA - yOfC, 2));
            
            double perimeter = AB + BC + CA;
            bool flag = false;


            Console.WriteLine($"Length of AB is: {AB}  \nLength of BC is: {BC} \nLength of CA is: {CA}");

            if (AB == BC && BC == CA && CA == AB)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else 
            { 
                Console.WriteLine("The triangle is NOT equilateral.");
            }

            if (AB == BC || BC == CA || CA == AB)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is NOT isosceles.");
            }

            if (AB > BC && AB > CA)
            {
                if (Math.Round(AB) == Math.Round(Math.Sqrt(BC * BC + CA * CA)))
                {
                    flag = true;
                    Console.WriteLine("The triangle is right.");
                }    
            }
            if (BC > AB && BC > CA)
            {
                if (Math.Round(BC) == Math.Round(Math.Sqrt(AB * AB + CA * CA)))
                {
                    flag = true;
                    Console.WriteLine("The triangle is right.");
                }
            }
            if (CA > AB && CA > BC)
            {
                if (Math.Round(CA) == Math.Round(Math.Sqrt(AB * AB + BC * BC)))
                {
                    flag = true;
                    Console.WriteLine("The triangle is right.");
                }
            }
            if(!flag)
            {
                Console.WriteLine("The triangle is NOT right.");
            }

            Console.WriteLine("Perimeter: " + perimeter);
            for (int i = 0; i < perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

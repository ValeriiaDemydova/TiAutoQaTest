using System;


public class Triangle
{
    private float xA;
    private float yA;
    private float xB;
    private float yB;
    private float xC;
    private float yC;
    public double AB;
    public double BC;
    public double CA;
    double perimeter;

    public void InputCoordinates()
    {
        try
        {
            Console.WriteLine("Enter coordinate x of dot A:");
            xA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            yA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B:");
            xB = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            yB = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C:");
            xC = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            yC = float.Parse(Console.ReadLine());

            InitAndShowSizes();
            PrintIsEquilateeral();
            PrintIsIsosceles();
            PrintIsRight();
            CalcAndPrintPerimiter();
            PrintEvenNumbers();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Some error occured: {ex}");
        }
    }

    private void CheckWrongValues()
    {
        if (AB == 0 || BC == 0 || CA == 0)
        {
            throw new Exception("Haha! Nice try ;) Sides can not be equal 0! Try again.");
            
        }
    }

    private void InitAndShowSizes()
    {
         AB = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
         BC = Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2));
         CA = Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2));

        Console.WriteLine($"Length of AB is: {AB}  \nLength of BC is: {BC} \nLength of CA is: {CA}");

        CheckWrongValues();
    }

    private void PrintIsEquilateeral()
    {
        if (AB == BC && BC == CA && CA == AB)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else
        {
            Console.WriteLine("The triangle is NOT equilateral.");
        }
    }

    private void PrintIsIsosceles()
    {
        if (AB == BC || BC == CA || CA == AB)
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is NOT isosceles.");
        }
    }
    private void PrintIsRight()
    {
        bool flag = false;

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
        if (!flag)
        {
            Console.WriteLine("The triangle is NOT right.");
        }
    }
    private void CalcAndPrintPerimiter()
    {
        perimeter = AB + BC + CA;
        Console.WriteLine("Perimeter: " + perimeter);
    }
    private void PrintEvenNumbers()
    {
        for (int i = 0; i < perimeter; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}


using System;

class Program
{

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        bool tub = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                tub = false;
                break;
            }
        }

        if (tub && num > 1)
        {
            Console.WriteLine("Tub");
        }
        else
        {
            Console.WriteLine("Tub emas");
        }
    }


    static void Main2()
    {
        int number = int.Parse(Console.ReadLine());
        string Boluvchi = "";

        for (int i = 2; i <= 10; i++)
        {
            if (number % i == 0)
            {
                Boluvchi += i + ", ";
            }
        }

        if (Boluvchi.Length > 0)
        {
            Console.WriteLine("Bo'luvchilari: " + Boluvchi.TrimEnd(',', ' '));
        }
        else
        {
            Console.WriteLine("Bo'luvchilari yo'q.");
        }
    }

    static void Main3()
    {
        int son = int.Parse(Console.ReadLine());
        int daraja = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i <= daraja; i++)
        {
            result *= son;
        }

        Console.WriteLine(result);

    }
    static void Main4()
    {
        string[] inputs = Console.ReadLine().Split(",");
        int sum = 0;

        foreach (var input in inputs)
        {
            sum += int.Parse(input.Trim());
        }

        Console.WriteLine(sum);
    }

    static void Main5()
    {
      
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int sum = 0;
            int digits = number.ToString().Length;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

        if (sum == number)
        {
            Console.WriteLine(number + " Armstrong son");
        }
        else
        { 
            Console.WriteLine(number + " Armstrong son emas");
        }
    }

    static void Main6()
    {
        int number = int.Parse(Console.ReadLine());
        int soncha = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                soncha++;
            }
        }

        Console.WriteLine(soncha);
    }

}
        

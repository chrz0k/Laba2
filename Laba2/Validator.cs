internal class Validator
{
    public int ReadInt(string promt)
    {
        Console.Write(promt);
        while (true)
        {
            string? inputString = Console.ReadLine();
            if (int.TryParse(inputString, out int result))
            {
                return result;
            }

            Console.WriteLine("Ошибка!");
            Console.Write(promt);
        }
    }

    public int ReadInt(string promt, int min, int max)
    {
        Console.Write(promt);
        while (true)
        {
            string? inputString = Console.ReadLine();
            if (int.TryParse(inputString, out int result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
            }

            Console.WriteLine("Ошибка!");
            Console.Write(promt);
        }
    }

    public double ReadDouble(string promt)
    {
        Console.Write(promt);
        while (true)
        {
            string? inputString = Console.ReadLine();
            if (double.TryParse(inputString, out double result))
            {
                return result;
            }

            Console.WriteLine("Ошибка!");
            Console.Write(promt);
        }
    }

    public double ReadDouble(string promt, double min, double max)
    {
        Console.Write(promt);
        while (true)
        {
            string? inputString = Console.ReadLine();
            if (double.TryParse(inputString, out double result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
            }

            Console.WriteLine("Ошибка!");
            Console.Write(promt);
        }
    }

    public int ReadChar(string promt)
    {
        Console.Write(promt);
        while (true)
        {
            string? inputString = Console.ReadLine();
            if (char.TryParse(inputString, out char result))
            {
                return result;
            }

            Console.WriteLine("Ошибка!");
            Console.Write(promt);
        }
    }

}
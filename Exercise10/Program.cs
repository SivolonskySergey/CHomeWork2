
    void SecondDigit() 
    {
        Random random = new Random();
        int number = random.Next(100, 1000);
        Console.WriteLine(number);
        Console.WriteLine((number / 10) % 10);
    }
    SecondDigit();



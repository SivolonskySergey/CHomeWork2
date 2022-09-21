void thirdDigit() {
    Console.WriteLine("Введите любое число: ");
    string num = Console.ReadLine();
    int lengthOfNum = num.Length;
    int number = Convert.ToInt32(num);
    if (lengthOfNum < 3) {
        Console.WriteLine("Третьей цифры нет!");
    }
    else {
            lengthOfNum = lengthOfNum - 3;
            int divider = Convert.ToInt32(Math.Pow(10, lengthOfNum));
            number = (number / divider) % 10;
            Console.WriteLine(number);
    }
}


thirdDigit();
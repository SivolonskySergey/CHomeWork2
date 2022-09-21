void thirdDigit() {
    Console.WriteLine("Введите любое число: ");
    string num = Console.ReadLine();
    int number = Math.Abs(Convert.ToInt32(num));
    int lengthOfNum = Convert.ToString(number).Length;
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
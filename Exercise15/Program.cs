void isWeekend() {
    Console.WriteLine("Введите номер дня недели: ");
    string[] days = { " ","Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1 || num > 7) {
        Console.WriteLine("Неверный день недели, введите число от 1 до 7!");
    }
    else if(num == 6 || num == 7) {
        Console.WriteLine($"{num} это {days[num]} - Выходной день!");
    }
    else {
        Console.WriteLine($"{num} это {days[num]} - Рабочий день!");
    }
}

isWeekend();
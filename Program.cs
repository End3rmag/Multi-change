    Console.Write("Введите количество месяцев (n): ");
    
try
{
    int n = Convert.ToInt32(Console.ReadLine());


    int startYear = 1990;
    int startMonth = 1;
    int startDay = 1;

    int totalMonths = startMonth + n;
    int year = startYear + (totalMonths - 1) / 12;
    int month = (totalMonths - 1) % 12 + 1;
    int day = startDay + 2 - 1;

    if (month > 12)
    {
        month -= 12;
        year += 1;
    }

    int dayOfWeek = GetDayOfWeek(year, month, day);

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static int GetDayOfWeek(int year, int month, int day)
    {
        if (month < 3)
        {
            month += 12;
            year -= 1;
        }
        int k = year % 100;
        int j = year / 100;
        return (day + (13 * (month + 1)) / 5 + k + (k / 4) + (j / 4) - 2 * j) % 7;
    }
    Console.WriteLine($"Год: {year}");
    Console.WriteLine($"Месяц: {month}");
    Console.WriteLine($"День недели: {(DayOfWeek)dayOfWeek}");
    Console.WriteLine($"Високосный год: {IsLeapYear(year)}");
}
catch (Exception e) { Console.WriteLine("Неверный ввод даных"); }




   
    


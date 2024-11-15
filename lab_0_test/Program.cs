using System;

public class ZodiacSignCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите день месяца (1-31): ");
        int day = int.Parse(Console.ReadLine());

        string zodiacSign = GetZodiacSign(month, day);
        Console.WriteLine($"Ваш знак зодиака: {zodiacSign}");
    }

    public static string GetZodiacSign(int month, int day)
    {
        string[] zodiacSigns = { "Козерог", "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец" };
        int[] dayBoundaries = { 19, 18, 20, 19, 20, 21, 22, 22, 22, 22, 21, 21 };

        if (month < 1 || month > 12 || day < 1 || day > 31) return "Некорректная дата";

        int index = (month - 1) % 12;
        return zodiacSigns[day > dayBoundaries[index] ? (index + 1) % 12 : index];
    }
}
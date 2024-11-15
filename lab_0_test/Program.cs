using System;

public class ZodiacSignCalculator
{
    private static readonly string[] ZodiacSigns = { "Козерог", "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец" };
    private static readonly int[] DayBoundaries = { 19, 18, 20, 19, 20, 21, 22, 22, 22, 22, 21, 21 };

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер месяца (1-12):");
        if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
        {
            Console.WriteLine("Ошибка: Неверный номер месяца.");
            return;
        }

        Console.WriteLine("Введите день месяца (1-31):");
        if (!int.TryParse(Console.ReadLine(), out int day) || day < 1 || day > 31)
        {
            Console.WriteLine("Ошибка: Неверный день месяца.");
            return;
        }

        string zodiacSign = GetZodiacSign(month, day);
        Console.WriteLine($"Ваш знак зодиака: {zodiacSign}");
    }

    private static string GetZodiacSign(int month, int day)
    {
        int signIndex = (month - 1) % 12;
        return ZodiacSigns[day > DayBoundaries[signIndex] ? (signIndex + 1) % 12 : signIndex];
    }
}
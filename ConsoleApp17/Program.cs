using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значения времени
        Console.WriteLine("Введите значение времени (в формате ЧЧ:ММ:СС):");
        string input = Console.ReadLine();

        // Проверка, является ли введенное значение временем
        DateTime time;
        bool isTime = DateTime.TryParse(input, out time);

        if (isTime)
        {
            Console.WriteLine("Введенное значение является временем.");
        }
        else
        {
            Console.WriteLine("Введенное значение не является временем.");
        }

        // Ввод длительности работы посудомоечной машинки в минутах
        Console.WriteLine("Введите длительность работы посудомоечной машинки (в минутах):");
        int duration = int.Parse(Console.ReadLine());

        // Ввод времени отсрочки начала запуска программы в часах
        Console.WriteLine("Введите время отсрочки начала запуска программы (в часах):");
        int delay = int.Parse(Console.ReadLine());

        // Определение даты и времени начала мойки
        DateTime startTime = DateTime.Now.AddHours(delay);

        // Определение даты и времени окончания мойки
        DateTime endTime = startTime.AddMinutes(duration);

        // Вывод результатов
        Console.WriteLine("Дата и время начала мойки: " + startTime);
        Console.WriteLine("Дата и время окончания мойки: " + endTime);
    }
}

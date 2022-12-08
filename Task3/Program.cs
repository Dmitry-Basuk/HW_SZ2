/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
Console.WriteLine("Введите число от 1 до 7");
string dayNumber = Console.ReadLine();
if (dayNumber == "1")
Console.WriteLine("Понедельник -- будний день");
    else if (dayNumber == "2")
    Console.WriteLine("Вторник --будний день");
    else if (dayNumber == "3")
    Console.WriteLine("Среда -- будний день");
    else if (dayNumber == "4")
    Console.WriteLine("Четверг -- будний день");
    else if (dayNumber == "5")
    Console.WriteLine("Пятница -- будний день");
    else if (dayNumber == "6")
    Console.WriteLine("Суббота -- выходной день");
    else if (dayNumber == "7")
    Console.WriteLine("Воскресенье -- выходной день");
    else 
    Console.WriteLine("Неверное условие");

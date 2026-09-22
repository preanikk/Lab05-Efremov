// int number = int.Parse(Console.ReadLine());

// switch (number)
// {
//     case 1:
//         Console.WriteLine("Начало");
//         break;
//     case 2:
//         Console.WriteLine("Середина");
//         break;
//     case 3:
//         Console.WriteLine("Конец");
//         break;
//     default: 
//         Console.WriteLine("Другое значение");
//         break;
// }


// int day = int.Parse(Console.ReadLine());
// switch (day)
// {
//     case 6 or 7:
//         Console.WriteLine("Выходной");
//         break;
//     default:
//         Console.WriteLine("Будний");
//         break;
// }

// int temperature = int.Parse(Console.ReadLine());
// switch (temperature)
// {
//     case <= 0:
//         Console.WriteLine("Холодно");
//         break;
//     case >= 0 and <= 15:
//         Console.WriteLine("Прохладно");
//         break;
// }


using System.Reflection.Metadata;

// int score = 50;
// string result = score switch
// {
//     >= 91 => "Отлично",
//     >= 71 => "Хорошо",
//     >= 51 => "Удовлетворительно",
//     _ => "Неудовлетворительно",
// };
// Console.WriteLine(result);


// string role = "user";
// switch (role)
// {
//     case "admin":
//         Console.WriteLine("Полный доступ");
//         break;
//     case not "admin":
//         Console.WriteLine("Ограниченный доступ");
//         break;
// }


// int age = int.Parse(Console.ReadLine());
// bool hasTicket = true;
// switch (age)
// {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешен");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }


// int level = 2;
// switch (level)
// {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }


// // Задача А
// int month = int.Parse(Console.ReadLine());
// string season = month switch
// {
//     1 or 2 or 12 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine(season);

// // Задача Б
// int year = int.Parse(Console.ReadLine());
// string status = year switch
// {
//     < 0 => "Ошибка",
//     >= 0 and <= 6 => "Ребенок",
//     >= 7 and <= 17 => "Подросток",
//     >= 18 and <= 64 => "Взрослый",
//     >= 65 => "Пенсионер",
// };
// Console.WriteLine(status);


// //Вариант 1
// int month = int.Parse(Console.ReadLine());
// string season = month switch
// {
//     1 or 2 or 12 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine(season);


// // Вариант 6 
// string role = Console.ReadLine();
// bool acc = true;
// switch (role)
// {
//     case "admin":
//         Console.WriteLine("Полный доступ");
//         break;
//     case "teacher" when acc:
//         Console.WriteLine("Доступ преподавателя");
//         break;
//     case "teacher":
//         Console.WriteLine("Требуется подтверждение");
//         break;
//     case "user":
//         Console.WriteLine("Ограниченный доступ");
//         break;
//     default:
//         Console.WriteLine("Доступ запрещен");
//         break;
// }


int number = 2;
string chislo = number switch
{
    < 0 => "Отрицательное",
    1 or 2 or 3 => "Маленькое число",
    >= 0 and <= 9 => "Однозначное",
    >= 10 and <= 99 => "Двузначное",
    >= 100 => "Трехзначное или больше",
};
Console.WriteLine(chislo);

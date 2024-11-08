// Упр. 1. Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени.// (Создать консольное приложение.)

Console.WriteLine("Лабораторная 1 (1.1).");
Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine($"Здравствуйте, {name}!");
Console.WriteLine("");
// Упр.2. Упражнение 2. Написать программу, которой на вход подается два
// целых числа, на выходе – результат деления одного числа на другое.// Предусмотреть обработку исключительной ситуации, возникающей при делении числа на ноль.
Console.WriteLine("Лабораторная 1.2.");
try
{
    Console.Write("Введите первое число: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = int.Parse(Console.ReadLine());
    int result = num1 / num2;
    Console.WriteLine($"Результат деления: {result}");
}
catch (DivideByZeroException) // если num2 равен нулю, выводится сообщение об ошибке
{
    Console.WriteLine("Ошибка: деление на ноль невозможно.");
}
catch (FormatException) // если пользователь ввёл нецелое число.
{
    Console.WriteLine("Ошибка: введите целые числа.");
}

Console.WriteLine("");
// Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать
// следующую за ней букву в алфавитном порядке.
Console.WriteLine("Домашнее задание 2.1");
Console.Write("Введите букву: ");
char inputChar = Console.ReadKey().KeyChar; // Считываем букву
Console.WriteLine(); // Перенос строки
if (char.IsLetter(inputChar)) // Проверка, что введённый символ - буква
{
    char nextChar = (char)(inputChar + 1); // Находим следующую букву
    if (inputChar == 'z') nextChar = 'a'; // Обработка перехода на начало алфавита
    else if (inputChar == 'Z') nextChar = 'A'; 
    Console.WriteLine($"Следующая буква: {nextChar}");
}
else
{
    Console.WriteLine("Ошибка: введите одиночную букву.");
}
}
}
// Домашнее задание 2.2 Написать программу, которая решает квадратное уравнение.
// Входные данные – коэффициенты уравнения, выходные – найденные корни.
Console.WriteLine("Домашнее задание 2.2");
Console.WriteLine("Введите старший коэффициент:");
double starsh = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второй коэффициент:");
double vtoroi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент:");
double svobodn = Convert.ToDouble(Console.ReadLine());
double d = Math.Pow(vtoroi, 2) - 4 * starsh * svobodn;
if (d > 0)
{
    double kor1 = (-vtoroi + Math.Sqrt(d))/2*starsh;
    double kor2 = (-vtoroi - Math.Sqrt(d))/2*starsh;
    Console.WriteLine(kor1 + " " + kor2);
}
else if (d == 0)
{
    double kor3 = (-vtoroi + Math.Sqrt(d))/2*starsh;
    Console.WriteLine(kor3);
}
else
{
    Console.WriteLine("Действительных корней нет");
}
Console.WriteLine("");